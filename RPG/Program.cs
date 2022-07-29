// See https://aka.ms/new-console-template for more information
using RPG.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        knigth arus = new knigth("Arus",42,"Knigth","469 / 479","72 / 72");
        Ninja  wedge = new Ninja("Wedge", 42,"Ninja","292 / 579","89 / 89");
        Wizard jennica = new Wizard("Jennica",42,"White Wizard","325 / 601","474 / 482");        
        Wizard topapa = new Wizard("Topapa",42,"Black Wizard","106 / 385","611 / 641");

        Console.WriteLine(arus.display());
        Console.WriteLine(wedge.display());
        Console.WriteLine(jennica.display());
        Console.WriteLine(topapa.display());




}
}