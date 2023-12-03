namespace Patterns;
// *    *
// **  **
// ******
// **  **
// *    *

public class _20_SymmetricButterfly {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }
  public static void Attempt1(int n) {
    int spaces = 2 * (n - 1);
    for (int i = 1; i <= 2*n-1; i++) {
      int stars = i;

      if (i > n) stars = 2*n - i;

      for (int j = 1; j <= stars; j++) {
        Console.Write('*');
      }
      for (int j = 0; j < spaces; j++) {
        Console.Write(' ');
      }
      for (int j = 1; j <= stars; j++) {
        Console.Write('*');
      }

      if (i < n)
        spaces -= 2;
      else
        spaces += 2;

      Console.WriteLine();
    }
  }
}
