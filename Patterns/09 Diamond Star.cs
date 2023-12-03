namespace Patterns;

public class _09_DiamondStar {
  public static void PrintPattern (int n) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n - i - 1; j++) {
        Console.Write(" ");
      }
      int starCount = 2 * i + 1;
      for (int j = 0; j < starCount; j++) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
    for (int i = n; i >= 0; i--) {
      for (int j = 0; j < n - i; j++) {
        Console.Write(" ");
      }
      int starCount = 2 * i - 1;
      for (int j = 0; j < starCount; j++) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}
