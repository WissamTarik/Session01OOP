using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Video03
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region Video03 Apply encapsulation by using setter and getter method
        //Apply encapsulation by using setter and getter method

        //Setter
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //Getter
        //public int GetId()
        //{
        //    return id;
        //}

        ////Setter of Name
        //public void SetName(string name)
        //{
        //    if (name.Length >= 3 && name.Length <= 20)
        //        this.name = name;
        //}
        ////Getter of Name
        //public string GetName()
        //{
        //    return name;
        //}

        ////Setter of salary
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //        this.salary = salary;
        //}

        ////Getter of salary
        //public double GetSalary()
        //{
        //    return salary;
        //}
        //public Employee(int id, string name, double salary)
        //{
        //    //SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}
        //public override string ToString()
        //{
        //    return $"Id={GetId()},Name={GetName()},Salary={GetSalary()}";
        //}
        #endregion

        #region Video04 Apply encapsulation by using properties[Recommended]
        //Apply encapsulation using properties
        //1.Full property
        //2.Automatic property
        //3.Special property[indexer]


        //1.Full property
        //property its structure from the property itself+private attribute 
        public int Id
        {
            //setter
            //getter
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    name = value;
            }
            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if (value > 0)
                    salary = value;
            }
            get
            {
                return salary;
            }
        }

        public override string ToString()
        {
            return $"Id: {id} , Name: {name} , Salary: {salary}"
            ;
        }

        //2.Automatic property
        //U don't need to create the attribute private(But used when we don't need logic inside
        // get and set)
        public string Address { set; get; }
        #endregion
    }
}