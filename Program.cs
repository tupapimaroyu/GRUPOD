namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mi amor buneas tardes");
            int result = sum(2, 3);
            string Nombrecompleto = nombrecompleto("fernando","marupa ");

        }
        public static int sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static string nombrecompleto(string name, string lastname)
        {
            return name + lastname;
        }
    }
}