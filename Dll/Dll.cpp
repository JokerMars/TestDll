// Dll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"


namespace Test
{
	extern "C" __declspec(dllexport) int add(int a, int b)
	{

		return a + b;
	}
}


