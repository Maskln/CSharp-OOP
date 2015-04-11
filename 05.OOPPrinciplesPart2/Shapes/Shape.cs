namespace Shapes
{   
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double side)
        {
            this.Width = side;
            this.Height = side;
        }
        
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width must be bigger than 0!");                   
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height must be bigger than 0!");
                }
                this.height = value;
            }
        }


        //Abstracted Method CalculateSurface
        
        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("Width = {0}, Height = {1},", this.width, this.height);
        }
    }
}
