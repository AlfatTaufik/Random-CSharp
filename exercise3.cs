// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// // Rubah kedalam array

// string[] orders = orderStream.Split(',');

// foreach (var order in orders.OrderBy(o => o))
// {
//     if (order.Length != 4)
//     {
//         Console.WriteLine($"{order , -6} -error");
//     }
//     // return order;
//     else
//     {
//         Console.WriteLine($"{order}");
//     }
// }

decimal duit = 2475746847.4324m;
Console.WriteLine($"{duit:C} {duit:N4} {duit:P2}");

decimal price = 24.4m;
decimal salePrice = 343.5m;

Console.WriteLine($"kamu hemat {0:C2}");

// :C untuk currency
//  :N untuk Number ngasih koma
// N4 koma angka dicetak semua
// P2 untuk persentase

string input = "padding left";
Console.WriteLine(input.PadRight(32, '-'));