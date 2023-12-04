string value = "1642";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Your result is good {80 + result}");
}
else
{
    Console.WriteLine("You have entered a bad number!");
}