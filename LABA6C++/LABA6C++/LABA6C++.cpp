// Lab6.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"

#include <iostream>
#include <string.h>

class parent
{
public:
	char* name = "������2";
	int count;
	char* get_name();

};

class descendant : public parent
{
	bool gender[10] = { f,t,� };
	int men_count();
	int women_count();
};

int main()
{
	return 0;
}

