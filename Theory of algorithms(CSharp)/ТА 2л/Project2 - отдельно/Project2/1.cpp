#include <iostream>
using namespace std;
void main()

{
	setlocale(LC_ALL, "Russian");
	int k;
	cout << "������� ������ ������� �� 9999" << endl;
	cin >> k;
	int a[9999];
	cout << "������� ������" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> a[i];
	}
	//////////////////////////////
	cout << "������� �������� ��� ������:" << endl;
	int val, pos = -1, i = 0;
	cin >> val;
	while ((pos == -1) && (i < k))
	{
		if (a[i] == val)
			pos = i;
		i++;
	}
	if (pos == -1)
		cout << "�������� �� �������!";
	else
		cout << "������� ����� : " << pos + 1;
	cout << endl;
	//////////////////////////////
		system("pause");
}