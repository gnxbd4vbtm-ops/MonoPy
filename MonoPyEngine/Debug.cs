using System;

// Simple logging system
public static class Debug
{

    //log function
    public static void Log(object msg)
    { 
        Console.WriteLine("[Debug] " + msg);
    }

    //log warn
    public static void Warning(object msg)
    {
        Console.WriteLine("[Warning] " + msg);
    }

    //log error
    public static void Error(object msg)
    {
        Console.WriteLine("[Error] " + msg);
    }
}