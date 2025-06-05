namespace HelloWorldApp;
public class Greeter
{
    public static string SayHello() => "Hello, World!";
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Greeter.SayHello());
    }
}
