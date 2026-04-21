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
    private double fixedInterval = Time.fixedDeltaTime; // Use Time.fixedDeltaTime

    public void Add(GameObject obj)
    {
        // Add object and call Awake once
        objects.Add(obj);
        obj.Awake();
        obj.OnEnable();
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

            // Update time
            Time.UpdateTime();

            // Update input state
            Input.Update();

            // Call Update on all objects
            foreach (var obj in objects)
                obj.Update(dt);

            // Call LateUpdate on all objects
            foreach (var obj in objects)
                obj.LateUpdate(dt);

            // Handle FixedUpdate timing
            fixedTimer += dt;

            while (fixedTimer >= Time.fixedDeltaTime)
            {
                Time.UpdateFixedTime();
                foreach (var obj in objects)
                    obj.FixedUpdate(Time.fixedDeltaTime);

                fixedTimer -= Time.fixedDeltaTime;
            }

            // Prevent 100% CPU usage
            Thread.Sleep(1);
        }
    }
}