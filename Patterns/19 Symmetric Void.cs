namespace Patterns;

// ************
// *****  *****
// ****    ****
// ***      ***
// **        **
// *          *
// *          *
// **        **
// ***      ***
// ****    ****
// *****  *****
// ************

public class _19_SymmetricVoid {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }
  public static void Attempt1(int n) {
    int spaces = 0;
    for (int i = 0; i < n; i++) {
      for (int j = i; j < n; j++) {
        Console.Write('*');
      }
      for (int j = 0; j < spaces; j++) {
        Console.Write(' ');
      }
      for (int j = i; j < n; j++) {
        Console.Write('*');
      }
      spaces += 2;
      Console.WriteLine();
    }

    for (int i = 0; i < n; i++) {
      spaces -= 2;
      for (int j = 0; j <= i; j++) {
        Console.Write('*');
      }
      for (int j = 0; j < spaces; j++) {
        Console.Write(' ');
      }
      for (int j = 0; j <= i; j++) {
        Console.Write('*');
      }
      Console.WriteLine();
    }
  }
  public static void Attempt2(int n) {
    int spaces = 0;
    for (int i = 0; i < 2*n; i++) {
      for (int j = 2*n-i; j < n; j++) {
        Console.Write('*');
      }
      for (int j = 0; j < spaces; j++) {
        Console.Write(' ');
      }
      for (int j = 2*n-i; j < n; j++) {
        Console.Write('*');
      }
      if ( i <= n )
        spaces += 2;
      else
        spaces -= 2;
      Console.WriteLine();
    }
  }
}
