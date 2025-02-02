namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <string> list = new List<string>() {"Zelda", "Pokemon", "Mario", "Animal Crossing", "StarFox"};

            var order = list.OrderByDescending(x => x.Length);

            foreach (var item in order)
            Console.WriteLine(item);
        }
    }
}
