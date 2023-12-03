namespace Patterns;

/*
      *     
     ***    
    *****   
   *******  
  ********* 
 ***********
*/

public class _07_StarPyramid {
  public static void PrintPattern(int n) {
    for (int i = 0; i < n; i++) {

      for (int j = 0; j < n - i; j++) {
        Console.Write(" ");
      }

      int starCount = i * 2 + 1;
      for (int j = 0; j < starCount; j++) {
        Console.Write($"*");
      }
      Console.WriteLine();
    }
  }
}
