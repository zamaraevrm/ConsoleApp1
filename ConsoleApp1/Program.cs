using System;



namespace ConsoleApp1
{
    class Program
    {
        delegate int Operation(int x, int y);

        delegate int UpTwo(int number);

        delegate void End(int num);

        delegate End Result(Operation op, UpTwo ut);
        static void Main(string[] args)
        {
           
            Operation del = Add;
            //int result = del(4, 5); 
            //Console.WriteLine(result);

            UpTwo upTwo = (int number) => number * 2;
            //result = upTwo(result);
            //Console.WriteLine(result);

            Result re = (Operation op, UpTwo ut) =>
            {
                End end1 = (int num) => { Console.WriteLine($"result {op(num,ut(num))}"); };
                return end1;
            };

            End end = re(del, upTwo);
            end(3);
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
