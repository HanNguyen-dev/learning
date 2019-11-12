using System;

namespace Challenge.Domain.Models
{
  public class Fibonacci
  {

    private const int max = 4000000;
    public int sum = 0;

    public int Sequence(int a, int b) {
      if (b < max) {
        Console.WriteLine($"a: {a}");

        if (IsEven(a))
        {
          sum += a;
        }
        return Sequence(b, a + b);
      }
      else {
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        if (IsEven(a) && a < max)
        {
          sum += a;
        }
        return 0;
      }
    }

    public int SumOfEven()
    {
      return sum;
    }
    private bool IsEven(int a)
    {
      return a % 2 == 0;
    }
  }
}