

int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0;
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;
string userAnswer;
int roll = 1;

Console.Clear();

PlayGame(1);
PlayGame(2);

void PlayGame(int player)
{
    Console.WriteLine();
    Console.WriteLine($"Player? {player}");
    Console.WriteLine("======== ");

    fixed1 = fixed2 = fixed3 = fixed4 = fixed5 = false;
    for (int i = 1; i <= 3 && !(fixed1 && fixed2 && fixed3 && fixed4 && fixed5); i++)
    {
        RollDice();
        SortDice();
        PrintDice(i);
        if (i < 3) { FixDice(); }
    }
}

/*
RollDice();
PrintDice();
FixDice();

RollDice();
PrintDice();
FixDice();

RollDice();
PrintDice();
*/


void RollDice()
{
    if (!fixed1) { dice1 = Random.Shared.Next(1, 7); }
    if (!fixed2) { dice2 = Random.Shared.Next(1, 7); }
    if (!fixed3) { dice3 = Random.Shared.Next(1, 7); }
    if (!fixed4) { dice4 = Random.Shared.Next(1, 7); }
    if (!fixed5) { dice5 = Random.Shared.Next(1, 7); }
}

void PrintDice(int round)
{
    RollDice();
    //Console.WriteLine($"Dice roll #{roll} (out of 3): {dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
    roll++;
}

void FixDice()
{
    fixed1 = fixed2 = fixed3 = fixed4 = fixed5 = false;
    do
    {
        Console.Write("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice): ");
        userAnswer = Console.ReadLine()!;

        //userAnswer2 = Console.ReadKey().KeyChar;


        switch (userAnswer)
        {
            case "1": fixed1 = !fixed1; break;
            case "2": fixed2 = !fixed2; break;
            case "3": fixed3 = !fixed3; break;
            case "4": fixed4 = !fixed4; break;
            case "5": fixed5 = !fixed5; break;
            case "r": break;
        }

        Console.Write("Fixed:  ");
        if (fixed1) { Console.Write("1 "); }
        if (fixed2) { Console.Write("2 "); }
        if (fixed3 == true) { Console.Write("3 "); }
        if (fixed4 == true) { Console.Write("4 "); }
        if (fixed5 == true) { Console.Write("5 "); }
        Console.WriteLine("  ");


    } while (userAnswer != "r");
}

void SortDice()
{
    bool sorted = false;
    while (!sorted)
    {
        sorted = true;
        if (dice1 > dice2)
        {
            int temp = dice1;
            dice1 = dice2;
            dice2 = temp;
            sorted = false;
        }
        if (dice2 > dice3)
        {
            int temp = dice2;
            dice2 = dice3;
            dice3 = temp;
            sorted = false;
        }
        if (dice3 > dice4)
        {
            int temp = dice3;
            dice3 = dice4;
            dice4 = temp;
            sorted = false;
        }
        if (dice4 > dice5)
        {
            int temp = dice4;
            dice4 = dice5;
            dice5 = temp;
            sorted = false;
        }
    }
    Console.WriteLine();
    System.Console.WriteLine($"Dice roll #{roll} (out of 3): {dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
}

//ChatGPT  Chat.OpenAI
