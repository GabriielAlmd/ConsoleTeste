using System;
using System.Globalization;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784; //declarando variaveis double X int Y .....
            int y = 32;
            string z = "Maria";
            char w = 'F';
            Console.Write("Olá mundo!"); //ESCREVE SEM QUEBRA DE LINHA  
            Console.WriteLine("Bom dia!"); //ESCREVE QUEBRANDO UMA LINHA ABAIXO 
            Console.WriteLine("Até mais.");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //COM ATE DUAS CASAS DPS DA VIRGULA
            Console.WriteLine(x.ToString("F4")); //COM ATE 4 CASA DPS DA VIRGULA
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // SUBSTITUI VIRG POR PONTO
            Console.WriteLine();//quebra uma linha vazia
            Console.WriteLine("RESULTADO = " + x); // CONCATENA COM VARIAVEL "x"
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine(); 
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();

           //===============================================================================


        }
    }
}