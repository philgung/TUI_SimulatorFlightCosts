﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TUI_SimulatorFlightCosts_AcceptanceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Calculate_Flight_Distance_And_Fuel_NeededFeature : Xunit.IClassFixture<Calculate_Flight_Distance_And_Fuel_NeededFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Calculate_flight_distance_and_fuel_needed.feature"
#line hidden
        
        public Calculate_Flight_Distance_And_Fuel_NeededFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculate_flight_distance_and_fuel_needed", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(Calculate_Flight_Distance_And_Fuel_NeededFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Calculate_flight_distance_and_fuel_needed")]
        [Xunit.TraitAttribute("Description", "Determine distance between airport London and airport Roissy Charles De Gaulles")]
        public virtual void DetermineDistanceBetweenAirportLondonAndAirportRoissyCharlesDeGaulles()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine distance between airport London and airport Roissy Charles De Gaulles", "");
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("A flight which has a departure airport with GPS Position (London - 51.5048, 0.052" +
                    "745500000014545)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("has a destination airport with GPS Position (Roissy Charles De Gaulle - 49.007, 2" +
                    ".559790000000021)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.And("the aircraft fuel consumption per distance/flight time (1000 L/km) + takeoff effo" +
                    "rt (2000 L)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("is registered in control tower like \'Roissy Charles De Gaulle - London\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When("the simulator calculate travel distance for the flight \'Roissy Charles De Gaulle " +
                    "- London\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the travel distance was 173.66182990855378 km", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Calculate_flight_distance_and_fuel_needed")]
        [Xunit.TraitAttribute("Description", "Determine fuel consumption between airport London and airport Roissy Charles De G" +
            "aulles")]
        public virtual void DetermineFuelConsumptionBetweenAirportLondonAndAirportRoissyCharlesDeGaulles()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Determine fuel consumption between airport London and airport Roissy Charles De G" +
                    "aulles", "");
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("A flight which has a departure airport with GPS Position (London - 51.5048, 0.052" +
                    "745500000014545)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.And("has a destination airport with GPS Position (Roissy Charles De Gaulle - 49.007, 2" +
                    ".559790000000021)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("the aircraft fuel consumption per distance/flight time (1000 L/km) + takeoff effo" +
                    "rt (2000 L)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("is registered in control tower like \'Roissy Charles De Gaulle - London\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("the simulator calculate the fuel consumption for the flight \'Roissy Charles De Ga" +
                    "ulle - London\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the total fuel consumption was 175661.82990855377 L", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Calculate_Flight_Distance_And_Fuel_NeededFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Calculate_Flight_Distance_And_Fuel_NeededFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

