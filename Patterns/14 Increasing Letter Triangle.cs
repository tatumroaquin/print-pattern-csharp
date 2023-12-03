namespace Patterns;


public class _14_IncreasingLetterTriangle {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }
  public static void Attempt1(int n) {
    char c = 'A';
    for (int i = 1; i <= n; i++) {
      for (int j = 1; j <= i; j++) {
        Console.Write($"{ (char) (c + j - 1) } ");
      }
      Console.WriteLine();
    }
  }
  public static void Attempt2(int n) {
    for (int i = 0; i < n; i++) {
      for (char c = 'A'; c <= 'A'+i; c++) {
        Console.Write($"{c} ");
      }
        Console.WriteLine();
    }
  }
}
