int input = 0;

do
{
    Console.WriteLine("Masukan Angka antara 5 - 10");
    string inputString = Console.ReadLine();
    if (!int.TryParse(inputString, out input))
    {
        Console.WriteLine("Anda tidak memasukan bilangan bulat");
    } else if (input < 5 || input > 10)
    {
        Console.WriteLine("Anda diluar jangkauan");
    }
} while (input < 5 || input > 10);

Console.WriteLine($"Input anda, {input} berhasil");