#include <iostream>
using namespace std;
int Bin(int val, int k, int *a)
{
	int left = 0, right = k - 1, mid;
	while (left < right)
	{
		mid = ((left + right) / 2);
		if (a[mid] >= val)
			right = mid;
		else left = mid + 1;
	}
	if (val == a[left])
		return left;
}

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
	int b, pos;
	for (int j = 0; j < k; j++)
	{
		b = a[j];
		pos = Bin(b, k, a);
		while (pos < j)
		{
			for (int i = j - 1; i >= pos; i--)
				a[i + 1] = a[i];
			a[pos] = b;
			break;
		}
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