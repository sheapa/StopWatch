using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace StopWatchExercise
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var StopWatch = new StopWatch();
            Console.WriteLine("This is a stopwatch application. Type start to start timer. Type stop to end timer.");
            StopWatch.Command = Console.ReadLine();
            StopWatch.InitiateTimer();
            Console.Write("Enter 'stop' to find out how much time has passed. ");
            StopWatch.Command = Console.ReadLine();
            StopWatch.InitiateTimer();
            //Console.WriteLine(StopWatch.Stop());


            
        }
    }
}