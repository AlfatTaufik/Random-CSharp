// Inisialisasi random dengan membuat instance
Random dadu = new Random();

int roll1 = dadu.Next(1, 7);
int roll2 = dadu.Next(1, 7);
int roll3 = dadu.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Roll anda adalah {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine("Selamat anda mendapatkan bonus +2");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("Selamat anda dapat triple +6 untuk anda");
    total += 6;
}
if (total >= 15)
{
    Console.WriteLine("Yoou wins, Congratulations !");
}
 if (total < 14)
{
    Console.WriteLine("Sorry you will get better next try");
}