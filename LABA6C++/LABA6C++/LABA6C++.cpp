// Lab6.cpp: определ€ет точку входа дл€ консольного приложени€.
//

#include "stdafx.h"

#include <iostream>
#include <string.h>

class parent
{
public:
	char* name = "√руппа2";
	int count;
	char* get_name();

};

class descendant : public parent
{
	bool gender[10] = { f,t,Е };
	int men_count();
	int women_count();
};

int main()
{
	return 0;
}

