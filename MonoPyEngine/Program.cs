class Program
{
    static void Main()
    {
        Engine engine = new Engine();
        engine.Add(new Player());
        engine.Run();
    }
}