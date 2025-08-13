using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AulasDio
{
    public class conteudoAulas
    {
        public void TipodeDados()
        {
            //- int: números inteiros(ex: 1, 100, -5)
            //- float: números de ponto flutuante(ex: 3.14f)
            //- double: números de ponto flutuante de dupla precisão(ex: 2.718281828)
            //- char: um caractere Unicode(ex: 'a', 'Z', '1')
            //- bool: valores booleanos(true ou false)
            //- byte: números inteiros de 8 bits(0 a 255)
            //- short: números inteiros de 16 bits(-32.768 a 32.767)
            //- long: números inteiros de 64 bits
            //- decimal: números decimais de alta precisão(ex: 10.99m)
            //- struct: pode ser usado para criar tipos de valor personalizados
            //- enum: define um conjunto de constantes nomeadas

            string msg = "Seja Bem-vindo ao C#";
            int quantidade = 2;
            double altura = 1.70;
            decimal preco = 1.70M;
            bool condicao = true;

            Console.WriteLine(msg);
            Console.WriteLine($"valor da variavel quantidade: {quantidade} ");
            Console.WriteLine($"valor da variavel altura: {altura.ToString("0.0")}");
            Console.WriteLine($"valor da variavel preco: {preco}");
            Console.WriteLine($"valor da variavel condicao: {condicao}");
        }
        public void OperadorCondicional()
        {
            // Utilizando IF & ELSE
            int quantidadeEstoque = 10;
            int quantidadeCompra = 2;
            bool statusVenda = quantidadeEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"É possivel realizar a venda? {quantidadeEstoque >= quantidadeCompra}");

            if (quantidadeEstoque >= quantidadeCompra)
            {
                Console.WriteLine("Compra realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade não disponivel em Estoque");
            }

        }
        //Operadores Aritméticos
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }



        // Funções Trigonométricas
        public void Seno(double grau)
        {
            double radiano = grau * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {grau}º é: {Math.Round(seno, 2)}");
        }
        public void Cosseno(double grau)
        {
            double radiano = grau * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"O Cosseno de {grau}º é: {Math.Round(cosseno, 2)}");
        }
        public void Tangente(double grau)
        {
            double radiano = grau * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O Tangente de {grau}º é: {Math.Round(tangente, 2)}");
        }

        // Incremento e Decremento
        public void Incremento()
        {
            int numero = 10;
            numero++;
            Console.WriteLine(numero);
        }

        public void Decremento()
        {
            int numero = 10;
            numero--;
            Console.WriteLine(numero);
        }

        // Raiz Quadrada
        public void raizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é: {Math.Round(raiz, 2)}");
        }


        // Estruturas de Repetições

        public void estruturaFor()
        {

            int numero = 10;

            // for (inicialização; condição; incremento)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
        }
        public void estruturaWhile()
        {
            string senha = "";
            while (senha != "1234")
            {
                Console.WriteLine("Digite sua senha: ");
                string? input = Console.ReadLine();
                senha = input ?? ""; // Evitar valores nulos
            }
            Console.WriteLine("Acesso liberado!");

            int numero = 5;
            int contador = 1;

            // Interrompendo o Fluxo de execução
            while (contador <= 10)
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                contador++;

                if (contador == 6)
                {
                    break;
                }
            }
        }
        public void estruturaDoWhile()
        {
            int opcao;

            do
            {
                Console.WriteLine("1 - Olá");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha: ");
                opcao = Convert.ToInt32(Console.ReadLine());
             

                if (opcao == 1)
                {
                    Console.WriteLine("Olá, usuário");
                }

            }
            while (opcao != 2);
        }
        
    }
}