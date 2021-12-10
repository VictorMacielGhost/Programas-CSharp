using System;
using System.Globalization;
namespace Primeiro
{
    class Program
    {
        public int ChamarPrograma()
        {
            bool artur = false; // booleana// true or false
            char genero = 'f'; // char == letra unica (?)
            char unicode = '\u0041';
            byte n1 = 255; // -256 - 255
            int n2 = 235435; // -235436 - 235435
            long n3 = 346534985L; // bem grande, utilize "L" ao fim
            sbyte n4 = 23; // recomendo só utilizar categoria long ou int
            byte n5 = byte.MinValue; // para saber quais sao os valores minumus
            sbyte n6 = sbyte.MinValue;
            int n7 = int.MinValue;
            float n8 = float.MaxValue; // para saber quais sao os valores maximos
            n8++;

            double flutuante = 753.2495;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            if (artur == false)
            {
                Console.WriteLine("ArturIsGae");
            }
            Console.WriteLine(genero);
            Console.WriteLine(unicode);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);

            Console.WriteLine(flutuante.ToString("F3", CultureInfo.CurrentCulture)); // adicionar "," ou "." de acordo com a "cultura" da maquina do usuario // nota: necessita de "system.globalization" para funcionar (using)_

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            string assinanteNome = "Victor";
            decimal saldo = 334556;
            int idade = 15;


            Console.WriteLine("{0} tem {1} anos, e ja tem {2} reais", assinanteNome, idade, saldo);

            Console.WriteLine("----------------------------Bashkara-----------------------------");
            Console.WriteLine("Digite o Valor B");
            string B = Console.ReadLine();
            Console.WriteLine("Digite o Valor de A");
            string A = Console.ReadLine();
            Console.WriteLine("Digite o Valor de C");
            string C = Console.ReadLine();

            Console.WriteLine("Foi digitado o valor {0} como {1}, {2} como valor {3} e {4} como valor {5}", B, "B", A, "A", C, "C");
            Console.ReadKey();
            return 1;
        }

    }     
}
