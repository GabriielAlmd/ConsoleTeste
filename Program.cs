using System;
using System.Globalization;
namespace ConsoleAp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 25.45879; //declarando variaveis double X int Y .....
            int y = 22;
            string z = "Marta";
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
              string frase = "Gabriel é um otimo programador, e LOGO vai ser um Master SENIOR";

            Console.WriteLine(frase.ToLower());    //comando pra deixar todas as letras minusculas
            Console.WriteLine(frase.ToUpper());    //comando pra deixar todas as letras maiusculas
            Console.WriteLine(frase.IndexOf('1'));   //primeira posição do caractere indicado
            Console.WriteLine(frase.LastIndexOf('G')); //ultima posição do caractere indicado
            Console.WriteLine(frase.Substring(0, 4));  //recorta a string passando uma posição inicial e final
            Console.WriteLine(frase.Substring(4));   //recorta a string a partir da posição indicada
            Console.WriteLine(frase.Replace('g', 'G')); //subistitui um caracter indicado por outro tambem indicado
            Console.WriteLine(frase.Replace("Gabriel", "Bruno")); //substitui uma palavra por outra

        }
    }
}
