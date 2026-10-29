using HomeWork7;
using HomeWork7.Task1;
using HomeWork7.Task2;
using HomeWork7.Task3;
using HomeWork7.Task4;
using HomeWork7.Task5;
using HomeWork7.Task6;
using HomeWork7.Task7;
using HomeWork7.Task8;
using HomeWork7.Task9;

while (true) 
{
    Console.WriteLine("Choose a task between [1-10], [0] to exit:  ");

    bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
    if (!choiceValidation)
    {
        Console.WriteLine("Invalid input try again!"); continue;
    }
    else if(choice == 1) 
    {
        int number = ConsoleHelper.ReadInt("Please enter a number for the digit counter:");
        DigitCounter digitCounter = new DigitCounter();
        Console.WriteLine($"The number of digits is: {digitCounter.Counter(number)}");
        Console.WriteLine("___________________________________________________________________");
    }
    
    else if (choice == 2)
    {
        int number = ConsoleHelper.ReadInt("Please enter a number to check if it's prime: ");
        PrimeChecking primeChecking = new PrimeChecking();

        if (primeChecking.IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number!");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number!");
        }
        Console.WriteLine("___________________________________________________________________");
    }
    else if(choice == 3) 
    {
        int number = ConsoleHelper.ReadInt("Please enter a number for digit sum: ");
        SumCalculator sumCalculator = new SumCalculator();
        int sum = sumCalculator.SumDigit(number);
        Console.WriteLine($"The sum of digits is: {sum}");
        Console.WriteLine("___________________________________________________________________");

    }
    else if (choice == 4) 
    {
        int number = ConsoleHelper.ReadInt("Please enter a number to check if it's a palindrome: ");
        Palindrome palindrome = new Palindrome();
        if (palindrome.IsPalindrome(number)) 
        {
            Console.WriteLine("This number is a palindrome.");
        }
        else 
        {
            Console.WriteLine("This number is not a palindrome.");
        }
        Console.WriteLine("___________________________________________________________________");
    }
    else if (choice == 5) 
    {
        int number1 = ConsoleHelper.ReadInt("Please enter the first number for the GCD: ");
        int number2 = ConsoleHelper.ReadInt("Please enter the second number for the GCD: ");
        Gcd gcd = new Gcd();
        int result = gcd.Calculate(number1, number2);
        Console.WriteLine($"The GCD for these two numbers is: {result}");
        Console.WriteLine("___________________________________________________________________");
    }
    else if(choice == 6) 
    {
        int number = ConsoleHelper.ReadInt("Please enter a number and I will reverse it: ");
        ReverseNumber reverseNumber = new ReverseNumber();
        int result = reverseNumber.Reverse(number);
        Console.WriteLine($"The reversed number is: {result}");
        Console.WriteLine("___________________________________________________________________");


    }
    else if(choice == 7) 
    {
        int number = ConsoleHelper.ReadInt("Please enter a number to convert to binary: ");
        DecimalToBinary decimalToBinary = new DecimalToBinary();
        string result = decimalToBinary.ConvertToBinary(number);
        Console.WriteLine($"The binary representation is: {result}");
        Console.WriteLine("___________________________________________________________________");
    }
    else if( choice == 8) 
    {
        string str = ConsoleHelper.ReadString("Please enter a string to generate its permutations:");
        Permutation permutation = new Permutation();
        List<string> result = permutation.GeneratePermutations(str);
        Console.WriteLine($"Permutations: {string.Join(", ", result)}");
        Console.WriteLine("___________________________________________________________________");

    }
    else if (choice == 9) 
    {
        int[] array = ConsoleHelper.ReadIntArray();
        DuplicateChecker duplicateChecker = new DuplicateChecker();
        if (duplicateChecker.HasDuplicate(array)) 
        {
            Console.WriteLine("It has duplicates.");
        }
        else 
        {
            Console.WriteLine("It does not have any duplicates.");
        }
        Console.WriteLine("___________________________________________________________________");

    }
    else if (choice == 10)
    {
        Console.WriteLine("I would rate my algorithm skills a 4 out of 5.");
        Console.WriteLine("___________________________________________________________________");
    }
    else if (choice == 0)
    {
        Console.WriteLine("Goodbye :)");
        break;
    }
    else 
    {
        Console.WriteLine("Invalid input, please enter a number between 0 and 10!");
    }



}