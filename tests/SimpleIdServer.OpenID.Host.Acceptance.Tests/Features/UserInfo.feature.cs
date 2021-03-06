// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UserInfoFeature : Xunit.IClassFixture<UserInfoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserInfo.feature"
#line hidden
        
        public UserInfoFeature(UserInfoFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserInfo", "\tCheck the userinfo endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user information are returned (JSON)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Check user information are returned (JSON)")]
        public virtual void CheckUserInformationAreReturnedJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user information are returned (JSON)", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table191 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table191.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table191.AddRow(new string[] {
                        "scope",
                        "profile"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table191, "When ");
#line 10
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table192 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table192.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 13
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table192, "And ");
#line hidden
            TechTalk.SpecFlow.Table table193 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table193.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table193.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table193.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 17
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table193, "And ");
#line 23
 testRunner.And("add user consent : user=\'administrator\', scope=\'profile\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table194 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table194.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 25
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table194, "And ");
#line 29
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("HTTP header \'Content-Type\' contains \'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("JSON \'name\'=\'Thierry Habart\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user information are returned (JWS)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Check user information are returned (JWS)")]
        public virtual void CheckUserInformationAreReturnedJWS()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user information are returned (JWS)", null, ((string[])(null)));
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table195 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table195.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 36
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table195, "When ");
#line hidden
            TechTalk.SpecFlow.Table table196 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table196.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table196.AddRow(new string[] {
                        "scope",
                        "profile"});
            table196.AddRow(new string[] {
                        "userinfo_signed_response_alg",
                        "ES256"});
#line 40
 testRunner.And("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table196, "And ");
#line 46
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table197 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table197.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table197.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table197.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 49
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table197, "And ");
#line 55
 testRunner.And("add user consent : user=\'administrator\', scope=\'profile\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table198 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table198.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 57
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table198, "And ");
#line 61
 testRunner.And("extract string from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("HTTP header \'Content-Type\' contains \'application/jwt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check user information are returned (JWE)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Check user information are returned (JWE)")]
        public virtual void CheckUserInformationAreReturnedJWE()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check user information are returned (JWE)", null, ((string[])(null)));
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table199 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table199.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 66
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks_sig\'", ((string)(null)), table199, "When ");
#line hidden
            TechTalk.SpecFlow.Table table200 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table200.AddRow(new string[] {
                        "ENC",
                        "2",
                        "RSA1_5"});
#line 70
 testRunner.And("build JSON Web Keys, store JWKS into \'jwks\' and store the public keys into \'jwks_" +
                    "json\'", ((string)(null)), table200, "And ");
#line hidden
            TechTalk.SpecFlow.Table table201 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table201.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table201.AddRow(new string[] {
                        "scope",
                        "profile"});
            table201.AddRow(new string[] {
                        "userinfo_signed_response_alg",
                        "ES256"});
            table201.AddRow(new string[] {
                        "userinfo_encrypted_response_alg",
                        "RSA1_5"});
            table201.AddRow(new string[] {
                        "userinfo_encrypted_response_enc",
                        "A128CBC-HS256"});
            table201.AddRow(new string[] {
                        "jwks",
                        "$jwks_json$"});
#line 74
 testRunner.And("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table201, "And ");
#line 83
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table202 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table202.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table202.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table202.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 86
 testRunner.And("use \'1\' JWK from \'jwks_sig\' to build JWS and store into \'accesstoken\'", ((string)(null)), table202, "And ");
#line 92
 testRunner.And("add user consent : user=\'administrator\', scope=\'profile\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table203 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table203.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 94
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table203, "And ");
#line 98
 testRunner.And("extract string from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("HTTP header \'Content-Type\' contains \'application/jwt\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Use claims parameter to get user information from UserInfo endpoint")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Use claims parameter to get user information from UserInfo endpoint")]
        public virtual void UseClaimsParameterToGetUserInformationFromUserInfoEndpoint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use claims parameter to get user information from UserInfo endpoint", null, ((string[])(null)));
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table204 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table204.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 103
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table204, "When ");
#line hidden
            TechTalk.SpecFlow.Table table205 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table205.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table205.AddRow(new string[] {
                        "scope",
                        "email"});
#line 107
 testRunner.And("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table205, "And ");
#line 112
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table206 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table206.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table206.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table206.AddRow(new string[] {
                        "claims",
                        "{ userinfo: { name: { essential : true }, email: { essential : true } } }"});
#line 115
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table206, "And ");
#line 121
 testRunner.And("add user consent with claim : user=\'administrator\', scope=\'email\', clientId=\'$cli" +
                    "ent_id$\', claim=\'name email\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table207 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table207.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 123
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table207, "And ");
#line 127
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.Then("HTTP header \'Content-Type\' contains \'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("JSON \'name\'=\'Thierry Habart\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("JSON \'email\'=\'habarthierry@hotmail.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Use offline_access scope to get user information from UserInfo endpoint")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfo")]
        [Xunit.TraitAttribute("Description", "Use offline_access scope to get user information from UserInfo endpoint")]
        public virtual void UseOffline_AccessScopeToGetUserInformationFromUserInfoEndpoint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use offline_access scope to get user information from UserInfo endpoint", null, ((string[])(null)));
#line 133
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table208 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table208.AddRow(new string[] {
                        "SIG",
                        "1",
                        "RS256"});
#line 134
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table208, "When ");
#line hidden
            TechTalk.SpecFlow.Table table209 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table209.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table209.AddRow(new string[] {
                        "grant_types",
                        "[authorization_code,refresh_token]"});
            table209.AddRow(new string[] {
                        "response_types",
                        "[code]"});
            table209.AddRow(new string[] {
                        "scope",
                        "offline_access"});
            table209.AddRow(new string[] {
                        "subject_type",
                        "public"});
            table209.AddRow(new string[] {
                        "token_endpoint_auth_method",
                        "client_secret_post"});
#line 138
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table209, "When ");
#line 147
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("extract parameter \'client_secret\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.And("add user consent : user=\'administrator\', scope=\'offline_access\', clientId=\'$clien" +
                    "t_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table210 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table210.AddRow(new string[] {
                        "response_type",
                        "code"});
            table210.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table210.AddRow(new string[] {
                        "state",
                        "state"});
            table210.AddRow(new string[] {
                        "response_mode",
                        "query"});
            table210.AddRow(new string[] {
                        "scope",
                        "openid offline_access"});
            table210.AddRow(new string[] {
                        "redirect_uri",
                        "https://web.com"});
            table210.AddRow(new string[] {
                        "ui_locales",
                        "en fr"});
#line 152
 testRunner.And("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table210, "And ");
#line 162
 testRunner.And("extract parameter \'refresh_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table211 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table211.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table211.AddRow(new string[] {
                        "client_secret",
                        "$client_secret$"});
            table211.AddRow(new string[] {
                        "grant_type",
                        "refresh_token"});
            table211.AddRow(new string[] {
                        "refresh_token",
                        "$refresh_token$"});
#line 164
 testRunner.And("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table211, "And ");
#line 171
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table212 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table212.AddRow(new string[] {
                        "Authorization",
                        "Bearer $access_token$"});
#line 174
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table212, "And ");
#line 178
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
 testRunner.Then("HTTP header \'Content-Type\' contains \'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
 testRunner.Then("JSON \'sub\'=\'administrator\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UserInfoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UserInfoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
