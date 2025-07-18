namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 
            #region Q1
            Point[] P01 = new Point[2];
            for (int i = 0; i < P01.Length; i++)
            {
                P01[i] = new Point();
                bool Flag;
                do
                {
                    Console.Write($"Enter P01 {i + 1} X: ");
                    Flag = double.TryParse(Console.ReadLine(), out double x);
                    P01[i].X = x;
                } while (!Flag);
                do
                {
                    Console.Write($"Enter P01 {i + 1} Y: ");
                    Flag = double.TryParse(Console.ReadLine(), out double y);
                    P01[i].Y = y;
                } while (!Flag);


            }

            double distance = Math.Abs(Math.Sqrt(Math.Pow(P01[0].X - P01[1].X, 2) + Math.Pow(P01[0].Y - P01[1].Y, 2)));

            Console.WriteLine($"The distance between ({P01[0].X},{P01[0].Y}) and  ({P01[1].X},{P01[1].Y}) is {distance}");
            #endregion
            #endregion
        }

    }
}
