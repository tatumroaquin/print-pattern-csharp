namespace Patterns;

public class _11_BinaryNumberTriangle {
  public static void PrintPattern(int n) {
    Attempt2(n);
  }

  private static void Attempt1(int n) {
    for (int i = 1; i <= n; i++) {
      for (int j = 1; j <= i; j++) {
        if (i % 2 == 1)
          Console.Write(j % 2);
        else
          Console.Write((j + 1) % 2);
      }
      Console.WriteLine();
    }
  }

  private static void Attempt2(int n) {
    // First row starts by printing a single 1.
    int start = 1;

    // Outer loop for the no. of rows
    for (int i = 0; i < n; i++) {
      // if the row index is even then 1 is printed first
      // in that row.
      if (i % 2 == 0)
        start = 1;
      // if odd, then the first 0 will be printed in that row.
      else
        start = 0;

      // We alternatively print 1's and 0's in each row by using
      // the inner for loop.
      for (int j = 0; j <= i; j++) {
        Console.Write(start);
        start = 1 - start;
      }

      // When numbers for each iteration are printed, we move to the
      // next row and give a line break otherwise all numbers
      // would get printed in 1 line.
      Console.WriteLine();
    }
  }
}
