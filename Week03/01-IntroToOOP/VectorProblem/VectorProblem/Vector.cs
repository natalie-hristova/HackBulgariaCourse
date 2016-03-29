using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProblem
{
    class Vector
    {
        readonly private int[] array;
        readonly private int dimensionality;

        public Vector(params int[] array)
        {
            this.array = array;
            this.dimensionality = array.Length;
        }
        public Vector(Vector v)
        {
            Vector a = new Vector(v);
        }

        public int this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }
        public int Dimensionality
        {
            get
            {
                return dimensionality;
            }

        }
        public double GetLength()
        {
            double x = 0;
            for (int i = 0; i < Dimensionality; i++)
            {
                x += Math.Pow(array[i], 2);
            }
            return Math.Sqrt(x);
        }
        public override string ToString()
        {
            StringBuilder arr = new StringBuilder();
            for (int i = 0; i < Dimensionality; i++)
            {
                arr.Append(array[i]);
            }
            return arr.ToString();
        }
        public override bool Equals(object obj)
        {
            Vector a = obj as Vector;
            if (this.array.Length == a.array.Length)
            {
                for (int i = 0; i < a.array.Length; i++)
                {
                    if (this.array[i] != a.array[i])
                        return false;
                }
                return true;
            }
            else return false;
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !v1.Equals(v2);
        }
        public override int GetHashCode()
        {

            int hash = 17;
            for (int i = 0; i < Dimensionality; i++)
            {
                hash += hash * 23 + array[i].GetHashCode();
            }
            hash = hash * 23 + array.GetHashCode();
            return hash;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            int[] tempArray = new int[v1.dimensionality];

            if (v1.dimensionality.Equals(v2.dimensionality))
            {
                for (int i = 0; i < v1.dimensionality; i++)
                {

                    tempArray[i] = (v1.array[i] + v2.array[i]);
                }
            }
            else
                throw new ArgumentException("The lengths cannot be different!!!");
            for (int i = 0; i < v2.dimensionality; i++)
            {
                Console.WriteLine(v2.array[i]);
            }
            return new Vector(tempArray);

        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            int[] tempArray = new int[v1.dimensionality];
            if (v1.Dimensionality.Equals(v2.Dimensionality))
            {
                for (int i = 0; i < v1.array.Length; i++)
                {
                    tempArray[i] = (v1.array[i] - v2.array[i]);
                }
            }
            else
                throw new ArgumentException("The lenghts cannot be different!!!");
            return new Vector(tempArray);

        }
        public static Vector operator +(Vector v1, int a)
        {
            int[] tempArray = new int[v1.dimensionality];

            for (int i = 0; i < v1.Dimensionality; i++)
            {
                tempArray[i] = v1.array[i] + a;
            }

            return new Vector(tempArray);
        }
        public static Vector operator -(Vector v1, int a)
        {
            int[] tempArray = new int[v1.dimensionality];
            for (int i = 0; i < v1.Dimensionality; i++)
            {
                tempArray[i] = v1.array[i] - a;
            }
            return new Vector(tempArray);
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            int[] tempArray = new int[v1.dimensionality];
            if (v1.Dimensionality.Equals(v2.Dimensionality))
            {
                for (int i = 0; i < v1.array.Length; i++)
                {
                    tempArray[i] = (v1.array[i] * v2.array[i]);
                }
            }
            else
                throw new ArgumentException("The lenghts cannot be different!!!");
            return new Vector(tempArray);

        }
    }
}
