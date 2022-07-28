// See https://aka.ms/new-console-template for more information
using RPG.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Arus hero = new Arus("Arus",23,"Knigth");
        Arus wizard = new Arus("Jennica",23,"White Wizard");

        Console.WriteLine(hero.Attack());
        Console.WriteLine(wizard.ToString()+ " " +wizard.Attack());
}
}