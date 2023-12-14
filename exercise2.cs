string pangram = "The quick brown fox jumps over the lazy dog";
string reversedPangram = ReversePangram(pangram);
Console.WriteLine(reversedPangram);
static string ReversePangram(string message)
{
    string[] words = message.Split(' ');
    for (var i = 0; i < words.Length; i++)
    {
        char[] letters = words[i].ToCharArray();
        Array.Reverse(letters);
        words[i] = new String(letters);
    }
    return String.Join(" ", words);
}

// string keras = "benda";
// char[] remove = keras.ToCharArray();

// // Console.WriteLine(remove);
// foreach (var item in remove) {
//     Console.WriteLine(item);
// }