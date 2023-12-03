namespace Patterns;

/**
 * A 
 * B B
 * C C C
 * D D D D
 * E E E E E
 * F F F F F F
 */

public class _16_AlphaRamp {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }
  public static void Attempt1(int n) {
    char c = 'A';
    for (int i = 1; i <= n; i++) {
      for (int j = 1; j <= i; j++) {
        Console.Write($"{(char)(c + i - 1)} ");
      }
      Console.WriteLine();
    }
  }
  public static void Attempt2(int n) {
    for (int i = 0; i < n; i++) {
      char c = (char)('A' + i);
      for (int j = 0; j <= i; j++) {
        Console.Write($"{c} ");
      }
      Console.WriteLine();
    }
  }
}
