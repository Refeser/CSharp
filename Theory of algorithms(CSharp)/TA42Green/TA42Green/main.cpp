#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "Rus");

	int mas[10];

	cout << "Введите массив из 10 чисел: " << endl;
	for (int i = 0; i < 10; i++) {
		cin >> mas[i];
	}

	int sumplus = 0, summinus = 0;
	int kolplus = 0, kolminus = 0, kolnull = 0;

	for (int i = 0; i < 10; i++) {
		if (mas[i] == 0) {
			kolnull++;
		}
		if (mas[i] > 0) {
			sumplus += mas[i];
			kolplus++;
		}
		else if (mas[i] < 0) {
			summinus += mas[i];
			kolminus++;
		}
	}

	cout << "Кол-во нулей: \t" << kolnull << endl;

	cout << "Кол-во положительных: \t" << kolplus << endl;
	cout << "Сумма положительных: \t" << sumplus << endl;

	cout << "Кол-во отрицательных: \t" << kolminus << endl;
	cout << "Сумма отрицательных: \t" << summinus << endl;

	system("pause");
	return 0;
}