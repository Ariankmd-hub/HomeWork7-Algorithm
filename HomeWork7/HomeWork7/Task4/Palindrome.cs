namespace HomeWork7.Task4
{
    internal class Palindrome
    {
        public bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;

            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;

                reversed = reversed * 10 + digit;

                number /= 10;
            }

            return original == reversed;
        }
    }
}

