using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class HelloWorld {
  public class Demo {
    [DllImport("../lib/libhello.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void print_hello();

    [DllImport("../lib/libhello.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern int add_one(int n);

    [DllImport("../lib/libhello.so", CallingConvention = CallingConvention.Cdecl)]
    public static extern void sort(int[] nums, int n);

    public void print() {
      print_hello();
    }
  }

  public static void Main(string[] args) {
    // 直接调用函数
    Demo d = new Demo();
    d.print();
    Demo.print_hello();

    // 传递数字，返回数字
    int ret = Demo.add_one(123);
    Console.WriteLine("ret = {0}", ret);

    // 传递数组，在动态库里面修改数组内容
    int[] nums = new int[10]{ 9, 8, 1, 2, 3, 6, 0, 4, 5, 7 };
    for (int i = 0; i < 10; i++) {
      Console.Write("{0} ", nums[i]);
    }
    Console.WriteLine();
    Demo.sort(nums, 10);
    for (int i = 0; i < 10; i++) {
      Console.Write("{0} ", nums[i]);
    }
    Console.WriteLine();
  }
}
