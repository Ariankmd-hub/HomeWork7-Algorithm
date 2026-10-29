namespace HomeWork7.Task5
{
    internal class Gcd
    {
        public int Calculate(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int remainder = a % b;

                a = b;
                b = remainder;
            }

            return a;
        }

    }
}
