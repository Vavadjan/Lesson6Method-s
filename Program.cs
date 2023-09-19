namespace Lesson6Method_s
{
    internal class Program
    {
        //<----------Методы (функции) можно писать тут.

        static int f(int x)
        {
            int result = x * 5 + 9;
            return result;
        }
        
        static int sum(int x, int y)
        {
            return x + y;
        }

        static int rnd(int r)
        {
            Random rnd = new Random();
            return rnd.Next();
            
        }





        static void Main(string[] args)
        {
            int x = 10;
            int res = f(x);
            Console.WriteLine(res);

            
            Console.WriteLine(sum(5, 3));

            int r = 0;
            Console.WriteLine(rnd(r));

             

        }
    }
}