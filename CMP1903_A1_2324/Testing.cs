using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing// testing class declared
    {
<<<<<<< HEAD
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        //
=======
        public void Test()// testing method called Test called in the main program
        {
            Game game = new Game();// creates a Game object simply called game
            var values = game.RunGame();// as the RunGame returns as a a tuple, this lines saves the tuple to a local variable
            Console.WriteLine(values.Item4);// prints the sum of the numbers
            Debug.Assert(values.Item4 < 19 && values.Item4 > 2, "The sum is incorrect");// error handling using debug.assert, checks the sum and the die are possible given that it is generating random numbers between 1-6
            Debug.Assert(values.Item1 < 7 && values.Item1 > 0, "A die roll is invalid");
            Debug.Assert(values.Item2 < 7 && values.Item2 > 0, "A die roll is invalid");
            Debug.Assert(values.Item3 < 7 && values.Item3 > 0, "A die roll is invalid");
        }
>>>>>>> Developmental
    }
}
