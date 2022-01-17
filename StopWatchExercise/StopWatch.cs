using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace StopWatchExercise
{ class StopWatch
    {
        private DateTime _startTimeSpan;
        private DateTime _stopTimeSpan;
        private bool _startTimer;
        private string _command;

       
        public string Command
            {
             get
             {
                return this._command; 
             }
             set
             {
             if ( value == "start")
             {
                this._command = value;

             }
             else if ( value == "stop")
             { 
                this._command = value;
             }
             else
             {
                Console.WriteLine("Invalid Command. Please try again.");
             }

             }
        }
        
    
        public StopWatch()
        {
            _stopTimeSpan = DateTime.Now;
            _startTimeSpan = DateTime.Now;
            _startTimer = false;
            _command = Command;

        }

        public Boolean InitiateTimer()
        {
            if (Command == "start")
            {
                _startTimer = true;
                Start();
            }
            else if (Command == "stop")
            {
                Stop();
                _startTimer = false;
            }
            return _startTimer;
        }
        public DateTime Start()
        {
            if (_startTimer == true)
            {
                _startTimeSpan = DateTime.Now;
                Console.WriteLine(_startTimeSpan);
            }
            else
            {
               Console.WriteLine("start error");
            }

            return _startTimeSpan;
        }

        public TimeSpan Stop()
        {
           _stopTimeSpan = DateTime.Now;
          
            TimeSpan timeElapsed = _stopTimeSpan - _startTimeSpan;


            var hours = timeElapsed.Hours.ToString("00") + ":";
            var minutes = timeElapsed.Minutes.ToString("00") + ":";
            var seconds = timeElapsed.Seconds.ToString("00") + ".";
            int tenths = timeElapsed.Milliseconds / 100;
            tenths.ToString("0");

            Console.WriteLine("Time Elapsed (hours/minutes/seconds/milliseconds): " + hours + minutes + seconds + tenths );

            return timeElapsed;

         }
        

    }
}
