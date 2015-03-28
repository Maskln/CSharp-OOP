using System;
using System.Text;

namespace Structure
{
    public class Matrix<T> where T : IConvertible
    {
        private T[,] innerMatrix;

        public int Rows { get; set; }
        public int Cols { get; set; }
       
        // Problem 9
       
        public T this[int x, int y]
        {
            get
            {
                return innerMatrix[x, y];
            }

            set
            {
                innerMatrix[x, y] = value;
            }
        }

        public Matrix() { }

        public Matrix(int rows, int cols)
            : this()
        {
            innerMatrix = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

       
        // Problem 10
        
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] + (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] - (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1 != null && m2 != null && m1.Cols == m2.Cols && m1.Rows == m2.Rows)
            {
                Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        result[x, y] = (dynamic)m1[x, y] * (dynamic)m2[x, y];

                return result;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool operator true(Matrix<T> m1)
        {
            if (m1 != null)
            {
                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        if (m1[x, y] != (dynamic)0)
                        {
                            return true;
                        }

                return false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool operator false(Matrix<T> m1)
        {
            if (m1 != null)
            {
                for (int x = 0; x < m1.Rows; x++)
                    for (int y = 0; y < m1.Cols; y++)
                        if (m1[x, y] == (dynamic)0)
                        {
                            return true;
                        }

                return false;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            
            for (int x = 0; x < this.Rows; x++)
            {
                for (int y = 0; y < this.Cols; y++)
                {
                    str.Append(this.innerMatrix[x, y] + " ");
                }
                str.Append("\n");
            }
            
            return str.ToString();
        }
    }
}
