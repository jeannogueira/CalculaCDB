Projeto Calculadora CDB
------------------------------
**Instruções**

Dado desejar calcular o CDB, com objetivo de conhecer seu resultado bruto e o resultado líquido do investimento, siga as seguintes orientações:

Na tela inicial, insira no primeiro campo o valor monetário inicial (entre apenas valores positivos) e no segundo campo, insira um prazo, indicando os meses desejados (indique prazo maior que 1 mês), após clicar confirmando o envio dos dados inseridos, observe na tela o resultado apresentado. Para nova consulta, basta inserir novamente outros parâmetros desejados.

------------------------------
**Sugestões de testes**

1) **Teste de obrigatoriedade de preenchimento dos campos** Realizar a consulta passando o campo de valor monetário inicial vazio e o campo de meses preenchido com 5;
2) **Teste de obrigatoriedade de preenchimento dos campos** Realizar a consulta passando o campo de valor monetário inicial preenchido com 1000 e o campo de meses em branco;
3)  **Teste de obrigatoriedade de preenchimento dos campos** Realizar a consulta passando o campo de valor monetário inicial e o campo em meses em branco;
4) **Teste de formatação de valor inserido** Testar a inserção de valores no campo de valor monetário inicial, passando os valores 1000,10 e 1000.10, ambos inserindo valor válido no campo meses, como sugestão, o valor 7. Outro teste indicado e com o preenchimento com letras em ambos os campos; 
6) **Teste de validação do campo meses** Testar o cálculo passando valores válidos no campo de valor monetário inicial, como por exemplo 100, inserindo conjuntamente, valores no campo mês, como 1, 0 e 13;
7) **Teste de validação do valor monetário inicial** Realizar o cálculo inserindo o valor inválido 0 para o campo de valor monetário inicial e um valor válido no campo mês, como 3. Outro teste realizado deverá ser o a inserção de um valor negativo no campo de valor monetário inicial e um valor válido no campo mês, como 4;
8) **Testes para validação da % em relação aos meses** Testar o cálculo, inserindo valores válidos no campo de valor monetário inicial, como por exemplo 100, inserindo os valores 5, 6, 7, 11, 12, 13, 23, 24 e 25 no campo mês, em cada consulta;
