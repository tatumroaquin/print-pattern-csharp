namespace Patterns;

public class _10_HalfDiamondStar {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }

  private static void Attempt1(int n) {
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n - 1; j++) {
        Console.Write(" ");
      }
      for (int j = 0; j <= i; j++) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
    for (int i = n - 1; i > 0; i--) {
      for (int j = 0; j < n - 1; j++) {
        Console.Write(" ");
      }
      for (int j = i; j > 0; j--) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }

  private static void Attempt2(int n) {
    // Outer loop for number of rows.
    for (int i = 1; i <= 2 * n - 1; i++) {
      // stars would be equal to the row no. uptill first half
      int stars = i;

      // for the second half of the rotated triangle.
      if (i > n)
        stars = 2 * n - i;

      // for printing the stars in each row.
      for (int j = 1; j <= stars; j++) {
        Console.Write("*");
      }

      // When the stars for each row are printed, we move to the
      // next row and give a line break otherwise all stars
      // would get printed in 1 line.
      Console.WriteLine();
    }
  }
}
