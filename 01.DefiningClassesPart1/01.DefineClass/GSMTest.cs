using System;


namespace _01.DefineClass
{
    public class GSMTest
    {

        private GSM[] Devices = {   new GSM("Galaxy S3", "Samsung", 100, "Kiro",
                                            new Battery("Toshiba New", 500, 75, BatteryType.LiIon), 
                                            new Display(4.8, 16000000)),
                                   
                                    new GSM("One", "HTC", 150, "Miro",
                                            new Battery("Varta", 500, 75, BatteryType.NiMh), 
                                            new Display(5.1, 16000000)),

                                     new GSM("Lumia", "Nokia", 140, "Piro",
                                            new Battery("Varta New", 400, 50, BatteryType.Nicd), 
                                            new Display(4.1, 16000000))
                                };

        public void PrintInfo()
        {
            Console.WriteLine(Devices[0].ToString());
            Console.WriteLine(Devices[1].ToString());
            Console.WriteLine(Devices[2].ToString());
            Console.WriteLine(GSM.Iphone4S);
            
        }

        
    }
}
