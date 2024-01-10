//Namespace // Pacote // Grupo de Classe // Worspace
namespace ProjetoGiulianaFlores;

// Biblioteca // Dependências
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

[TestFixture] // Configuração do teste 

// Classe
public class AdicionaEExcluiCestaProdutoNoCarrinhoTest 
{
//Atributos // Campos 
private IWebDriver driver;

[SetUp] // Configura método para ser executado antes dos testes
public void Before() 
{
    // Faz o download e instalação da versão mais recente do ChromeDriver
    new DriverManager().SetUpDriver(new ChromeConfig());    
    ChromeOptions chromeOptions = new ChromeOptions();
    chromeOptions.AddArguments("--disable-notifications");
    // Insttancia o objeto do Selenium como Chrome
    driver = new ChromeDriver(chromeOptions); 
    // Configura uma espera de 5 segundos para qualquer elemento aparecer
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500000);
    // Maxinize a janela do navegador
    driver.Manage().Window.Maximize();

}
[TearDown] // Configura um método para ser usado depois dos testes
public void After()
{
    driver.Quit(); // Destruir o objeto do Selenium na memória 
}
[Test]
public void AdicionaEExcluiuCestaNoCarrinho()
{
    // Configura uma espera de 5 segundos para qualquer elemento aparecer
    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMicroseconds(5000));
    
    // Navegar para a pagina
    driver.Navigate().GoToUrl("https://www.giulianaflores.com.br/");

    // Maximize a tela do navegador
    driver.Manage().Window.Maximize();

    // aceita o controle de privacidade
    driver.FindElement(By.Id("adopt-accept-all-button")).Click();

    // valida que o texto esta presente na pagina inical 
    Assert.That(driver.FindElement(By.CssSelector(".custom-cesta-container > h2")).Text, Is.EqualTo("ESCOLHA O SEU PRESENTE"));

    // clica na imagem relacionada a Cestas 
    string productNameCarouselPageInicial  = "Cestas Especiais";
    string cssSelectorproductNameCarouselPageInicial = $".owl-carousel:nth-child(1) .owl-item:nth-child(3) img[alt='{productNameCarouselPageInicial}']";
    driver.FindElement(By.CssSelector(cssSelectorproductNameCarouselPageInicial)).Click();

    // Clica no X para fechar o popup de busca de endereço 
    driver.FindElement(By.ClassName("close-button")).Click(); 

    // validar que esta na seção Cestas
    Assert.That(driver.FindElement(By.Id("title-defaut")).Text, Is.EqualTo("CESTAS"));

    // Clica no link  Cestas de Aniversário
    string productNameCarouselListEspecial  = "Cestas de Aniversário";
    string cssSelectorproductNameCarouselListEspecial = $".owl-carousel:nth-child(1) .owl-item:nth-child(2) img[alt='{productNameCarouselListEspecial}']";
    driver.FindElement(By.CssSelector(cssSelectorproductNameCarouselListEspecial)).Click();
    
   // Digita o CEP no campo
    driver.FindElement(By.Id("inputSearchAddress")).SendKeys("41601080");

    // Aguarda até que a lista de endereços seja exibida (ajuste o tempo limite conforme necessário)
    wait.Until(d => driver.FindElement(By.CssSelector("#listAddressItems > ul > li")).Displayed);

    // Escolhe o endereço exibido exibido na lista
    driver.FindElement(By.CssSelector("li.itemAddress")).Click();

    // Clica no botão "Aplicar" do popup dp CEP
    driver.FindElement(By.CssSelector("div.apply-button")).Click();

   // Valida o titulo do depto Cestas de Aniversário 
    Assert.That(driver.FindElement(By.CssSelector(".titulo-dept")).Text, Is.EqualTo("CESTAS DE ANIVERSÁRIO"));

    // Clicar na imagem do titulo Cesta de Chocolate Delícias Nutella e Rafaello
    string productNameListEspecial = "Cesta de Chocolate Delícias Nutella e Rafaello";
    string cssSelectorListEspecial = $"#conteudo-produtos-filtro > div.content-dept.menu-hide > div.center-side > div:nth-child(2) > ul > li div a img[alt='{productNameListEspecial}']";
    driver.FindElement(By.CssSelector(cssSelectorListEspecial)).Click();

    // Validar o botão Adicionar ao Carrinho
    Assert.That(driver.FindElement(By.Id("ContentSite_lbtBuy")).Text, Is.EqualTo("ADICIONAR AO CARRINHO"));

    // Clique no botão Adicionar ao Carrinho
    driver.FindElement(By.Id("ContentSite_lbtBuy")).Click();
    
    // validar o titulo do PopUp
    Assert.That(driver.FindElement(By.ClassName("title-carrinho-produto")).Text,Is.EqualTo("SELECIONE A DATA E O PERÍODO DE ENTREGA"));

    //clica no radio do popup
    driver.FindElement(By.ClassName("jPeriodRadio")).Click();

    // Clicar no botão OK do PopUp
    driver.FindElement(By.Id("btConfirmShippingData")).Click();

    //Valida o nome da Cesta Cesta de Chocolate Delícias Nutella e Rafaello
    Assert.That(driver.FindElement(By.Id("ContentSite_lblProductDsName")).Text, Is.EqualTo("CESTA DE CHOCOLATE DELÍCIAS NUTELLA E RAFAELLO"));

    // Valida preco da cesta 
    Assert.That(driver.FindElement(By.CssSelector(".preco_prod > .precoPor_prod")).Text, Is.EqualTo("R$ 249,90"));

    // Valida o codigo da cesta 
    Assert.That(driver.FindElement(By.Id("lblIdProduct")).Text, Is.EqualTo("Cód. Produto: 27966"));

     // Clicar em Adicionar ao carrinho 
    driver.FindElement(By.Id("ContentSite_lbtBuy")).Click();

    // Espera até que a imagem do carrinho esteja visível
    wait.Until(d => driver.FindElement(By.Id("imgBasket")).Displayed);

    // validar o titulo meu carrinho 
    Assert.That(driver.FindElement(By.Id("title-defaut")).Text, Is.EqualTo("MEU CARRINHO"));

    // Clicar botão Excluir do carrinho 
    driver.FindElement(By.Id("ContentSite_Basketcontrol1_rptBasket_rptBasketItems_0_lbtRemoveProduct_0")).Click();

    // valida que o carrinho esta vazio 
    Assert.That(driver.FindElement(By.Id("carrinho-display")).Text, Is.EqualTo("0"));
    }
}