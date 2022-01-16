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
        private DateTime now;
        private DateTime _startTimeSpan;
        private bool _startTimer;
        private string _command;

        public DateTime Now
        {
            get { return this.now; }
        }

        public DateTime StartTimeSpan
        {
            get { return this._startTimeSpan; }
            set { this._startTimeSpan = value; }
        }

        public string Command
            {
             get
             {
                return this._command; 
             }
             set
             {
             if ( value == "start" || value == "START" || value == "Start")
             {
                this._command = value;

             }
             else if ( value == "stop" || value == "STOP" || value == "Stop")
             { 
                this._command = value;
             }
             else
             {
                Console.WriteLine("Invalid Command. Please try again.");
             }

             }
        }
        public bool StartTimer
        {
            get { return this._startTimer; }
            set
            {
                if (StartTimer == true)
                {
                    Console.WriteLine("Please stop the timer before starting again.");
                }
                else
                {
                    StartTimer = value;
                }
            }
        }

        public StopWatch()
        {
            this.now = DateTime.Now;
            this._startTimeSpan = DateTime.Now;
            this._startTimer = false;
            this._command = null;

        }

        public bool stateChecker()
        {
            var incomming = Command.ToLower();
            if (incomming == "start")
            {
                StartTimer = true;
                Start();
            }
            else if (incomming == "stop")
            {
                Stop();
                StartTimer = false;
            }
            return stateChecker();
        }
        public DateTime Start()
        {
            if (StartTimer == true)
            {
                var StartTimeSpan = Now;
            }
            else
            {
               Console.WriteLine("start error");
            }

            return StartTimeSpan;
        }

        public string Stop()
        {
            TimeSpan timeElapsed = Now - StartTimeSpan;

            var hours = timeElapsed.Hours.ToString("00") + ":" ;
            var minutes = timeElapsed.Minutes.ToString("00") + ":";
            var seconds = timeElapsed.Seconds.ToString("00") + ".";
            int tenths = timeElapsed.Milliseconds / 100;
            tenths.ToString("0");

            string interval = hours + minutes + seconds + tenths;

            return interval;

         }
        

    }
}
