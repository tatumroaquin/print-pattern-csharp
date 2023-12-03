namespace Patterns;

/**
 1
 2 2
 3 3 3
 4 4 4 4
 5 5 5 5 5
 */

public class _04_RightAngledNumberPyramidII {
  public static void PrintPattern(int n) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < i; j++) {
        Console.Write($"{i} ");
      }
      Console.WriteLine();
    }
  }
}
