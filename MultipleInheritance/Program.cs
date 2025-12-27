namespace MultipleInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck donald = new Duck("Donald");
            donald.Fly();
            donald.Swim();
            Parrot polly = new Parrot("Polly");
            polly.Fly();
            polly.Sing();
        }
    }
}
