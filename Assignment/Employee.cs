using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    enum Previlage
    {
        Guest,
        Developer,
        Scretary,
        DBA,
        Security_officer = Guest | Developer | Scretary | DBA
    }
    internal class Employee
    {
        int id;
        string name;
        Previlage security_Level;
        decimal salary;
        Hiring_Date hiring_Date;
        string gender;

      
        public Employee(int id,string name,decimal salary,int hiringDay,int hiringMonth, int hiringYear, string gender,Previlage securityLevel){

            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
            Security_Level = securityLevel;
            hiring_Date = new Hiring_Date(hiringDay, hiringMonth, hiringYear);


        }
        //public void SetId(int id)
        //{
        //    this.id=id;
        //}

        //public int GetId()
        //{
        //    return id;
        //}


        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

   

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary(decimal salary)
        //{
        //    if (salary > 0)
        //    {
        //        this.salary = salary;
        //    }
        //}
        //public decimal GetSalary()
        //{
        //    return salary;
        //}

        //public void SetGender(string gender)
        //{
        //    if (gender.ToLower() == "m" || gender.ToLower() == "male" || gender.ToLower() == "f" || gender.ToLower() == "female")
        //    {
        //        this.gender = gender;
        //    }
        //    else
        //    {
        //        this.gender = "N/A";
        //    }
        //}
       
        //public string GetGender()
        //{
        //    return gender;
        //}

        //public void SetSecurity_Level(string security)
        //{
        //    if(Enum.TryParse(typeof (Previlage),security,true,out object result))
        //    {
        //        this.security_Level = (string)result;
        //    }

        //}
        // public string GetSecurity_Level()
        //{
        //    return security_Level
        //}


        public int Id
        {
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
                name = value;
            }
            get
            {
                return name;    
            }
        }
       
        public decimal Salary
        {
            set
            {
                salary = value > 0 ?value: 0;
            }
            get
            {
                return salary;
            }
        }
        public string Gender
        {
            set
            {
                if (value.ToLower() == "m" || value.ToLower() == "male" || value.ToLower() == "f" || value.ToLower() == "female")
                {
                    gender = value;
                }
                else
                {
                    gender = "N/A";
                }
            }

            get
            {
                return gender;
            }
        }

        public Previlage Security_Level
        {
            set

            { 
              
                    security_Level = value;
                
                   
            }

            get
            {
                return security_Level;
            }
        }

        public override string ToString()
        {
            string security ;
            if (security_Level == Previlage.Security_officer)
            {
                security = "Guest, Developer, DBA, Scretary";
            }
            else
            {
                security = security_Level.ToString();
            }
            return $"Id is: {id} Name is :{name} \nGender is :{gender}\nsecurity level is: " +
                $"{security}\nSalary is: " +
                $"{string.Format( "{0:N2} EGP",salary)} \nHiring date={hiring_Date.ToString()}";
        }
    }
}
