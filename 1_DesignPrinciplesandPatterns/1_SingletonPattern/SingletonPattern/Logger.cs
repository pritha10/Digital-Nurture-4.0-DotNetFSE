﻿using System;

public class Logger
{
    private static Logger instance = null;
    private static readonly object padlock = new object();

    private Logger()
    {
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}
