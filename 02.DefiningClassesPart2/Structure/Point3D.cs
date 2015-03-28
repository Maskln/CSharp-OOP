using System;

namespace Structure
{
    public struct Point3D  //Problem 1, 2
    {
        private int x;
        private int y;
        private int z;


        private static readonly Point3D o = new Point3D (0, 0, 0);

        public Point3D(int x, int y, int z) 
            : this()    
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
         
        
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, z = {2}", X, Y, Z);
        }
    }
}
