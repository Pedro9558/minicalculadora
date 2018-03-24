using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a calculadora de operações!");
            // Mensagens divertidas
            Random r = new Random();
            string[] TentouQuebrar = { "Bela tentativa! Mas acho que isso não é uma opção! Tente novamente! ;-)", "Você se sente bem quebrando o programa dos outros? Tente novamente!", "Não nessa calculadora! Tente novamente!", "Tudo isso?! Acho que não! Tente novamente!" };
            string[] SemTexto = { "Tente novamente! Desta vez um numeral!", "Eu sou de exatas, não de gramática! Tente novamente!", "Lindo texto! Mas onde estão os números que eu pedi? Tente novamente!", "Textos não irão te ajudar a achar a solução! Tente novamente!", "Uma vez um sábio me disse:\"Você deve colocar um número, gafanhoto! Tente novamente!\"" };
            string[] OperacaoDesconhecida = { "Operação desconhecida! Tente novamente!", "Acho que essa opção não está disponivel...! Tente novamente!", "Leia o menu de operações atentamente e selcione uma válida! Tente novamente!" };
            // Variaveis de menu
            var Continuar = true;
            var Input = "";
            var Escolha = 0;
            // Variaveis de operação
            var A = 0.0;
            var B = 0.0;
            var C = 0.0;
            var Num = 0.0;
            var Porcentagem = 0.0;
            // Programa roda até o usuário não querer mais
            do
            {
                // Menu de escolhas
                Console.WriteLine("Selecione uma das operações abaixo: ");
                Console.WriteLine("1. Calcular 10% de um número");
                Console.WriteLine("2. Calcular x% de um número");
                Console.WriteLine("3. Identificar se o número é par ou ímpar");
                Console.WriteLine("4. Calcular a raiz de uma função de primeiro grau");
                Console.WriteLine("5. Calcular a raiz de uma função de segundo grau");
                Input = Console.ReadLine();
                while (Input.Length >= 18)
                {
                    Console.WriteLine(TentouQuebrar[r.Next(0, TentouQuebrar.Length - 1)]);
                    Input = Console.ReadLine();
                }
                // Checa se o input passado não contem letras
                while (!IsNumberInt(Input))
                {
                    Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                    Input = Console.ReadLine();
                }
                // Checa só pra ter certeza se o input é um numero inteiro
                if (IsNumberInt(Input))
                {
                    Escolha = Convert.ToInt32(Input);
                    // Pede nova escolha caso a escolha feita não esteja no menu
                    while (true)
                    {
                        // Caso esteja, prossiga adiante
                        if (Escolha == 1 || Escolha == 2 || Escolha == 3 || Escolha == 4 || Escolha == 5) break;
                        // Caso não, repita todo procedimento anterior até sair um input válido
                        Console.WriteLine(OperacaoDesconhecida[r.Next(0, OperacaoDesconhecida.Length - 1)]);
                        Input = Console.ReadLine();
                        while (!IsNumberInt(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        if (IsNumberInt(Input))
                        {
                            Escolha = Convert.ToInt32(Input);
                        }
                    }
                    // Escolha 1: Calcular 10% de um número
                    if (Escolha == 1)
                    {
                        Console.WriteLine("Digite um valor");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        // Computando resultados
                        Num = Convert.ToDouble(Input.Replace('.', ','));
                        Console.WriteLine("10% de " + Num + " é igual a: " + OperacaoPorcento(Num, 10));

                    }
                    // Escolha 2: Calcular x% de um número
                    else if (Escolha == 2)
                    {
                        Console.WriteLine("Digite um valor");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        Num = Convert.ToDouble(Input.Replace('.', ','));
                        Console.WriteLine("Digite a porcentagem em %(Exemplo: 50%)");
                        Input = Console.ReadLine();
                        // Checa se fora passado uma porcentagem válida
                        while (!Input.Contains("%"))
                        {
                            Console.WriteLine("Tente novamente! Desta vez uma porcentagem!");
                            Input = Console.ReadLine();
                            // Remove o % para checar se o input é um número válido
                            // Caso o usuário passe um número invalido, pede-se uma nova entrada
                            while (!IsNumberDouble(Input.Replace("%", string.Empty)))
                            {
                                Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                                Input = Console.ReadLine();
                            }
                        }
                        // Computando resultados
                        Porcentagem = Convert.ToDouble(Input.Replace("%", string.Empty).Replace('.', ','));
                        Console.WriteLine(Porcentagem + "% de " + Num + " é igual a: " + OperacaoPorcento(Num, Porcentagem));
                    }
                    //Escolha 3: Identificar se o número é par ou impar
                    else if (Escolha == 3)
                    {
                        Console.WriteLine("Digite um valor inteiro");
                        Input = Console.ReadLine();
                        // Pede um numeral inteiro(Ainda irei trabalhar com doubles depois)
                        while (!IsNumberDouble(Input) || Input.Contains(".") || Input.Contains(","))
                        {
                            Console.WriteLine("Tente novamente! Desta vez um numeral inteiro!");
                            Input = Console.ReadLine();
                        }
                        // Testa se ele não é muito grande
                        if (Input.Length < 18)
                        {
                            Num = Convert.ToDouble(Input.Replace('.', ','));
                        }
                        else
                        {
                            Num = (double)Input[Input.Length - 1];
                        }
                        // Computando resultados
                        if (IsPair(Num))
                        {
                            // Exibe uma mensagem dependendo do tamanho do número
                            if (Input.Length < 18)
                            {
                                Console.WriteLine("O Número " + Num + " é Par!");
                            }
                            else
                            {
                                Console.WriteLine("Esse número gigante é par!");
                            }
                        }
                        else
                        {
                            // Exibe uma mensagem dependendo do tamanho do número
                            if (Input.Length < 18)
                            {
                                Console.WriteLine("O Número " + Num + " é Ímpar!");
                            }
                            else
                            {
                                Console.WriteLine("Esse número gigante é Ímpar!");
                            }
                        }
                    }
                    // Escolha 4: Calcular a raiz de uma função de primeiro grau
                    else if (Escolha == 4)
                    {
                        // Pede o valor de A
                        Console.WriteLine("Digite o valor de A");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        A = Convert.ToDouble(Input);
                        // Testa se A é 0, pois em função de primeiro grau, A não pode ser 0
                        while (A == 0)
                        {
                            Console.WriteLine("A não pode ter valor de 0! Tente novamente!");
                            Input = Console.ReadLine();
                            // Checa se o usuário passou um número válido
                            // Caso o usuário passe um número invalido, pede-se uma nova entrada
                            while (!IsNumberDouble(Input))
                            {
                                Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                                Input = Console.ReadLine();
                            }
                            A = Convert.ToDouble(Input);
                        }
                        Console.WriteLine("Digite o valor de B");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        B = Convert.ToDouble(Input);
                        // Computando resultado
                        Console.WriteLine("O resultado da função para A = " + A + " e B = " + B + " é: " + String.Format("{0:n3}", Operacao1Grau(A, B)));
                    }
                    //Escolha 5: Calcular a raiz de uma função de segundo grau
                    else if (Escolha == 5)
                    {
                        // Pede o valor de A
                        Console.WriteLine("Digite o valor de A");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        A = Convert.ToDouble(Input);
                        // Testa se A é 0, pois em função de segundo grau, A não pode ser 0
                        while (A == 0)
                        {
                            Console.WriteLine("A não pode ter valor de 0! Tente novamente!");
                            Input = Console.ReadLine();
                            while (!IsNumberDouble(Input))
                            {
                                Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                                Input = Console.ReadLine();
                            }
                            A = Convert.ToDouble(Input);
                        }
                        Console.WriteLine("Digite o valor de B");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        B = Convert.ToDouble(Input);
                        Console.WriteLine("Digite o valor de C");
                        Input = Console.ReadLine();
                        // Checa se o usuário passou um número válido
                        // Caso o usuário passe um número invalido, pede-se uma nova entrada
                        while (!IsNumberDouble(Input))
                        {
                            Console.WriteLine(SemTexto[r.Next(0, SemTexto.Length - 1)]);
                            Input = Console.ReadLine();
                        }
                        C = Convert.ToDouble(Input);
                        double[] X = Operacao2Grau(A, B, C);
                        /*
                         * 3 Regras devem ser seguidas na hora de computar o resultado:
                         *          1. Se X[0] && X[1] == NaN isso quer dizer que a função não possui raiz
                         *          2. Se X[0] == X[1] && X[0] != NaN && X[1] != NaN isso quer dizer que a função possui apenas 1 raiz
                         *          3. Se X[0] != X[1] && X[0] != NaN && X[1] != NaN isso quer dizer que a função possui 2 raizes
                         */
                        if (Double.IsNaN(X[0]) && Double.IsNaN(X[1]))
                        {
                            Console.WriteLine("A função A = " + A + ", B = " + B + " e C = " + C + ", não apresenta raiz!");
                        }
                        else if (X[0] == X[1] && !Double.IsNaN(X[0]))
                        {
                            Console.WriteLine("O resultado da função para A = " + A + ", B = " + B + " e C = " + C + " é: X = " + String.Format("{0:n3}", X[0]));
                        }
                        else
                        {
                            Console.WriteLine("O resultado da função para A = " + A + ", B = " + B + " e C = " + C + " é: X1 = " + String.Format("{0:n3}", X[0]) + " X2 = " + String.Format("{0:n3}", X[1]));
                        }
                    }
                }
                // Zona de escolha do usuário entre continuar ou não
                Console.WriteLine("Deseja continuar? Y/N");
                Input = Console.ReadLine();
                // Continua rodando até o usuário escolher entre Y ou N
                while (true)
                {
                    if (Input.Equals("Y") || Input.Equals("N") || Input.Equals("y") || Input.Equals("n")) break;
                    Console.WriteLine(OperacaoDesconhecida[r.Next(0, OperacaoDesconhecida.Length - 1)]);
                    Input = Console.ReadLine();
                }
                // Caso opte por não continuar, o programa sairá do loop e encerrará
                if (Input.Equals("N") || Input.Equals("n"))
                {
                    Continuar = false;
                    break;
                }
            } while (Continuar);
        }
        /// <summary>
        /// Retorna verdadeiro se o item passado for um numeral do tipo double
        /// </summary>
        /// <param name="item">Cadeia de caracteres</param>
        /// <returns>Verdadeiro se a cadeia de caracteres passada for um numeral do tipo double</returns>
        public static bool IsNumberDouble(string Item)
        {
            bool ItIs = true;
            // Checa se o item pode ser convertido em numero
            try
            {
                Convert.ToDouble(Item);
            }
            catch (Exception e)
            {
                ItIs = false;
            }
            return ItIs;
        }
        /// <summary>
        /// Retorna verdadeiro se o item passado for um numeral do tipo inteiro
        /// </summary>
        /// <param name="item">Cadeia de caracteres</param>
        /// <returns>Verdadeiro se a cadeia de caracteres passada for um numeral do tipo inteiro</returns>
        public static bool IsNumberInt(string Item)
        {
            bool ItIs = true;
            // Checa se o item pode ser convertido em numero inteiro
            try
            {
                Convert.ToInt32(Item);
            }
            catch (Exception e)
            {
                ItIs = false;
            }
            return ItIs;
        }
        public static double OperacaoPorcento(double Num, double Porcentagem)
        {
            return Num * (Porcentagem / 100);
        }
        /// <summary>
        /// Realiza o calculo de operação do 1ºgrau através de 2 parametros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>O resultado da operação</returns>
        public static double Operacao1Grau(double A, double B)
        {
            return -B / A;
        }
        /// <summary>
        /// Realiza o calculo de operação do 2ºgrau através de 3 parametros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Os dois resultados possiveis, x1 e x2</returns>
        public static double[] Operacao2Grau(double a, double b, double c)
        {
            // X=-b+-sqrt(b²-4ac)/2a
            var X1 = 0.0;
            var X2 = 0.0;
            // Função separada passo-a-passo para melhor compreensão
            var Delta = (b * b) - 4 * a * c;
            double Temp = Math.Sqrt(Delta);
            double[] X = new double[2];
            X1 = (-b + Temp) / (2 * a);
            X2 = (-b - Temp) / (2 * a);
            X[0] = X1;
            X[1] = X2;
            return X;
        }
        /// <summary>
        /// Testa se o número passado é par
        /// </summary>
        /// <param name="Num"></param>
        /// <returns>Verdade se o número passado é par</returns>
        public static Boolean IsPair(double Num)
        {
            return Num % 2 == 0;
        }
    }
}

