using GreeterLib;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// register dependency
services.AddSingleton<IGreeter, Greeter>();

// build container
var provider = services.BuildServiceProvider();

// resolve dependency
var greeter = provider.GetRequiredService<IGreeter>();

Console.WriteLine(greeter.SayHello("Prity"));
