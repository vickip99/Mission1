using Mission1;

internal class ProgramBase
{
    private static void Main(int[] aDieCombo)
    {
        RollingDice rd = new RollingDice();

        int iRolls = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        iRolls = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n \n" +
            "Each '*' represents 1% of the total number of rolls. \n \n" +
            "Total number of rolls = " + iRolls + '.');


        rd.RollDice(iRolls);

        for (int i = 2; i <= aDieCombo.Length; i++)
        {
            double PctResult = (aDieCombo[i] / (double)iRolls) * 100;

            System.Console.WriteLine(i + ": " + new string('*', (int)PctResult));


        }
    }
}