#include <iostream>
#include "Hello.h"

void print_hello() {
  std::cout << "Hello C# ffi!" << std::endl;
}

int add_one(int n) {
  return n + 1;
}

void sort(int* nums, int n) {
  for (int i = 0; i < n; i++) {
    for (int j = n - 1; j > i; j--) {
      if (nums[j-1] > nums[j]) {
        int temp = nums[j-1];
        nums[j-1] = nums[j];
        nums[j] = temp;
      }
    }
  }
}
