// GSM class

using System;
using System.Text;
using System.Collections.Generic;

namespace CellPhone
{
    public class GSM
    {
        public Battery Battery = new Battery(BatteryType.LiIon, null, null);
        public Display Display = new Display(0, null);
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private List<Call> callHistory = new List<Call>(); // list for call history

        static private GSM iPhone = new GSM("IPhone","Apple",123); // iphone static field
        
        public GSM(string model, string manufacturer, int price) : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
               

        public static GSM IPhone // iphone static property
        {
            get { return iPhone; }
        }

        public string Model // Model property
        {
            get { return this.model; }
            set // validation
            {
                if (value.Length >= 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Model name cannot be empty");
                }
            }
        }

        public string Manufacturer // Manufacturer property
        {
            get { return this.manufacturer; }
            set // validation
            {
                if (value.Length >= 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Manufacturer cannot be emtpy");
                }
            }
        }

        public int? Price // price property
        {
            get { return this.price; }
            set // validation
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException(" Price cannot be null");
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set  // validation
            {
                if (value == null || value.Length >= 0)
                {
                    this.owner = value; 
                }
                else
                {
                    throw new ArgumentException("Owner cannot be null");
                }
            }
        }

        
        public void AddCall(DateTime now, string number, int duration) // call history method
        {
            Call myCall = new Call(now, number, duration);
            callHistory.Add(myCall);
        }

        public void RemoveCallByDuration(int duration)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration == duration)
                {
                    callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearHistory() // clear history method
        {
            callHistory.Clear();
        }

        public void DisplayCallHistory()
        {
            StringBuilder callHistoryText = new StringBuilder();
            callHistoryText.AppendLine("----------CALL History test-------------");
            //Console.WriteLine("---------------------------------");
            foreach (var call in callHistory)
            {
                callHistoryText.AppendFormat("No: {0}  {1},  Duration: {2} seconds\n", call.DialedNumber, call.DateAndTime, call.Duration);
            }

            //Console.WriteLine("---------------------------------");

            Console.WriteLine(callHistoryText.ToString());
        }

        public double CalcPrice(double pricePerMinute)
        {
            double time = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                time = time + callHistory[i].Duration;
            }

            double price = pricePerMinute * (Math.Ceiling(time / 60));
            return price;
        }

        public override string ToString()
        {
            StringBuilder gsmText = new StringBuilder();
            gsmText.AppendLine("----------GSM test------------");
            gsmText.AppendLine(this.model);
            gsmText.AppendLine(this.manufacturer);
            gsmText.AppendLine(this.price.ToString());
            gsmText.AppendLine(this.owner);
            gsmText.AppendLine(this.Battery.ToString());
            gsmText.AppendLine(this.Display.ToString());
            string result = gsmText.ToString();
            return result;
        }
    }
}