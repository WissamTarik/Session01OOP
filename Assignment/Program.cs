namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 
            #region Q1
            //Point[] P01 = new Point[2];
            //for (int i = 0; i < P01.Length; i++)
            //{
            //    P01[i] = new Point();
            //    bool Flag;
            //    do
            //    {
            //        Console.Write($"Enter P01 {i + 1} X: ");
            //        Flag = double.TryParse(Console.ReadLine(), out double x);
            //        P01[i].X = x;
            //    } while (!Flag);
            //    do
            //    {
            //        Console.Write($"Enter P01 {i + 1} Y: ");
            //        Flag = double.TryParse(Console.ReadLine(), out double y);
            //        P01[i].Y = y;
            //    } while (!Flag);


            //}

            //double distance = Math.Abs(Math.Sqrt(Math.Pow(P01[0].X - P01[1].X, 2) + Math.Pow(P01[0].Y - P01[1].Y, 2)));

            //Console.WriteLine($"The distance between ({P01[0].X},{P01[0].Y}) and  ({P01[1].X},{P01[1].Y}) is {distance}");
            #endregion

            #region Q2
            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                bool Flag;
                int age;
               
                    Console.Write($"Enter person {i+1} name: ");
                    persons[i].Name = Console.ReadLine();
                do
                {
                    Console.Write($"Enter person {i + 1} age: ");
                    Flag = int.TryParse(Console.ReadLine(), out age);
                } while (!Flag);
                persons[i].Age = age;
 
            }
            int max = persons[0].Age,index=0;
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > max)
                {
                    index = i;
                    max=persons[i].Age;
                }  
            }
            Console.Clear();
            Console.WriteLine($"The oldest person is {persons[index].Name} with  age {persons[index].Age}");
            #endregion
            #endregion
        }

    }
}
