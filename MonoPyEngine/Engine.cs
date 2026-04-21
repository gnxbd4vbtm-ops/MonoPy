using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class Engine
{
    // List of all objects in the engine
    public List<GameObject> objects = new();

    // Stopwatch used for timing
    private Stopwatch sw = Stopwatch.StartNew();

    // Time tracking variables
    private double lastTime;
    private double fixedTimer;
    private double fixedInterval = 0.02; // 50Hz fixed update

    public void Add(GameObject obj)
    {
        // Add object and call Start once
        objects.Add(obj);
        obj.Start();
    }

    public void Run()
    {
        // Initialize time
        lastTime = sw.Elapsed.TotalSeconds;

        // Main loop
        while (true)
        {
            double now = sw.Elapsed.TotalSeconds;

            // Delta time between frames
            float dt = (float)(now - lastTime);
            lastTime = now;

            // Call Update on all objects
            foreach (var obj in objects)
                obj.Update(dt);

            // Handle FixedUpdate timing
            fixedTimer += dt;

            while (fixedTimer >= fixedInterval)
            {
                foreach (var obj in objects)
                    obj.FixedUpdate((float)fixedInterval);

                fixedTimer -= fixedInterval;
            }

            // Prevent 100% CPU usage
            Thread.Sleep(1);
        }
    }
}