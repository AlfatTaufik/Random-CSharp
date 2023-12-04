// signal integral
Console.WriteLine("Signed integral data types : ");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue} ");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MinValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");
// Console.WriteLine($"")

// unsigned integral
Console.WriteLine("UnSigned integral data types : ");

Console.WriteLine($"sbyte    : {sbyte.MinValue} to {sbyte.MaxValue} ");
Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}");
// Console.WriteLine($"")

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// reference value datatype
int[] newData;
newData = new int[3];