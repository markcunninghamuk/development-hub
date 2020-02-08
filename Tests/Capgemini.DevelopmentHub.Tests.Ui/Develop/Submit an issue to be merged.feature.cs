// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Capgemini.DevelopmentHub.Tests.Ui.Develop
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SubmitAnIssueToBeMergedFeature : object, Xunit.IClassFixture<SubmitAnIssueToBeMergedFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Submit an issue to be merged.feature"
#line hidden
        
        public SubmitAnIssueToBeMergedFeature(SubmitAnIssueToBeMergedFeature.FixtureData fixtureData, Capgemini_DevelopmentHub_Tests_Ui_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Submit an issue to be merged", "\tIn order to have my completed development merged\r\n\tAs a developer\r\n\tI want to su" +
                    "bmit an issue that has been developed in Dynamics 365", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a solution merge")]
        [Xunit.TraitAttribute("FeatureTitle", "Submit an issue to be merged")]
        [Xunit.TraitAttribute("Description", "Create a solution merge")]
        public virtual void CreateASolutionMerge()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a solution merge", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("I am logged in to the Development Hub app as an admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("I am viewing the Solution Merges sub area of the Develop area", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.When("I select the New command", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field"});
                table5.AddRow(new string[] {
                            "cap_issue"});
                table5.AddRow(new string[] {
                            "cap_targetsolution"});
                table5.AddRow(new string[] {
                            "cap_manualmergeactivities"});
#line 10
 testRunner.Then("I can edit the following fields", ((string)(null)), table5, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a new solution merge without mandatory fields")]
        [Xunit.TraitAttribute("FeatureTitle", "Submit an issue to be merged")]
        [Xunit.TraitAttribute("Description", "Create a new solution merge without mandatory fields")]
        public virtual void CreateANewSolutionMergeWithoutMandatoryFields()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new solution merge without mandatory fields", null, ((string[])(null)));
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
 testRunner.Given("I am logged in to the Development Hub app as an admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.And("I am viewing the Solution Merges sub area of the Develop area", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.When("I select the New command", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.And("I save the record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field"});
                table6.AddRow(new string[] {
                            "cap_issue"});
                table6.AddRow(new string[] {
                            "cap_targetsolution"});
#line 21
 testRunner.Then("a mandatory field error is displayed on the following fields", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a solution merge with manual merge activities")]
        [Xunit.TraitAttribute("FeatureTitle", "Submit an issue to be merged")]
        [Xunit.TraitAttribute("Description", "Create a solution merge with manual merge activities")]
        public virtual void CreateASolutionMergeWithManualMergeActivities()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a solution merge with manual merge activities", null, ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
 testRunner.Given("I am logged in to the Development Hub app as an admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.And("I am viewing the Solution Merges sub area of the Develop area", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("I select the New command", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SubmitAnIssueToBeMergedFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SubmitAnIssueToBeMergedFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
