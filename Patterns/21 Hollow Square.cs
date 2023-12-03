namespace Patterns;

// ******
// *    *
// *    *
// *    *
// *    *
// ******

public class _21_HollowSquare {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }
  public static void Attempt1(int n) {
    int spaces = 0;

    for (int i = 0; i < n; i++) {

      if (i == 0 || i == n-1) {
        for (int j = 0; j < n; j++) {
          Console.Write('*');
        }
      } else {
        spaces = n-2;
        Console.Write('*');
        for (int j = 0; j < spaces; j++) {
          Console.Write(' ');
        }
        Console.Write('*');
      }

      Console.WriteLine();
    }
  }
  public static void Attempt2(int n) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++) {
        if (i == 0 || j == 0 || i == n-1 || j == n-1) {
          Console.Write('*');
        } else {
          Console.Write(' ');
        }
      }
      Console.WriteLine();
    }
  }
}
