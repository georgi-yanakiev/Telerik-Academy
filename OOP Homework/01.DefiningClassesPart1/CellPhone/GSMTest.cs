// GSM test class

using System;

namespace CellPhone
{
    public class GSMTest
    {
        static void Main()
        {
            // GSMTest
            GSM[] phones = new GSM[3];

            Display testDisplay = new Display(640, 480);
            Battery testBattery = new Battery(BatteryType.NiMH, 48, 10);

            phones[0] = new GSM("BlackBerry", "Research In Motion", 300, "Tony Montana", testBattery, testDisplay);
            
            phones[1] = new GSM("Samsung", "Samsung Corporation", 269, "Jeason Brad Lewis", testBattery, testDisplay);

            phones[2] = new GSM("Nokia", "Nokia corp", 399, "Murdjo Dimitrov", testBattery, testDisplay);

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }

            Console.WriteLine(GSM.IPhone.Model);
            Console.WriteLine(GSM.IPhone.Manufacturer);
            Console.WriteLine(phones[0].Battery.BatteryModel);

            Console.WriteLine("Call History Test");

            GSM myPhone = new GSM("Nokia", "Nokia Corp", 1, "Kiro", testBattery, testDisplay);

            myPhone.AddCall(DateTime.Now, "0897010203", 236);
            myPhone.AddCall(DateTime.Now, "0899123456", 120);
            myPhone.AddCall(DateTime.Now, "0888895432", 60);

            myPhone.DisplayCallHistory();

            Console.WriteLine(myPhone.CalcPrice(0.37));

            myPhone.RemoveCallByDuration(100);

            myPhone.DisplayCallHistory();
            Console.WriteLine(myPhone.CalcPrice(0.37));

            myPhone.ClearHistory();
            myPhone.DisplayCallHistory();
        }
    }
}