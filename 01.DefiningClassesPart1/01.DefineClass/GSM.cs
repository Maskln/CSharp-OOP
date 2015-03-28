namespace _01.DefineClass
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        //Fields
        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private uint price;
        private string owner;
        private List<Call> callHistory = new List<Call>();


        public static GSM Iphone4S = new GSM("4S", "Apple", 500, "Pesho",
                                             new Battery("Toshiba", 350, 24, BatteryType.LiIon),
                                             new Display(3.5, 16000000));


        //Constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, uint price, string owner)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, uint price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }

        //Properties
        public string Model
        {
            get
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("No model");
                }
                return this.model;
            }

        }

        public string Manufacturer
        {
            get
            {
                if (this.manufacturer == string.Empty)
                {
                    throw new ArgumentNullException("No manufacturer");
                }
                return this.manufacturer;
            }
        }

        public uint Price
        {
            get
            {
                if (this.price == 0)
                {
                    throw new ArgumentNullException("No price");
                }
                return this.price;
            }
        }

        public string Owner
        {
            get
            {
                if (this.owner == string.Empty)
                {
                    throw new ArgumentNullException("No owner");
                }
                return this.owner;
            }
        }

        public Display Display
        {
            get
            {
                if (this.display == null)
                {
                    throw new ArgumentNullException("No display information");
                }
                return this.display;
            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery == null)
                {
                    throw new ArgumentNullException("No battery information");
                }
                return this.battery;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                if (Iphone4S == null)
                {
                    throw new ArgumentNullException("Empty!");
                }
                return Iphone4S;
            }
        }

        //Methods
        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendLine("Phone Information");
            information.AppendLine("-----------------");
            information.AppendLine("Model: " + this.model);
            information.AppendLine("Manufacturer:" + this.manufacturer);
            information.AppendLine("Price: " + this.price);
            information.AppendLine("Owner: " + this.owner);
            information.AppendLine("Battery model: " + this.battery.Model);
            information.AppendLine("Display- Size: " + this.display.SizeOfDisplay);

            return information.ToString();
        }


        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public float CalculateCallPrice(float pricePerMinute)
        {
            float price = 0;

            uint totalTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalTime += callHistory[i].DurationCall;
            }

            price = pricePerMinute * totalTime;

            return price;
        }

    }
}
