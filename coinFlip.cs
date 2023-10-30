// Import Random;

Random coin = new Random();

int coins = coin.Next(1, 7);
Console.WriteLine(coins);
// Using Ternary option
Console.WriteLine($"Your coin result is {(coins % 2 == 0 ? "Heads" : "Tails")}");