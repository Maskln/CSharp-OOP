namespace _01.DefineClass
{
    using System;


    public class Display
    {
        //Fields
        private double sizeOfDisplay;
        private uint numberOfColors;
    

        //Constructors
        public Display(double sizeOfDisplay, uint numberOfColors)
        {
            this.sizeOfDisplay = sizeOfDisplay;
            this.numberOfColors = numberOfColors;
        }

       
        //Properties
        public double SizeOfDisplay
        {
            get
            {
                if (this.sizeOfDisplay == 0)
                {
                    throw new ArgumentNullException("No size of display!");
                }
                return this.sizeOfDisplay;
            }
        }

        public uint NumberOfColors
        {
            get
            {
                if (this.numberOfColors == 0)
                {
                    throw new ArgumentNullException("No numbers of colors");
                }
                return this.numberOfColors;
            }
        }
    }
}
