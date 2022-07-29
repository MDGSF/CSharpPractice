using System;

namespace NullableApplication {
  class NullableAtShow {
    static void Main(string[] args) {
      int? num1 = null;
      int? num2 = 45;
      double? num3 = new double?();
      double? num4 = 3.14157;

      bool? boolval = new bool?();

      Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 
          num1, num2, num3, num4, boolval);

      int num5 = num1 ?? 5555; // 如果num1为空，就返回5555
      Console.WriteLine("num5: {0}", num5);
      int num6 = num2 ?? 6666; // 如果num2不为空，就返回num2
      Console.WriteLine("num6: {0}", num6);
    }
  }
}
