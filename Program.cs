using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potenciacao(); break;
                case 6: Porcentagem(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }


        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Potenciacao()
        {

            Console.Clear();

            Console.WriteLine("Base do expoente");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Expoente");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O resultado da  Potenciação é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Entre com o Valor");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor do desconto");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 * (v2 / 100);
            Console.WriteLine($"O resultado do desconto é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }

}
