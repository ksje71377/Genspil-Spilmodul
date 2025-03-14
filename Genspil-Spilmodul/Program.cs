namespace Genspil_Spilmodul
{
    class Game
    {
        private string title;
        private string genre;
        private string variant;
        private string developer;

    }
    class Client
    {
        private string name;
        private string address;
        private string email;
        private string phoneNumber;
        private string city;
        private string postalCode;
    }
    public enum AgeRating
    {
        from0,
        from3,
        from7,
        from11,
        from15,
        from18,
    }
    public enum GameState
    {
        inStock,
        notInStock,
        requested,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
