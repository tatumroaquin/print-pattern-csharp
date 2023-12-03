namespace Patterns;
/*
N = 5
1        1
12      21
123    321
1234  4321
1234554321
*/

public class _12_NumberCrown {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }
  private static void Attempt1(int n) {
    int spaces = 2 * n - 2;
    for (int i = 1; i <= n; i++) {
      for (int j = 1; j <= i; j++) {
        Console.Write(j);
      }
      for (int j = 0; j < spaces; j++) {
        Console.Write(" ");
      }
      for (int j = i; j > 0; j--) {
        Console.Write(j);
      }
      spaces -= 2;
      Console.WriteLine();
    }
  }
}
