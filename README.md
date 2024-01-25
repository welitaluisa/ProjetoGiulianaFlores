# Projeto GiulianaFlores

Este projeto é o terceiro desafio do curso de formação em Teste de Software turma 139 da Iterasys.
O Desafio consiste em criar um projeto de automação Web usando C# e SpecFlow.
Foi testado à funcionalidade de adicionar e excluir cestas de produtos no carrinho do site da Giuliana Flores. (Usando o site: https://www.giulianaflores.com.br/,) O projeto utiliza a abordagem BDD (Behavior Driven Development) para criar cenários de teste compreensíveis.

# Estrutura do Projeto
-  Evidencias: Pasta contém a gravação dos testes referente ao testes simples e dos testes usando BDD. 
- Features: Contém arquivos de especificação de funcionalidades em linguagem Gherkin.

- StepDefinitions: contém o arquivo de implementação dos passos definidos nas features. Aqui contém o código execultavel do teste. 

# Executando os Testes

Para executar os testes do projeto, siga as instruções abaixo:

Pré-requisitos:
1. Certifique-se de ter todas as dependências do projeto instaladas. No Arquivo ProjetoGiulianaFlores.csproj contém todas as dependências necessárias.

2. Clone o Repositório: 

git clone: https://github.com/welitaluisa/ProjetoGiulianaFlores.git

3. Após clonar e configurar o projeto execulte o comando: 
    3.1 dotnet test -v n ( Roda todos os testes)
    3.2 dotnet test -- filter comprarCesta ( roda um teeste expecifico)

4. Massa de Testes
O projeto utiliza cenários de exemplo (examples) na seção "Examples" das features para fornecer dados de entrada variados (Data-Driven Testing - DDT). Os valores fornecidos na tabela Examples são usados como entradas para os testes, permitindo testar diferentes casos com os mesmos passos de teste.

