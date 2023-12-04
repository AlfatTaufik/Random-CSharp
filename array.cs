string[] values = { "12.3", "45", "ABC", "11", "DEF" };

var numbers = values.Where((val) => double.TryParse(val, out _));
var letter = values.Where((val) => !double.TryParse(val, out _));
// gabungin angka angka tadi
double sum = numbers.Sum(val => double.Parse(val));
// gabungin letter
string concatenadLetter = string.Join(",", letter);
string[] total = {sum.ToString()};
string[] all = {concatenadLetter};

foreach (var item in total)
{
    Console.WriteLine(item);
}
foreach (var abjad in all )
{
    Console.WriteLine(abjad);
}

decimal value = 0m;
string message;
foreach (var item in values)
{
    decimal number;
if (decimal.TryParse(item, out number))
{
    value += number;
    // Console.WriteLine
}
else
{
    message += item;
}
}
Console.WriteLine(value);
Console.WriteLine(message);