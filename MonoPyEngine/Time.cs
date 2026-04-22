using System.Diagnostics;

namespace MonoPy;

// Time system for delta time tracking
public static class Time
{
    private static Stopwatch sw = Stopwatch.StartNew();
    private static double lastTime;

    // Time since startup
    public static float time { get; private set; }

    // Time since last frame
    public static float deltaTime { get; private set; }

    // Fixed timestep for physics
    public static float fixedDeltaTime = 0.02f; // 50Hz

    // Time since last fixed update
    public static float fixedTime { get; private set; }

    // This method must be called every frame by the engine
    public static void UpdateTime()
    {
        double now = sw.Elapsed.TotalSeconds;
        deltaTime = (float)(now - lastTime);
        lastTime = now;
        time = (float)now;
    }

    // Called when fixed update runs
    public static void UpdateFixedTime()
    {
        fixedTime += fixedDeltaTime;
    }
}