namespace Listor.practice;

class Program
{
    static void Main(string[] args)
    {
        List<Nocco> Noccolist = new List<Nocco>();
        Noccolist.Add(new Nocco("Nocco Peach Vibe", "peach"));
        Noccolist.Add(new Nocco("Nocco Summer Vibe", "Strawberry"));
        Noccolist.Add(new Nocco("Nocco Tropical Vibe", "Pineapple"));

        foreach (Nocco nocco in Noccolist)
        {
            nocco.NoccoInfo();
        }
    }
}
