#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");
	//Хасанов Алмаз 4333
	int x, y, k;
	cout << "X = "; cin >> x;
	cout << "Y = "; cin >> y;

	if (x >= 0)
		if (y >= 0)
			k = 1;
		else
			k = 4;
	else
		if (y >= 0)
			k = 2;
		else
			k = 3;

	if (x == 0)
		if (y == 0)
			cout << "Это начало координат" << endl;
		else
			cout << k << " четверть";
	else
		cout << k << " четверть" << endl;

	system("pause");
	return 0;
}