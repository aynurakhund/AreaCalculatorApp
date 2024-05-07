using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Classes
{
    public class Rectangle
    {
		private int side1;

		public int Side1
		{
			get { return side1; }
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException("wrong");
				}
				else
				{
					side1 = value;
				}
			}
		}

        private int side2;

        public int Side2
        {
            get { return side2; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("wrong");
                }
                else
                {
                    side2 = value;
                }
            }
        }
        

        public int CalcAreaOfRectangle()
        {
            return Side1 * Side2;
        }

    }
}
