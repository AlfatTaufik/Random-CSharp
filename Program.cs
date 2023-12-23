void SayHello()
{
    Console.WriteLine("Halo semuanya!");
}

SayHello();

void DisplayRandomNum()
{
    int[] arrRandom = new int[5];
    for (int i = 0; i < 4; i++) 
    { 
    Random number = new Random();
    int randomNum = number.Next(1, 18);
        arrRandom[i] = randomNum;
    }
    for (int c = 0; c < arrRandom.Length; c++)
    {
        Console.WriteLine(arrRandom[c]);
    }
}

DisplayRandomNum();