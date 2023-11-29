Random dice = new Random();

int hero = 10;
int monster = 10;

do
{
    int heroAttack = dice.Next(1,11);
    monster -= heroAttack;
    Console.WriteLine($"Monster damaged {heroAttack} and lost health, he now has {monster} health");

    if (monster < 0) continue;

    int monsterAttack = dice.Next(1, 11);
    hero -= monsterAttack;
    Console.WriteLine($"Hero damaged {monsterAttack} and lost health, he now has {hero} healtj");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");