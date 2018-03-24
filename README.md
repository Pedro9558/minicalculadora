# Exercicio de Mini Calculadora
Um programa feito para base de estudos, uma mini calculadora que realiza alguns calculos.

## Operações

1. Calcular 10% de um número
2. Calcular X% de um número
3. Identificar se um número é par ou ímpar
4. Calcular a raiz de uma função de primeiro grau
5. Calcular a raiz de uma função de segundo grau

## Descrição das Operações

1. **Calcular 10% de um número**
   - Recebe um determinado *número* digitado pelo usuário e retorna *10%* desse *número*.
2. **Calcular X% de um número**
   - Recebe um determinado *número* digitado pelo usuário, mas também recebe outro número *X%* que equivale a porcentagem a ser calculada, e retorna *X%* desse *número*.
3. **Identificar se um número é par ou ímpar**
   - Recebe um determinado *número inteiro* digitado pelo usuário e retorna se o *número inteiro* é *par* ou *ímpar*
4. **Calcular a raiz de uma função de primeiro grau**
   - Recebe dois valores *A* e *B*, sendo *A* diferente de *0*, e retorna a raiz da função de primeiro grau seguindo a equação:
   
   > f(x) = ax + b onde f(x) = 0
   
5. **Calcular a raiz de uma função de segundo grau**
   - Recebe três valores *A*, *B* e *C*, sendo *A* diferente de *0*, e retorna nenhuma, uma ou mais raizes dependendo do resultado da função seguindo as equações:
  
   > f(x) = ax² + bx + c onde f(x) = 0
   
   <br />
   > Δ = b² - 4ac
   
   <br />
   > x = -b +- √Δ / 2a
   
   
## Exemplos de Testes

***Menu Principal***
```
Bem-vindo a calculadora de operações!
Selecione uma das operações abaixo: 
1. Calcular 10% de um número
2. Calcular x% de um número
3. Identificar se o número é par ou ímpar
4. Calcular a raiz de uma função de primeiro grau
5. Calcular a raiz de uma função de segundo grau
```
***Testando Operações***
1. **Calcular 10% de um número**
	```
	>> 1
	Digite um Valor
	>> 50
	10% de 50 é igual a: 5
	Deseja continuar? Y/N
	>> N
	```
2. **Calcular x% de um número**
	```
	>> 2
	Digite um Valor
	>> 50
	Digite a porcentagem em %(Exemplo:50%)
	>> 25%
	25% de 52 é igual a: 13
	Deseja continuar? Y/N
	>> N
	```
3. **Identificar se o número é par ou ímpar** <br />
	*teste 1 - número inteiro normal*
	```
	>> 3
	Digite um valor inteiro
	>> 29
	O Número 29 é Ímpar!
	Deseja continuar? Y/N
	>> N
	```
	*teste 2 - número inteiro enorme*
	```
	>> 3
	Digite um valor inteiro
	>> 99999999999999999999999999999999999999999999999999999999999
	Este número gigante é Ímpar!
	Deseja continuar? Y/N
	>> N
	```
4. **Calcular a raiz de uma função de primeiro grau**
	```
	>> 4
	Digite o valor de A
	>> 0
	A não pode ter o valor de 0! Tente novamente!
	>> 5
	Digite o valor de B
	>> -9
	O resultado da função para A = 5 e B = -9 é: 1,800
	```
5. **Calcular a raiz de uma função de segundo grau** <br />
	*teste 1 - resultado 2 raizes*
    ```
	>> 5
	Digite o valor de A
	>> 9
	Digite o valor de B
	>> 4
	Digite o valor de C
	>> -6
	O resultado da função para A = 9, B = 4 e C = -6 é: X1 = 0,624 X2 = -1,068
	Deseja continuar? Y/N
	>> N
	```
	*teste 2 - resultado 1 raiz*
	```
	>> 5
	Digite o valor de A
	>> 8
	Digite o valor de B
	>> 8 
	Digite o valor de C
	>> 2
	O resultado da função para A = 8, B = 8 e C = 2 é: X = -0,500
	Deseja Continuar? Y/N
	>> N
	```
	*teste 3 - resultado nenhuma raiz*
	```
	>> 5
	Digite o valor de A
	>> 10
	Digite o valor de B
	>> -4
	Digite o valor de C
	>> 8
	A função A = 10, B = -4 e C = 8, não apresenta raiz!
	Deseja continuar?
	>> N
	```
	
