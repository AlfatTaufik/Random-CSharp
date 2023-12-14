string nameOfCrush = "Stefanie XII RPL 2";
char[] letterOfCrush = nameOfCrush.ToCharArray();

// foreach (var letter in letterOfCrush)
// {
//     Console.WriteLine($"{letter}");
// }
Array.Reverse(letterOfCrush);
// string reverseName = new string(letterOfCrush);
string reverseName = String.Join('/', letterOfCrush);

string[] items = reverseName.Split('/');
foreach (string item in items)
{
    Console.WriteLine(item);
}