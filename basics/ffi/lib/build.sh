#!/usr/bin/env bash
g++ -fPIC -O3 -DNDEBUG -shared -Wl,-soname,libhello.so -o libhello.so Hello.cpp

