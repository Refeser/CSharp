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
	for (int i = 0; i<k - 1; i++)
		for (int j = i; j < k; j++)
		{
			if (a[i] > a[j])
			{
				int b = a[i];
				a[i] = a[j];
				a[j] = b;
			}
		}
	cout << "��������������� ������:" << endl;
	for (int i = 0; i < k; i++)
	{
		cout << a[i] << " ";
	}
	cout << endl;
	//////////////////////////////
	system("pause");
}