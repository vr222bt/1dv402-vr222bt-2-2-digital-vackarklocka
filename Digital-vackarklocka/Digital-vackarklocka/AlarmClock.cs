using System;
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

        //Constructors
        public AlarmClock() : this(0,0)
        {

        }

        public AlarmClock(int hour, int minute) : this(hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _hour = hour;
            _minute = minute;
            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }


        //Properties
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                } 
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        //Methods
        public bool TickTock()
        {
            _minute++;
            //BEEP BEEP BEEP
            if (_alarmHour == _hour && _alarmMinute == _minute)
            {
                return true;
            }
            //Lägger på en timme och börjar om från 0 med minuterna           
            if (_minute > 59)
            {
                _hour++;
                _minute = 0;
            }
            if (_hour > 23)
            {
                _hour = 0;
            }

            return false;
        }

        public string ToString()
        {
            return null;
        }
    }
}
