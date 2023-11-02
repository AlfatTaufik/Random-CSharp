// Random numbers = new Random();
// int number = numbers.Next(1, 101);

for(int number = 1; number <=100; number++) {
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine($"{number} - FizzBuzz");
    }

    else if(number % 3 == 0)
    {
        Console.WriteLine($"{number} - Fizz");    
    }
    else if (number % 5 == 0) {
        Console.WriteLine($"{number} - Buzz");
    }
    else
    {
    Console.WriteLine(number);
    }
}
