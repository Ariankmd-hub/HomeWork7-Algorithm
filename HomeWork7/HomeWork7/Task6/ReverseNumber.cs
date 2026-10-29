namespace HomeWork7.Task6
{
    internal class ReverseNumber
    {
        public int Reverse(int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return reversed;
        }
    }
}
