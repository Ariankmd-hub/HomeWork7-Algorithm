namespace HomeWork7.Task7
{
    internal class DecimalToBinary
    {
        public string ConvertToBinary(int number)
        {
            if (number == 0) return "0";

            string binary = "";
            int temp = Math.Abs(number);

            while (temp > 0)
            {
                int remainder = temp % 2;
                binary = remainder + binary;
                temp /= 2;
            }

            return number < 0 ? "-" + binary : binary;
        }
    }
}
