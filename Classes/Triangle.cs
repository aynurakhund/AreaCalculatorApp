

namespace AreaCalculator.Classes
{
    public class Triangle
    {
		private int side1;

		public int Side1
		{
			get { return side1; }
			set 
			{
				if (value <= 0)
				{
					throw new ArgumentException("The side of Triangle can not be zero or negative.");
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
                    throw new ArgumentException("The side of Triangle can not be zero or negative.");
                }
                else
                {
                    side2 = value;
                }
            }
        }

        private int side3;

        public int Side3
        {
            get { return side3; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of Triangle can not be zero or negative.");
                }
                else
                {
                    side3 = value;
                }
            }
        }

        public bool IsExist()
        {
            if((Math.Abs(Side1-Side2)<Side3 && Side3<Side1+Side2) &&(Math.Abs(Side2-Side3)<Side1 && Side1<Side2+Side3)&&(Math.Abs(Side1-Side3)<Side2 && Side2 < Side1 + Side3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalcPerimetr()
        {
            return Side1 + Side2 + Side3;
        }

        public double CalcAreaOfTriangle()
        {
            if (IsExist())
            {
                double halfOfPerimetr = CalcPerimetr() / 2;
                return Math.Sqrt(halfOfPerimetr*(halfOfPerimetr-Side1)*(halfOfPerimetr-Side2)*(halfOfPerimetr-Side3));
            }
            else
            {
                throw new ArgumentException("This Triangle does not exist");
            }
        }

    }
}
