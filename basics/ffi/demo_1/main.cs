using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class HelloWorld {
  public class Demo {
    [DllImport("../lib/libhello.so", CallingConvention = CallingConvention.Cdecl)]
    static extern void print_hello();

    public void print() {
      print_hello();
    }
  }

  public static void Main(string[] args) {
    Demo d = new Demo();
    d.print();
  }
}
