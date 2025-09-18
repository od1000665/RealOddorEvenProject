/* Odd or Even Program
Created by: Owen Douglas
Will determine if the number inputted is odd or even
*/

//Ask the user for a #
Console.WriteLine("Input a number");
int x = Convert.ToInt32(Console.ReadLine());
int y = x % 2;
//Evaluate if the number is even or odd
if (y == 0)
{
    //Report the number is even
    Console.WriteLine(x + " is even");
}
//Report the number is odd
else
{
    Console.WriteLine(x + " is odd");
}
//Done