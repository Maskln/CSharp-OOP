namespace Shapes
{
    public class Rectangle : Shape
    {
       public Rectangle(double widht, double height)
           : base(widht, height)
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
