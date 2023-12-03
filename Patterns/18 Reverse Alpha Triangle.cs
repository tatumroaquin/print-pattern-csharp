namespace Patterns;

/**
 * F
 * E F
 * D E F
 * C D E F
 * B C D E F
 * A B C D E F
 */

public class _18_ReverseAlphaTriangle {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }
  public static void Attempt1(int n) {
    for (int i = 1; i <= n; i++) {
      char c = (char)('A' + (n-i));
      for (int j = 1; j <= i; j++) {
        Console.Write($"{c} ");
        c = (char)(c + 1);
      }
      Console.WriteLine();
    }
  }
}
