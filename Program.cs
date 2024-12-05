namespace ConsoleApp1
{
    public class Program
    {
        public static int Cb(int n)
        {
            string b = Convert.ToString(n, 2);
            int c = 0;
            foreach (char d in b)
            {
                if (d == '1') c++;
            }
            return c;
        }

        public static int P(int n)
        {
            if (n < 10) return 0;
            int c = 0;
            while (n >= 10)
            {
                int p = 1;
                while (n > 0)
                {
                    p *= n % 10;
                    n /= 10;
                }
                n = p;
                c++;
            }
            return c;
        }

        public static int Dr(int n)
        {
            if (n < 10) return n;
            int s = 0;
            while (n > 0)
            {
                s += n % 10;
                n /= 10;
            }
            return Dr(s);
        }

        public static void Main()
        {
            Console.WriteLine(Cb(4));
            Console.WriteLine(Cb(10));
            Console.WriteLine(P(39));
            Console.WriteLine(P(999));
            Console.WriteLine(Dr(16));
            Console.WriteLine(Dr(942));
        }
    }
}
