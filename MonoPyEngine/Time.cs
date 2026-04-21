using System.Diagnostics;

// Time system for delta time tracking
public static class Time
{
    private static Stopwatch sw = Stopwatch.StartNew();
    private static double lastTime;

    public static float deltaTime;

    // This method must be called every frame by the engine
    public static void UpdateTime()
    {
        double now = sw.Elapsed.TotalSeconds;
        deltaTime = (float)(now - lastTime);
        lastTime = now;
    }
}