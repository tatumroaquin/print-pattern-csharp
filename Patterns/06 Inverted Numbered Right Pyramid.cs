namespace Patterns;

/*
 1 2 3 4 5 6
 1 2 3 4 5
 1 2 3 4
 1 2 3
 1 2 
 1
*/

public class _06_InvertedNumberedRightPyramid {
  public static void PrintPattern(int n) {
    for (int i = n; i >= 0; i--) {
      for (int j = 0; j < i; j++) {
        Console.Write($"{j + 1} ");
      }
      Console.WriteLine();
    }
  }
}
