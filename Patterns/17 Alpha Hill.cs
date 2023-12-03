namespace Patterns;

/**
 *      A     
 *     ABA    
 *    ABCBA   
 *   ABCDCBA  
 *  ABCDEDCBA 
 * ABCDEFEDCBA
 */

public class _17_AlphaHill {
  public static void PrintPattern(int n) {
    Attempt1(n);
  }
  public static void Attempt1(int n) {
    for (int i = 1; i <= n; i++) {
      for (int j = n-i; j > 0; j--) {
        Console.Write(' ');
      }
      char c = 'A';
      int step = 1;
      for (int j = 1; j <= 2*i-1; j++) {
        Console.Write($"{c}");
        c = (char)(c + step);

        // (2*i-1)/2 = i - 1
        // if you're half-way through the line
        if (j == i - 1) step = -1;
      }
      Console.WriteLine();
    }
  }
}
