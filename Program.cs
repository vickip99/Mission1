using Mission1;

internal class Program
{
    private static void Main()
    {   //Creating an instance of the RollingDice class 
        RollingDice rd = new RollingDice();

        //Initiating the variable iRolls to 0 so we can use it and sub the 0 for the input user number later
        int iRolls = 0;

        //Using the console to add some text about what this code is about
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");

        //Using the console to ask the user how many times they would like to roll the dice
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        //Setting the previous iRolls variable to the number that the user input from the previous line of code.
        iRolls = int.Parse(System.Console.ReadLine());

        //Adding more code and explaining the user what the * according to the number they chose to roll the dice. 
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n \n" +
            "Each '*' represents 1% of the total number of rolls. \n \n" +
            "Total number of rolls = " + iRolls + '.');

        //this is the array that got passed from the method called RollDice from the RollingDice class that shows the frequency
        //of each combination thrown. 
        int[] aDieCombo = rd.RollDice(iRolls);

        //Using a for loop to display the results. Saying that if the number in the length of the array is less than or equal to 2
        //then it will go into this for loop and and increment by one until it reaches 12
        //2Dice throws will have a minimum of 2 and a maximum of 12 combined. 
        for (int i = 2; i <= 12; i++)
        {
            //creating a percentage to display the *'s, by using the number displayed when the 2Dice were rolled and dividing that by
            //the amount of times they were rolled and multiplying that by 100 to get a percentage. 
            double PctResult = ((double)aDieCombo[i] / iRolls) * 100;

            //Displaying the results by saying that the combination of i (2-12) rolled the dice using the *'s as percentages calculated
            //from the previous line. 
            System.Console.WriteLine(i + ": " + new string('*', (int)PctResult));

        }
    }
}

