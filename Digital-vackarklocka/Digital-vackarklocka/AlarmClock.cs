﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{
    public class AlarmClock
    {
        //Deklarerar fält
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;


        public AlarmClock()
        {

        }

        public AlarmClock(int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _hour = hour;
            _minute = minute;
            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }


        
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                _minute = value;
            }
        }

        public bool TickTock()
        {
            return false;
        }

        public string ToString()
        {
            return null;
        }
    }
}
