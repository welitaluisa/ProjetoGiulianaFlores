@Carrinho
Feature: Adicionar e Excluir Cesta de Produto no Carrinho
    
    Background:
        Given que estou na página inicial do site
        And aceito o controle de privacidade
        Then vejo o texto "ESCOLHA O SEU PRESENTE"

    Scenario: Adicionar e Excluir Cesta no Carrinho
    
        When clico na imagem Cestas
        And digito o CEP "69313530"
        And aguardo a lista de endereço ser exibida
        And escolho um endereço da lista
        And clico no botão Aplicar do popup do CEP
        Then valido o titulo "CESTAS" na pagina inicial 

        When clico na imagem Cestas de Aniversário      
        Then valido o titulo "CESTAS DE ANIVERSÁRIO"

        When clico na imagem Cesta Especial de Aniversário        
        And vejo o texto do botão "ADICIONAR AO CARRINHO"
        And clico no botão ADICIONAR AO CARRINHO
        Then vejo um popup "SELECIONE A DATA E O PERÍODO DE ENTREGA" 

        When clico no radio referente a data da entrega
        And clico no botão OK do popup
        Then vejo os detalhes da Cesta "DESCRIÇÃO:"
        And vejo o nome "CESTA ESPECIAL DE ANIVERSÁRIO" da cesta
        And vejo o preço "R$ 209,90" da cesta
        And Vejo o código "Cód. Produto: 30106" da cesta 
        
        When clico no botao em Adicionar ao carrinho 
        And espero que a imagem do carrinho esteja visível
        Then vejo o titulo do carrinho "MEU CARRINHO"

        When clico no botão Excluir do carrinho
        Then vejo que o carrinho está vazio "0"

    

        Scenario Outline: Adicionar e Excluir Cesta no Carrinho DDT
        When clico na imagem Cestas
        And digito o CEP "<cep>"
        And aguardo a lista de endereço ser exibida
        And escolho um endereço da lista
        And clico no botão Aplicar do popup do CEP
        Then valido o titulo "CESTAS" na pagina inicial 

        When clico na imagem Cestas de Aniversário      
        Then valido o titulo "CESTAS DE ANIVERSÁRIO"

        When clico na imagem Cesta Especial de Aniversário        
        And vejo o texto do botão "ADICIONAR AO CARRINHO"
        And clico no botão ADICIONAR AO CARRINHO
        Then vejo um popup "SELECIONE A DATA E O PERÍODO DE ENTREGA" 

        When clico no radio referente a data da entrega
        And clico no botão OK do popup
        Then vejo o nome "<NameProduct>" da cesta
        And vejo o preço "<PrecoProduct>" da cesta
        And Vejo o código "<CodProduct>" da cesta 
        
        When clico no botao em Adicionar ao carrinho 
        And espero que a imagem do carrinho esteja visível
        Then vejo o titulo do carrinho "MEU CARRINHO"

        When clico no botão Excluir do carrinho
        Then vejo que o carrinho está vazio "0"

    Examples:
    | cep      |  NameProduct                 | PrecoProduct | CodProduct |
    |69313530  |CESTA ESPECIAL DE ANIVERSÁRIO |R$ 209,90     |Cód. Produto: 30106|
    |57081783  |CAIXA DE VINHO E CHOCOLATE    |R$ 239,90     |Cód. Produto: rs-5287-15151|
    |59631420  |CESTA DE CHOCOLATES DOÇURA    |R$ 399,90     |Cód. Produto: 26274 |             
    