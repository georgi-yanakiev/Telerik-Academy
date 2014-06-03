// Call class

using System;

namespace CellPhone
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialedNumber;
        private int duration;
        
        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public DateTime DateAndTime // date and time property
        {
            get { return this.dateAndTime; }

            set { this.dateAndTime = value; }
        }

        public string DialedNumber // dialed number property
        {
            get { return this.dialedNumber; }

            set { this.dialedNumber = value; }
        }

        public int Duration // duration property
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}