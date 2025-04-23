namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            var westPlayoffTeams = new List<string> { "Thunder", "Grizzlies", "Nuggets", "Clippers", "Lakers", "Timberwolves", "Rockets", "Warriors"};

            var orderByLength = westPlayoffTeams.OrderBy(x => x.Length).ToList();

            Console.WriteLine("Teams ordered by string length:");
            orderByLength.ForEach(x => Console.WriteLine(x));
        }
    }
}
