namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Store store = new Store();

            Console.WriteLine("Welcome to Kyle's Lemonade Stand" );
            Console.WriteLine();


            Weather weather = new Weather();

            weather.GenereateForecase();
            weather.DisplayForecast();
            Console.WriteLine();

            while (true)
            {
                player.DisplayStatus();
                break;
            }
            
           
        }
    }
}