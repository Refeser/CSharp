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
	cout << "Введите значение для поиска:" << endl;
	int val, pos = -1, i = 0;
	cin >> val;
	while ((pos == -1) && (i < k))
	{
		if (a[i] == val)
			pos = i;
		i++;
	}
	if (pos == -1)
		cout << "Значение не найдено!";
	else
		cout << "Позиция числа : " << pos + 1;
	cout << endl;
	//////////////////////////////
		system("pause");
}