// See https://aka.ms/new-console-template for more information
using Projeto_RPG.src.Entities;
class Program 
{
    static void Main(string[] args)
    {
        Knight arus = new Knight("Arus", 23, "Knight", 469, 72);
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 325, 474);
        Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);
        Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 106, 601);

        Console.WriteLine(); 
        Console.WriteLine(arus);
        Console.WriteLine(arus.Damage());
        Console.WriteLine();

        Console.WriteLine(wizard);
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine();

        Console.WriteLine(topapa);
        Console.WriteLine(topapa.Cure());
        Console.WriteLine();

        Console.WriteLine(wedge);
        Console.WriteLine(wedge.Attack());
        
        
        
        
    }
}
