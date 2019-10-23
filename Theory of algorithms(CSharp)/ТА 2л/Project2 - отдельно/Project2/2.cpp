#include <iostream>
using namespace std;
void main()

{
	setlocale(LC_ALL, "Russian");
	int k;
	cout << "Введите размер массива до 9999" << endl;
	cin >> k;
	int a[9999];
	cout << "Введите массив" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> a[i];
	}
	//////////////////////////////
	int val;
	cout << "Введите значение для поиска: " << endl;
	cin >> val;
	int left = 0, right = k - 1, mid;
	while (left < right)
	{
		mid = ((left + right) / 2);
		if (a[mid] >= val)
			right = mid;
		else left = mid + 1;
	}
	if (val == a[left])
		cout << "Позиция : " << left + 1 << endl;
	else
		cout << "Не найдено." << endl;
	//////////////////////////////
	system("pause");
}