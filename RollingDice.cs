using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    //Creating a new class called RollingDice
    internal class RollingDice
    {
        //Creating a random number generator
        Random RandomNumber = new Random();

        //Creating a method that returns the array of how many times that combination was rolled 
        //This is where the iRolls parameter from the previous class also gets "passed" in the ()
        public int[] RollDice(int iRollDiceNumber)
        {
            //creating an array that has 13 spots available
            int[] aDieCombo = new int[13];

            //Using a for loop so it can do the same thing until the number gets to the number the user input in
            for (int iCount = 0; iCount < iRollDiceNumber; iCount++)
            {
                //For each throw we will generate a random number for each dice 1 being inclusive and 7 exclusive meaning 1-6
                int iDie1 = RandomNumber.Next(1, 7);
                int iDie2 = RandomNumber.Next(1, 7);

                //Creating a variable to store the combination of that throw 
                int iTotal = iDie1 + iDie2;

                //We will add one "point" to that slot in the array that is the same number of the combination thrown
                aDieCombo[iTotal]++;
            }

            //method will return the array once it's filled with how many times each thrown happened in that slot of the array. 
            return aDieCombo;

        }
    }
}
