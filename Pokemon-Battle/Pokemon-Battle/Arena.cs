namespace Pokemon_Battle;
internal static class Arena
{
    private static int _totalRounds;
    private static int _totalBattles;

    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        new Battle(trainer1, trainer2).Start();
        _totalBattles++;
        DisplayScore();
    }

    public static void IncrementRound()
    {
        _totalRounds++;
    }

    private static void DisplayScore()
    {
        Console.WriteLine($"Total Battles: {_totalBattles}, Total Rounds: {_totalRounds}");
    }
}