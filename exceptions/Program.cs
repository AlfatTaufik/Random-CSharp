// try
// {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     int result = num1 + num2;
//     Console.WriteLine("Result: " + result);

//     string str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);

//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);

//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");
checked
{
    try
    {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Your error is {ex.Message}");
    }
}

try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Your error is {ex.Message}");
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Your error is {ex.Message}");
}


    // int num3 = 10;
    // int num4 = 0;
    // int result2 = num3 / num4;
    // Console.WriteLine("Result: " + result2);