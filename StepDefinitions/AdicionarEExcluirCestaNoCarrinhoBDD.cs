using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace ProjetoGiulianaFloresBDD
{
    [Binding]
    public class AdicionaEExcluiCestaProdutoNoCarrinhoSteps
    {
        private IWebDriver driver; // Objeto do Selenium
        //private WebDriverWait wait;

        [BeforeScenario]
        public void SetUp()
        {   
            // Faz o download e instalação da versão mais recente do ChromeDriver
            new DriverManager().SetUpDriver(new ChromeConfig());    
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-notifications");
            // Insttancia o objeto do Selenium como Chrome
            driver = new ChromeDriver(chromeOptions); 
            // Configura uma espera de 5 segundos para qualquer elemento aparecer
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            // Maxinize a janela do navegador
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit(); // Encerra o Selenium
        }

        [Given(@"que estou na página inicial do site")]
        public void GivenQueEstouNaPaginaInicialDoSite()
        {
            driver.Navigate().GoToUrl("https://www.giulianaflores.com.br/");
        }

        [Given(@"aceito o controle de privacidade")]
        public void GivenAceitoOControleDePrivacidade()
        {
            driver.FindElement(By.Id("adopt-accept-all-button")).Click();
        }

        [Then(@"vejo o texto ""(.*)""")]
        public void ThenVejoOTexto(string txtInicial)
        {
            Assert.That(driver.FindElement(By.CssSelector(".custom-cesta-container > h2")).Text, Is.EqualTo(txtInicial));
        }        

        [When(@"clico na imagem Cestas")]
        public void WhenClicoNaImagemCestas()
        {
            driver.FindElement(By.CssSelector("#content-site > div.carousel-brands.carousel-brads-desktop > ul > div > div > div:nth-child(3) > li > a > img")).Click();
        }

        [When(@"digito o CEP ""(.*)""")]
        public void WhenDigitoOCEP(string CEP)
        {
            driver.FindElement(By.Id("inputSearchAddress")).SendKeys(CEP);
        }

        [When(@"aguardo a lista de endereço ser exibida")]
        public void WhenAguardoAListaDeEnderecoSerExibida()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMicroseconds(5000));
            wait.Until(d => driver.FindElement(By.CssSelector("#listAddressItems > ul > li")).Displayed);
        }

        [When(@"escolho um endereço da lista")]
        public void WhenEscolhoUmEnderecoDaLista()
        {
            driver.FindElement(By.CssSelector("li.itemAddress")).Click();
        }

        [When(@"clico no botão Aplicar do popup do CEP")]
        public void WhenClicoNoBotaoAplicarDoPopupDoCEP()
        {
            driver.FindElement(By.CssSelector("div.apply-button")).Click();
        }

        [Then(@"valido o titulo ""(.*)"" na pagina inicial")]
        public void ThenValidoOTituloNaPaginaInicial(string title)
        {
            Assert.That(driver.FindElement(By.Id("title-defaut")).Text, Is.EqualTo(title));
        }

        [When(@"clico na imagem Cestas de Aniversário")]
        public void WhenClicoNaImagemCestasDeAniversario()
        {
            driver.FindElement(By.CssSelector("#content-site > div.main > div.dept.wrapper > div.carousel-brands.carousel-brads-desktop > ul > div > div > div:nth-child(2) > li > a")).Click();
        }

        [Then(@"valido o titulo ""(.*)""")]
        public void validoOTitulo(string tituloDept)
        {
            Assert.That(driver.FindElement(By.Id("title-defaut")).Text, Is.EqualTo(tituloDept));
        }

        [When(@"clico na imagem Cesta Especial de Aniversário")]
        public void WhenClicoNaImagemCestaEspecialDeAniversario()
        {
            driver.FindElement(By.CssSelector("#conteudo-produtos-filtro > div.content-dept.menu-hide > div.center-side > div:nth-child(2) > ul > li:nth-child(1) > div > a > div.image-content > img")).Click();
        }

        [When(@"vejo o texto do botão ""(.*)""")]
        public void WhenVejoOTextoDoBotao(string txtBtnAddCarrinho)
        {
            Assert.That(driver.FindElement(By.Id("ContentSite_lbtBuy")).Text, Is.EqualTo(txtBtnAddCarrinho));
        }

        [When(@"clico no botão ADICIONAR AO CARRINHO")]
        public void WhenClicoNoBotaoADICIONARAOCARRINHO()
        {
            driver.FindElement(By.Id("ContentSite_lbtBuy")).Click();
        }

        [Then(@"vejo um popup ""(.*)""")]
        public void ThenVejoUmPopup(string txtPopUpCarrinho)
        {
            Assert.That(driver.FindElement(By.ClassName("title-carrinho-produto")).Text,Is.EqualTo(txtPopUpCarrinho));
        }

        [When(@"clico no radio referente a data da entrega")]
        public void WhenClicoNoRadioReferenteADataDaEntrega()
        {
            driver.FindElement(By.ClassName("jPeriodRadio")).Click();
        }

        [When(@"clico no botão OK do popup")]
        public void WhenClicoNoBotaoOKPopup()
        {
            driver.FindElement(By.Id("btConfirmShippingData")).Click();
        }

        [Then(@"vejo o nome ""(.*)"" da cesta")]
        public void ThenVejoONomeDaCesta(string NameProduct)
        {
            Assert.That(driver.FindElement(By.Id("ContentSite_lblProductDsName")).Text, Is.EqualTo(NameProduct));
        }

        [Then(@"vejo o preço ""(.*)"" da cesta")]
        public void ThenVejoOPrecoDaCesta(string PrecoProduct)
        {
            Assert.That(driver.FindElement(By.CssSelector(".preco_prod > .precoPor_prod")).Text, Is.EqualTo(PrecoProduct));;
        }

        [Then(@"Vejo o código ""(.*)"" da cesta")]
        public void ThenVejoOCodigoDaCesta(string CodProduct)
        {
            Assert.That(driver.FindElement(By.Id("lblIdProduct")).Text, Is.EqualTo(CodProduct));
        }

        [When(@"clico no botao em Adicionar ao carrinho")]
        public void WhenClicoNoBotaoEmAdicionarAoCarrinho()
        {                
            driver.FindElement(By.CssSelector("#ContentSite_lbtBuy")).Click();
        }       

        [When(@"espero que a imagem do carrinho esteja visível")]
        public void WhenEsperoQueAImagemDoCarrinhoEstejaVisivel()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMicroseconds(5000));
            wait.Until(d => driver.FindElement(By.Id("imgBasket")).Displayed);
        }

        [Then(@"vejo o titulo do carrinho ""(.*)""")]
        public void ThenVejoOTituloDoCarrinho(string txtTitleCarrinho)
        {
            Assert.That(driver.FindElement(By.Id("title-defaut")).Text, Is.EqualTo(txtTitleCarrinho));
        }

        [When(@"clico no botão Excluir do carrinho")]
        public void WhenClicoNoBotaoExcluirDoCarrinho()
        {
            driver.FindElement(By.Id("ContentSite_Basketcontrol1_rptBasket_rptBasketItems_0_lbtRemoveProduct_0")).Click();
        }

        [Then(@"vejo que o carrinho está vazio ""(.*)""")]
        public void ThenVejoOCarrinhoEstaVazio(string QtdItemCarrinho)
        {
            Assert.That(driver.FindElement(By.Id("carrinho-display")).Text, Is.EqualTo(QtdItemCarrinho));
        }
    }
}