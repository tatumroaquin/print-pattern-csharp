namespace Patterns;

public class _08_InvertedStarPyramid {
  public static void PrintPattern(int n) {
    for (int i = n; i >= 0; i--) {
      for (int j = 0; j < n - i; j++) {
        Console.Write(" ");
      }
      int starCount = 2 * i;
      for (int j = starCount; j >= 0; j--) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}
