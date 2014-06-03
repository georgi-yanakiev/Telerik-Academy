// Class for battery

using System;
using System.Text;

namespace CellPhone
{
    public enum BatteryType
    {
        LiIon,
        NiCd,
        NiMH
    }

    public class Battery
    {
        private BatteryType batteryModel;
        private int? hoursIdle; // using nullable types
        private int? hoursTalked;

        public Battery(BatteryType baterryModel, int? hoursIdle) : this(baterryModel, hoursIdle, null)
        {
        }

        public Battery(BatteryType baterryModel, int? hoursIdle, int? hoursTalked)
        {
            this.BatteryModel = baterryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalked = hoursTalked;
        }

        public BatteryType BatteryModel // Battery model property
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int? HoursIdle // Hours Idle property
        {
            get
            {
                return this.hoursIdle;
            }
            set  // using validation 
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdle = value; 
                }
                else
                {
                    throw new ArgumentException("Idle hours can't be null!");
                }
            }
        }

        public int? HoursTalked // Hours Talk property
        {
            get
            {
                return this.hoursTalked;
            }
            set  // using validation 
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalked = value;
                }
                else
                {
                    throw new ArgumentException("Hours Talk can't be null!");
                }
            }
        }

        // method for displaying
        public override string ToString()
        {
            StringBuilder batteryText = new StringBuilder();
            batteryText.AppendLine("----Battery test----");
            batteryText.AppendLine(this.batteryModel.ToString());
            batteryText.AppendLine(this.hoursIdle.ToString());
            batteryText.AppendLine(this.hoursTalked.ToString());
            return batteryText.ToString();
        }
    }
}