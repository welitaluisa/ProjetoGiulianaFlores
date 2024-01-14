﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ProjetoGiulianaFlores.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Adicionar e Excluir Cesta de Produto no Carrinho")]
    [NUnit.Framework.CategoryAttribute("Carrinho")]
    public partial class AdicionarEExcluirCestaDeProdutoNoCarrinhoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "Carrinho"};
        
#line 1 "AdicionarEExcluiCestaNoCarrinho.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Adicionar e Excluir Cesta de Produto no Carrinho", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
    #line hidden
#line 5
        testRunner.Given("que estou na página inicial do site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
        testRunner.And("aceito o controle de privacidade", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
        testRunner.Then("vejo o texto \"ESCOLHA O SEU PRESENTE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adicionar e Excluir Cesta no Carrinho")]
        public void AdicionarEExcluirCestaNoCarrinho()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adicionar e Excluir Cesta no Carrinho", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
    this.FeatureBackground();
#line hidden
#line 11
        testRunner.When("clico na imagem Cestas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
        testRunner.And("digito o CEP \"69313530\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
        testRunner.And("aguardo a lista de endereço ser exibida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
        testRunner.And("escolho um endereço da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
        testRunner.And("clico no botão Aplicar do popup do CEP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
        testRunner.Then("valido o titulo \"CESTAS\" na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
        testRunner.When("clico na imagem Cestas de Aniversário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
        testRunner.Then("valido o titulo \"CESTAS DE ANIVERSÁRIO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
        testRunner.When("clico na imagem Cesta Especial de Aniversário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
        testRunner.And("vejo o texto do botão \"ADICIONAR AO CARRINHO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
        testRunner.And("clico no botão ADICIONAR AO CARRINHO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
        testRunner.Then("vejo um popup \"SELECIONE A DATA E O PERÍODO DE ENTREGA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
        testRunner.When("clico no radio referente a data da entrega", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
        testRunner.And("clico no botão OK do popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
        testRunner.And("vejo o nome \"CESTA ESPECIAL DE ANIVERSÁRIO\" da cesta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
        testRunner.And("vejo o preço \"R$ 209,90\" da cesta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
        testRunner.And("Vejo o código \"Cód. Produto: 30106\" da cesta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
        testRunner.When("clico no botao em Adicionar ao carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
        testRunner.And("espero que a imagem do carrinho esteja visível", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
        testRunner.Then("vejo o titulo do carrinho \"MEU CARRINHO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
        testRunner.When("clico no botão Excluir do carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
        testRunner.Then("vejo que o carrinho está vazio \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adicionar e Excluir Cesta no Carrinho DDT")]
        [NUnit.Framework.TestCaseAttribute("69313530", "CESTA ESPECIAL DE ANIVERSÁRIO", "R$ 209,90", "Cód. Produto: 30106", null)]
        [NUnit.Framework.TestCaseAttribute("57081783", "CAIXA DE VINHO E CHOCOLATE", "R$ 239,90", "Cód. Produto: rs-5287-15151", null)]
        [NUnit.Framework.TestCaseAttribute("59631420", "CESTA DE CHOCOLATES DOÇURA", "R$ 399,90", "Cód. Produto: 26274", null)]
        public void AdicionarEExcluirCestaNoCarrinhoDDT(string cep, string nameProduct, string precoProduct, string codProduct, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("cep", cep);
            argumentsOfScenario.Add("NameProduct", nameProduct);
            argumentsOfScenario.Add("PrecoProduct", precoProduct);
            argumentsOfScenario.Add("CodProduct", codProduct);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adicionar e Excluir Cesta no Carrinho DDT", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
    this.FeatureBackground();
#line hidden
#line 42
        testRunner.When("clico na imagem Cestas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
        testRunner.And(string.Format("digito o CEP \"{0}\"", cep), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
        testRunner.And("aguardo a lista de endereço ser exibida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
        testRunner.And("escolho um endereço da lista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
        testRunner.And("clico no botão Aplicar do popup do CEP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
        testRunner.Then("valido o titulo \"CESTAS\" na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
        testRunner.When("clico na imagem Cestas de Aniversário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
        testRunner.Then("valido o titulo \"CESTAS DE ANIVERSÁRIO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
        testRunner.When("clico na imagem Cesta Especial de Aniversário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
        testRunner.And("vejo o texto do botão \"ADICIONAR AO CARRINHO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
        testRunner.And("clico no botão ADICIONAR AO CARRINHO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
        testRunner.Then("vejo um popup \"SELECIONE A DATA E O PERÍODO DE ENTREGA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
        testRunner.When("clico no radio referente a data da entrega", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
        testRunner.And("clico no botão OK do popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
        testRunner.Then(string.Format("vejo o nome \"{0}\" da cesta", nameProduct), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
        testRunner.And(string.Format("vejo o preço \"{0}\" da cesta", precoProduct), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
        testRunner.And(string.Format("Vejo o código \"{0}\" da cesta", codProduct), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
        testRunner.When("clico no botao em Adicionar ao carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
        testRunner.And("espero que a imagem do carrinho esteja visível", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
        testRunner.Then("vejo o titulo do carrinho \"MEU CARRINHO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
        testRunner.When("clico no botão Excluir do carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
        testRunner.Then("vejo que o carrinho está vazio \"0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
