namespace GreeterLib
{
    public class Greeter : IGreeter
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}! Welcome to .NET Modularity 😄";
        }
    }
}