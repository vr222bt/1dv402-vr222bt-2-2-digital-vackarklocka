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
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }


        //Properties
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Du måste sätta larmet mellan 0 och 23 timmar!");
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
                    throw new ArgumentException("Du måste sätta larmet mellan 0 och 59 minuter!");
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
                    throw new ArgumentException("Du måste sätta klockans timmar mellan 0 och 23!");
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
                    throw new ArgumentException("Du måste sätta klockans minuter mellan 0 och 59!");
                }
                _minute = value;
            }
        }

        //Methods
        public bool TickTock()
        {
            _minute++;

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

            //BEEP BEEP BEEP
            if (_alarmHour == _hour && _alarmMinute == _minute)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            
            return String.Format("\t{0,2:0}:{1:00} <{2:0}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
        }
    }
}
