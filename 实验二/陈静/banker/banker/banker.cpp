// banker.cpp: ����Ŀ�ļ���

#include "stdafx.h"
#include"iostream"
#include"string"
using namespace std;

int main()
{
	int i,m, request[3];
	int max[5][3] = { { 7, 5, 3 }, { 3, 2, 2 }, { 9, 0, 2 }, { 2, 2, 2 }, { 4, 3, 3 } };
	int	allocation[5][3] = { { 0, 1, 0 }, { 2, 0, 0 }, { 3, 0, 2 }, { 2, 1, 1 }, { 0, 0, 2 } };
	int	need[5][3] = { { 7, 4, 3 }, { 1, 2, 2 }, { 6, 0, 0 }, { 0, 1, 1 }, { 4, 3, 1 } };
	int	available[3] = { 3, 3, 2 };
	int work[3];
	int t, finish[5] = { 0, 0, 0, 0, 0 };
	cout << "����������Ľ������У������ִ��棬���磺4����P4����";
	cin >> i;
	cout << "����������P" << i << "����request��Դ����������" << endl;
	for (int j = 0; j<3; j++)
	{
		cin >> request[j];
	}
    //�ж������Ƿ�ȫ
	for (t = 0; t<3; t++)
	{
		if ((request[t]>need[i][t]) || (request[t]>available[t])){ cout << "���󲻳ɹ���" << endl; getchar(); getchar(); return 0; }
	}
	for (t = 0; t<3; t++)
	{
		allocation[i][t] = allocation[i][t] + request[t];
		need[i][t] = need[i][t] - request[t];
		available[t] = available[t] - request[t];
	}
	work[0] = available[0];
	work[1] = available[1];
	work[2] = available[2];
		for (int h = 0; h <5; h++)
		{
			
				for (int j = 0; j < 5; j++)
				{
					for (int l = 0; l<3; l++)
					{
						if ((need[j][l]>work[l])||(finish[j]==1)){ m = 1; break; }
						else m = 0;
					}
					if (m == 0)
					{
						finish[j] = 1;
						for (int n = 0; n < 3; n++)
						{
							work[n] = work[n] + allocation[j][n];
						}
					}
				}
			
		}
		for (int h = 0; h < 5; h++)
		{
			if (finish[h] == 0)
			{
				cout << "���䲻�ɹ���" << endl; getchar(); getchar(); return 0;
			}
		}
		if ((work[0] == 10) &&( work[1] == 5) &&( work[2] == 7))
		{

			cout << "�������ɹ���" << endl;
		}
		else{ cout << "���䲻�ɹ���" << endl; }
		getchar();
		getchar();
	return 0;
}
