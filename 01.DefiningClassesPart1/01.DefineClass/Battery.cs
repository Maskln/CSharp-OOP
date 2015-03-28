namespace _01.DefineClass
{
    using System;


    public class Battery
    {
        //Fields
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType batteryType;
        
        //Constructors
        public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        //Properties
        public string Model
        {
            get
            {
                if (this.model == string.Empty)
                {
                    throw new ArgumentNullException("No model of Battery");
                }
                return this.model;
            }
        }

        public uint HoursIdle
        {
            get
            {
                if (this.hoursIdle == 0)
                {
                    throw new ArgumentNullException("No hours Idle");
                }
                return this.hoursIdle;
            }
        }

        public uint HoursTalk
        {
            get
            {
                if (this.hoursTalk == 0)
                {
                    throw new ArgumentNullException("No hours Talk");
                }
                return this.hoursTalk;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                if (this.batteryType == null)
                {
                    throw new ArgumentNullException("No Battery type selected");
                }
                return this.batteryType;
            }
        }

    }
}
