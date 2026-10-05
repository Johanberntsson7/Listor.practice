namespace Listor.practice;


public class Nocco
{
    public string Name { get; set;}

    public string Flavor { get; set;}
    
    public Nocco(string name, string flavor)
    {
        Name = name;
        Flavor = flavor;
    }

    public void NoccoInfo()
    {
        Console.WriteLine($"Name: {Name}, Flavor: {Flavor}");
    }
}
 