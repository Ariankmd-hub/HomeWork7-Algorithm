namespace HomeWork7.Task1
{
    internal class DigitCounter
    {
        public int Counter(int number) 
        {
            if (number == 0)
                return 1;
            int counter = 0;
            while (number > 0) 
            {
                number = number / 10;
                counter++;
            
            }
          
            return counter;
        }
    }
}
