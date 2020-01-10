using System;
using System.Collections.Generic;
using System.Text;

namespace COUNTDOWN.core
{
    public class BossList
    {
        private string _boss1 = "";
        private string _boss2 = "";
        private int _hour;
        private int _minute;
        private string _day;

        public BossList(string boss1, string boss2, int hour, int minute, string day)
        {
            _boss1 = boss1;
            _boss2 = boss2;
            _hour = hour;
            _minute = minute;
            _day = day;
        }

        public string boss1()
        {
            return _boss1;
        }
        public string boss2()
        {
            return _boss2;
        }
        public string day()
        {
            return _day;
        }
        public int hour()
        {
            return _hour;
        }
        public int minute()
        {
            return _minute;
        }
    }
}