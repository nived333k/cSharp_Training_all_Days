using System;



namespace DotNet_Day10
{
    delegate int NumberChanger(int n);



    class Delegate2Testing
    {
        static int num = 10;



        public static int AddNum(int p)
        {
            num += p;
            return num;
        }



        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }



        public static int getNum()
        {
            return num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a multicast delegate and add the methods to it
            NumberChanger nc = new NumberChanger(Delegate2Testing.AddNum);
            nc += new NumberChanger(Delegate2Testing.MultiplyNum);



            // Invoke the multicast delegate
            nc(25);
            Console.WriteLine("Current Value of Num: {0}", Delegate2Testing.getNum());



            // Note: When invoking a multicast delegate, all the attached methods are called in the order they were added.
            Console.Read();
        }
    }
}