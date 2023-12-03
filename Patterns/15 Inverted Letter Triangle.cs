namespace Patterns;

/**
 * A B C D E F
 * A B C D E
 * A B C D
 * A B C
 * A B
 * A
 */

public class _15_InvertedIncreasingLetterTriangle {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }

  public static void Attempt1(int n) {
    for (int i = n - 1; i >= 0; i--) {
      for (char c = 'A'; c <= 'A' + i; c++) {
        Console.Write($"{c} ");
      }
      Console.WriteLine();
    }
  }
}
