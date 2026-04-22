using System;

namespace MonoPy;

// Simple logging system
public static class Debug
{
    //log function
    public static void Log(object msg)
    {
        Console.WriteLine("[Debug] " + msg);
    }

    //log warn
    public static void LogWarning(object msg)
    {
        Console.WriteLine("[Warning] " + msg);
    }

    //log error
    public static void LogError(object msg)
    {
        Console.WriteLine("[Error] " + msg);
    }

    // Unity-style aliases
    public static void Warning(object msg) => LogWarning(msg);
    public static void Error(object msg) => LogError(msg);

    // Assert (simple version)
    public static void Assert(bool condition, object msg = null)
    {
        if (!condition)
        {
            LogError("Assertion failed: " + (msg ?? "No message"));
        }
    }
}