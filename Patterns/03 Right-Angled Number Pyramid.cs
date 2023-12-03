namespace Patterns;

/**
 1
 1 2
 1 2 3
 1 2 3 4
 1 2 3 4 5
*/

public class _03_RightAngledNumberPyramid {
  public static void PrintPattern(int n) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < i; j++) {
        Console.Write($"{i+1} ");
      }
      Console.WriteLine();
    }
  }
}
