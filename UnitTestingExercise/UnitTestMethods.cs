using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        //DONE: Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        //DONE: Create a Subtract method that passes 2 integers
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        //DONE: Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        //DONE: Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }



        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string GetWelcome()
        {
            return "Welcome!";
        }


        public string YouLookSoCool()
        {
            return "You're Cool!";
        }



    }
}
