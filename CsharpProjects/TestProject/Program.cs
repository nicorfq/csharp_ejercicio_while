int monsterHP = 10;
int heroHP    = 10;

Random random = new Random();
int monsterAttack;
int heroAttack;

do
{
  heroAttack = random.Next(1,11);
  monsterHP -= heroAttack;
  Console.WriteLine($"Monster was damaged and lost {heroAttack} and now has {monsterHP} health.");

  monsterAttack = random.Next(1,11);
  heroHP -= monsterAttack;
  Console.WriteLine($"Hero was damaged and lost {monsterAttack} and now has {heroHP} health.");

} while (monsterHP > 0 && heroHP > 0);

if (heroHP <= 0)
{
  Console.WriteLine("Monster wins!");
}
else if (monsterHP <= 0)
{
  Console.WriteLine("Hero wins!");
}
