using System;
using System.Reflection;
using HelloWorld.Exercises;
using System.Linq;
using InterviewPrepLib.DataStructures;
using InterviewPrepLib.Algorithms;

namespace HelloWorld;

class Program
{
    static int Main(string[] args)
    {
        string choice = "";
        if (args.Length == 0)
        {
            Console.WriteLine("Enter exercise to run (e.g., 1 or Exercise1): ");
            choice = Console.ReadLine() ?? "";
        }
        else
        {
            choice = args[args.Length - 1];
            Console.WriteLine($"Running Exercise {choice}...");
        }

        // Allow both "1" and "Exercise1"
        string className = choice.StartsWith("Exercise")
            ? $"HelloWorld.Exercises.{choice}"
            : $"HelloWorld.Exercises.Exercise{choice}";

        // Use reflection to find the type in all loaded assemblies
        Type? exerciseType = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .FirstOrDefault(t => t.FullName == className);

        if (exerciseType != null)
        {
            MethodInfo? runMethod = exerciseType.GetMethod("Run", BindingFlags.Public | BindingFlags.Static);
            if (runMethod != null)
            {
                runMethod.Invoke(null, null);
            }
            else
            {
                Console.WriteLine($"{className} found, but no public static Run() method.");
            }
        }
        else
        {
            Console.WriteLine($"No such exercise: {className}.");
        }

        return 0;
    }
}

