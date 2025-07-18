using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person
    {
        #region Part01 Q2
        string name;
        int age;

        public string Name
        {
            set
            {
                if (value.Length > 0)
                    name = value;
            }
            get { return name; }
        }

        public int Age
        {
            set
            {
                if (value > 0 && value < 100)
                    age = value;
            }
            get { return age; } 
            #endregion
        }
    }
}
