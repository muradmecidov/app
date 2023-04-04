/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
 int num = 99;
        int bölenler = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                bölenler++;
            }
        }

        Console.WriteLine(bölenler);
      
}
}
