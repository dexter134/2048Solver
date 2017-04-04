namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solver solver = new Solver();
            solver.CreateGame();
            solver.Run();
        }
    }
}
