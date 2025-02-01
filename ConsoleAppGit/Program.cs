namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado d = new Dado();
            int valore1 = d.LanciaDado();
            int valore2 = d.LanciaDado();
            Console.WriteLine($"{valore1} {valore2}");
        }
    }
}
