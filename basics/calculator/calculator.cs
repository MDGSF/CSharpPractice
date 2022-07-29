using System;

namespace CalculatorApplication {
  class NumberManipulator {
    public int FindMax(int num1, int num2) {
      int result;
      if (num1 > num2) {
        result = num1;
      } else {
        result = num2;
      }
      return result;
    }

    public int factorial(int num) {
      if (num == 1) {
        return 1;
      }
      return factorial(num - 1) * num;
    }

    public void swap(int x, int y) {
      int temp = x;
      x = y;
      y = temp;
    }

    public void swap2(ref int x, ref int y) {
      int temp = x;
      x = y;
      y = temp;
    }

    public void getValue(out int x) {
      int temp = 5;
      x = temp;
    }

    public void getValues(out int x, out int y) {
      Console.WriteLine("Please input first value:");
      x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Please input second value:");
      y = Convert.ToInt32(Console.ReadLine());
    }

    static void Main(string[] args) {
      NumberManipulator n = new NumberManipulator();

      {
        Console.WriteLine("test1");
        int a = 100;
        int b = 200;
        int ret = n.FindMax(a, b);
        Console.WriteLine("result: {0}", ret);
        Console.WriteLine("");
      }

      {
        Console.WriteLine("test2");
        Console.WriteLine("6的阶乘：{0}\n", n.factorial(6));
      }

      {
        Console.WriteLine("test3");
        int a = 100;
        int b = 200;
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        n.swap(a, b);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        Console.WriteLine();
      }

      {
        Console.WriteLine("test4");
        int a = 100;
        int b = 200;
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        n.swap2(ref a, ref b);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        Console.WriteLine();
      }

      {
        Console.WriteLine("test5");
        int a = 100;
        Console.WriteLine("a: {0}", a);
        n.getValue(out a);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine();
      }

      {
        Console.WriteLine("test6");
        int a;
        int b;
        n.getValues(out a, out b);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        Console.WriteLine();
      }
      
    }
  }
}
