﻿namespace Shapes
{
    public class Triangle : Shape
    {

        public Triangle(double width, double height)
            : base(width, height)
            {
                
            }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }

        public override string ToString()
        {
            return string.Format("{0} Surface = {1}", base.ToString(), this.CalculateSurface());
        }
    }
}
