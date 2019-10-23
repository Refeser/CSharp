#include <iostream>
using namespace std;
void QuickSort(int *a, int left, int right)
{
	int i, j, n;
	i = left;
	j = right;
	n = a[(i + j + 1) / 2];
	while (i <= j)
	{
		while (a[i] < n)
			i++;
		while (a[j] > n)
			j--;
		if (i <= j)
		{
			int b = a[i];
			a[i] = a[j];
			a[j] = b;
			i++;
			j--;
		}
	}
	if (left < j)
		QuickSort(a, left, j);
	if (i < right)
		QuickSort(a, i, right);
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
	QuickSort(a, 0, k - 1);
	cout << "ќтсортированный массив:" << endl;
	for (int i = 0; i < k; i++)
	{
		cout << a[i] << " ";
	}
	cout << endl;
	//////////////////////////////
	system("pause");
}