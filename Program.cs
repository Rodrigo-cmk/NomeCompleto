using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {




           
           string nome; 
           string sobrenome;
           string nomeCatalogo;
           string nomeCompleto; 
           

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine("-- NomeCompleto e NomeCatálogo --");
           Console.WriteLine();

           Console.WriteLine("Por favor digite seu primeiro nome:");
           Console.ForegroundColor=ConsoleColor.DarkYellow;
           nome = Console.ReadLine(); 
           Console.ForegroundColor=ConsoleColor.White;


           Console.WriteLine();
           Console.WriteLine("Por favor digite seu sobrenome:");
           Console.ForegroundColor=ConsoleColor.DarkYellow;
           sobrenome = Console.ReadLine();
           Console.ForegroundColor=ConsoleColor.White;

           
           nomeCompleto = $"{nome} {sobrenome}";
           nomeCatalogo = $"{sobrenome.ToUpper()} {nome}";
           Console.WriteLine();

           Console.WriteLine();
           Console.ForegroundColor=ConsoleColor.DarkYellow;
           Console.WriteLine($"Nome Completo: {nomeCompleto}");
           Console.WriteLine($"Nome de Catálogo: {nomeCatalogo}");
           Console.ForegroundColor=ConsoleColor.White;







        }
    }
}
 