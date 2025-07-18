namespace Demo
{
    internal class Program
    {
        #region Video01
        //1.Classes
        //2.Struct
        //3.Enum
        //4.Interface
        #endregion
        static void Main(string[] args)
        {
            #region Video01 Struct
            //Struct is a value type stored in STACK

            //Employee
            //Id,Name,Salary

            //PointDemo
            //PointDemo P01;
            //Declare for object from type "PointDemo"
            //P01:Object
            //Allocate uninitalized 8 Bytes at STACK
            //X=>Variable=Attribute
            //Console.WriteLine(P01.X);=>using  uninitalized attribute

            //P01.X = 12;
            //P01.Y = 12;


            //P01=new PointDemo();
            //new
            //It select the constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);
            // Console.WriteLine(P01);//Namespace Demo.PointDemo
            // Console.WriteLine(P01.ToString());//Namespace Demo.PointDemo
            //P01.PrintPoint();
            //Console.WriteLine(P01.ToString());
            //Console.WriteLine(P01);

            #endregion
            #region Video02 OOP Overview
            //OOP:Object Oriented Programming
            //Is a programming paradigm
            //OOP:The paradigm used for build any business because it simulates reality

            //Class:is the BLUEPRINT of an object
            //Object: Specific instance of a class

            /*4.Pillars of OOP:
             =================
              1.Encapsulation
              2.Inheritance
              3.Polymorphism
              4.Abstraction
             
             */

            #endregion

            #region Video03  Encapsulation using Getter and Setter Methods
            //Encapsulation:Separate data(attributes) defination from  its user 
            //use setter and getter or Properties
            //Used on struct or class
            //Employee Id,Name,Salary
            //Employee E01 = new Employee(10,"Ahmed",12000);
            //Id is read only 
            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //1.End user access data itself
            //2.No data validation
            //3. No read only field



            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //To Apply Encapsulation
            //1.Make all the attributes(data) private
            //2.Access data through:
            //2.1 setter and getter methods
            //2.2 Properties
            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(-12000);
            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());
            //Console.WriteLine(E01);



            #endregion
            #region Video04  Encapsulation using properties
            //Employee E01 = new Employee();
            //E01.Id = 12;//set
            //E01.Name = "Ahmed";
            //E01.Salary = -12000;
            //E01.Address = "Cairo";
            //Console.WriteLine(E01.Id);//get
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);
            #endregion

            #region Video05 Indexer
            //indexer is a special method
            //1.name must start with this
            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 1111, 0);
            //phoneBook.AddPerson("Ali", 2222, 1);
            ////phoneBook.AddPerson("Omar", 3333, 2);
            ////Console.WriteLine(phoneBook.GetNumber("Ahmed"));
            ////phoneBook.UpdateNumber("Ahmed", 999);
            ////Console.WriteLine(phoneBook.GetNumber("Ahmed"));
            //Console.WriteLine(phoneBook["Ahmed"]);
            //phoneBook["Ahmed"] =999;
            //Console.WriteLine(phoneBook["Ahmed"]);
            //Console.WriteLine(phoneBook[2222]);

            #endregion

            #region Video06 Class and constructor chaining
            //Class:Reference type:stored in HEAP

            //Car C01;
            //Declare for reference(pointer) from type "Car" at stack
            //C01 can refer ro an object(instance) of type Car or any class inherited from car
            //C01 refer to null
            //8 Bytes will be allocated at STACK for the reference
            //0 Bytes will be allocated at HEAP

            //C01=new Car(1,"XYZ",100);
            //C01 = new Car(1, 100);
            //C01 = new Car(1);

            //new
            // 1.Allocate the number of required bytes at HEAP  for the object(16+Byte)
            // 2.initialze the allocated bytes with the default value of the datatypes
            // 3.Call user defined constructor if exist
            // 4.Assign the object to the reference
            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);
            //Console.WriteLine(C01);//name space
            #endregion

        }
    }
}
