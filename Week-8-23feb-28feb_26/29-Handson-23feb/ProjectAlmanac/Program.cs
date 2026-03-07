namespace ProjectAlmanac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almanac al = new Almanac();

            Console.WriteLine(al.assignProject("John", "ProjectA"));
            Console.WriteLine(al.assignProject("John", "ProjectB"));
            Console.WriteLine(al.assignProject("Alice", "ProjectX"));

            var johnProjects = al.currentProjects("John");
            Console.WriteLine("John's Projects:");
            foreach (var p in johnProjects)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(al.finishProject("John", "ProjectA"));

            johnProjects = al.currentProjects("John");
            Console.WriteLine("John's Updated Projects:");
            foreach (var p in johnProjects)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}