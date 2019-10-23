#include <iostream>
using namespace std;
void main()

{
	setlocale(LC_ALL, "Russian");
	int k;
	cout << "¬ведите размер массива до 9999" << endl;
	cin >> k;
	int a[9999];
	cout << "¬ведите массив" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> a[i];
	}
	//////////////////////////////
	for (int i = 1; i < k; i++)
		for (int j = i; j >= 1; j = j - 1)
			if (a[j - 1] > a[j])
			{
				int b = a[j - 1];
				a[j - 1] = a[j];
				a[j] = b;
			}
	cout << "ќтсортированный массив:" << endl;
	for (int i = 0; i < k; i++)
	{
		cout << a[i] << " ";
	}
	cout << endl;
	//////////////////////////////
	system("pause");
}