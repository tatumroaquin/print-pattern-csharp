namespace Patterns;

/**
 * 1
 * 2  3
 * 4  5  6
 * 7  8  9  10
 * 11  12  13  14  15
 * 16  17  18  19  20  21
 */

public class _013_IncreasingNumberTriangle {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }
  private static void Attempt1(int n) {
    int count = 1;
    for (int i = 1; i <= n; i++) {
      for (int j = 1; j <= i; j++) {
        if (count > 9)
          Console.Write($" {count}");
        else
          Console.Write($"  {count}");
        count++;
      } 
      Console.WriteLine();
    }
  }
}

