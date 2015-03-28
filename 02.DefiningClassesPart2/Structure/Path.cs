using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Structure
{
    public class Path
    {
        private List<Point3D> points;

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint (Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint (Point3D point)
        {
            this.points.Remove(point);
        }
        
        public void Clear()
        {
            points.Clear();
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            
            foreach (Point3D point in points)
            {
                result.Append(string.Format("Point3d: {0} {1} {2}\n", point.X, point.Y, point.Z));
            }

            return result.ToString();
        }

        public void StoreInFile(string fileName)
        {
            StreamWriter writer;

            using (writer = new StreamWriter(fileName, false))
            {
                foreach (Point3D point in points)
                {
                    writer.WriteLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            StreamReader reader;

            using (reader = new StreamReader(fileName, false))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] values = line.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                    points.Add(new Point3D(values[0], values[1], values[2]));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
