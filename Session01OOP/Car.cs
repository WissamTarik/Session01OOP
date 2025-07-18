using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {


        #region Video06 Class and Constructor chaining

        private int id;
        private string model;
        private int speed;

        //CLR will generate paramerterless constructor by default
        //This constructor  do nothing
        //public Car()
        //{

        //}Do nothing

        //Internal chaining of constructor
        public Car(int id, string modal, int speed) : this(id, speed)
        {

            Model = modal;

        }
        public Car(int id, int speed) : this(id)
        {
            Speed = speed;

        }
        public Car(int id)
        {
            Id = id;
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //public int Id
        //{
        //    set { id = value; }
        //    get { return id; } }
        //}

        public override string ToString()
        {
            return $"Id: {id} , model: {model} ,speed: {speed} ";
        }
        #endregion
    }
}