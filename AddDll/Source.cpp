#include<iostream>
#include<stdio.h>

using namespace std;

extern "C" __declspec(dllexport) int add(int a, int b)
{
	return a + b;
}
