using System;
using Challenge.Domain.Models;

namespace Challenge.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Fibonacci fib = new Fibonacci();
      fib.Sequence(0, 1);
      Console.WriteLine(fib.SumOfEven());
    }
  }
}
