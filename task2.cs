/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
  int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 34, 56, 78 };
 int sayı = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 0 && numbers[i] <= 9)
    {
        sayı++;
    }
}

Console.WriteLine(sayı);
}
}
