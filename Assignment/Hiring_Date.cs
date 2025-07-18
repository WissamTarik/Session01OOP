using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Hiring_Date
    {
		private int day;
		private int month;
		private int year;

		public int Year
		{
			get { return year; }
			set {
			 if(value >=2000 && value <= 2025)
				{
					year = value;
				}
			}


		}




		public int Day
		{
			get { return day; }
			set {
				
				if(value>0 && value<30)
				day = value; 
			}
		}
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12) { month = value; }
            }
        }


		public Hiring_Date(int day, int month, int year)
		{
			Day = day;
			Month = month;
			Year = year;
		}
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
