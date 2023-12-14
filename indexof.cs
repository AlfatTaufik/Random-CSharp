// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// int length = closingPosition - openingPosition - 1; // Hitung panjang teks di antara tanda kurung
// int startIndex = openingPosition + 1; // Indeks awal untuk memulai pemotongan teks

// Console.WriteLine(message.Substring(startIndex, length));

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));