namespace HomeWork7.Task3
{
    internal class SumCalculator
    {
        public int SumDigit(int number)
        {
            number = Math.Abs(number);

            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

    }
}
