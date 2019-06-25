﻿namespace Capgemini.DevelopmentHub.Develop.CodeActivities
{
    using System;
    using System.Activities;
    using System.Net;
    using Capgemini.DevelopmentHub.BusinessLogic;
    using Capgemini.DevelopmentHub.BusinessLogic.Extensions;
    using Capgemini.DevelopmentHub.BusinessLogic.Logging;
    using Capgemini.DevelopmentHub.Develop.BusinessLogic;
    using Capgemini.DevelopmentHub.Repositories;
    using Microsoft.Xrm.Sdk.Workflow;

    /// <summary>
    /// Merges solution components from a source solution to a target solution.
    /// </summary>
    [CrmPluginRegistration(
        nameof(MergeSolutionComponents),
        FriendlyName,
        Description,
        Group,
        IsolationModeEnum.Sandbox)]
    public class MergeSolutionComponents : IntegratedWorkflowActivity
    {
        /// <summary>
        /// The friendly name of the custom workflow activity.
        /// </summary>
        public const string FriendlyName = "Merge solution components";

        /// <summary>
        /// The description of the custom workflow activity.
        /// </summary>
        public const string Description = "Merges from a source solution into a target solution";

        /// <summary>
        /// The group of the custom workflow activity.
        /// </summary>
        public const string Group = "Capgemini.DevelopmentHub.Develop";

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeSolutionComponents"/> class.
        /// </summary>
        public MergeSolutionComponents()
        {
        }

        /// <summary>
        /// Gets or sets the unique name of the source solution.
        /// </summary>
        [RequiredArgument]
        [Input("Source solution unique name")]
        public InArgument<string> SourceSolutionUniqueName { get; set; }

        /// <summary>
        /// Gets or sets the unique name of the target solution.
        /// </summary>
        [RequiredArgument]
        [Input("Target solution unique name")]
        public InArgument<string> TargetSolutionUniqueName { get; set; }

        /// <summary>
        /// Gets or sets whether to delete the source solution after a succesful merge.
        /// </summary>
        [RequiredArgument]
        [Input("Delete source solution after merge")]
        [Default("true")]
        public InArgument<bool> DeleteSourceSolutionAfterMerge { get; set; }

        /// <summary>
        /// Gets or sets true if the import was successful or false if the merge failed.
        /// </summary>
        [Output("Succeeded")]
        public OutArgument<bool> IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the error message encountered while merging (if any).
        /// </summary>
        [Output("Error")]
        public OutArgument<string> Error { get; set; }

        /// <inheritdoc/>
        protected override void ExecuteWorkflowActivity(CodeActivityContext context, IWorkflowContext workflowContext, IODataClient oDataClient, ILogWriter logWriter, IRepositoryFactory repoFactory)
        {
            var sourceSolutionUniqueName = this.SourceSolutionUniqueName.GetRequired(context, nameof(this.SourceSolutionUniqueName));
            var targetSolutionUniqueName = this.TargetSolutionUniqueName.GetRequired(context, nameof(this.TargetSolutionUniqueName));
            var deleteSourceSolutionAfterMerge = this.DeleteSourceSolutionAfterMerge.Get(context);

            var oDataSolutionService = context.GetExtension<IODataSolutionService>() ?? new ODataSolutionService(new ODataRepositoryFactory(oDataClient), logWriter);

            try
            {
                oDataSolutionService.MergeSolutionComponents(sourceSolutionUniqueName, targetSolutionUniqueName, deleteSourceSolutionAfterMerge).Wait();
            }
            catch (AggregateException ex) when (ex.InnerException is WebException)
            {
                this.IsSuccessful.Set(context, false);
                this.Error.Set(context, ex.InnerException.Message);
                return;
            }

            this.IsSuccessful.Set(context, true);
        }
    }
}
