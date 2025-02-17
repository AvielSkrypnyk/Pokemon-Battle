class Arena
{
    private static int _totalRounds = 0;
    private static int _totalBattles = 0;

    public void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        new Battle(trainer1, trainer2).Start();
        _totalBattles++;
        DisplayScore();
    }

    public static void IncrementRound()
    {
        _totalRounds++;
    }

    public static void DisplayScore()
    {
        Console.WriteLine($"Total Battles: {_totalBattles}, Total Rounds: {_totalRounds}");
    }
}