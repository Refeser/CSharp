#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "Rus");

	int mas[10];

	cout << "������� ������ �� 10 �����: " << endl;
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

	cout << "���-�� �����: \t" << kolnull << endl;

	cout << "���-�� �������������: \t" << kolplus << endl;
	cout << "����� �������������: \t" << sumplus << endl;

	cout << "���-�� �������������: \t" << kolminus << endl;
	cout << "����� �������������: \t" << summinus << endl;

	system("pause");
	return 0;
}