namespace Shapes
{   
    using System;

    public class Square : Shape
    {
       public Square(double side)
           : base(side)
           {
               
           }
              

       public override double CalculateSurface()
       {
            return (Width * Height);
       }

       public override string ToString()
       {
           return string.Format("{0} Surface = {1}", base.ToString(), this.CalculateSurface());
       }
    }
}
