using System;

namespace TypeConversionApplication {
  class ExplicitConversion {
    static void test1() {
      double d = 5673.74;
      int i;

      i = (int)d;
      Console.WriteLine(i);
    }

    static void test2() {
      int i = 75;
      float f = 53.005f;
      double d = 2345.7652;
      bool b = true;

      Console.WriteLine(i.ToString());
      Console.WriteLine(f.ToString());
      Console.WriteLine(d.ToString());
      Console.WriteLine(b.ToString());
    }

    static void Main(string[] args) {
      test2();
    }
  }
}
