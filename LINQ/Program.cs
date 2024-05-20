namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGamesNames = new List<string>() { "Call Of Duty: Black Ops 1", "Call Of Duty: Black Ops 2", "Call Of Duty: Black Ops 3" };

            videoGamesNames.Add("Call Of Duty: Modern Warfare 2");
            videoGamesNames.Add("Call Of Duty: Modern Warfare 3");

            var orderedVideoGames = videoGamesNames.OrderBy(name => name.Length);
            foreach (var videoGame in orderedVideoGames)
            {
                Console.WriteLine(videoGame);
            }

        }


    }
}
