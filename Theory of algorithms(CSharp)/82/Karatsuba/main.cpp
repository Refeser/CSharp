#include<iostream>
#include <time.h>

using namespace std;

int main() {
	setlocale(LC_ALL, "Rus");

	clock_t start = clock();

	int a, b, c;

	cout << "������ �����: " << endl;

	cin >> a; cin >> b; cin >> c;

	cout << "�����: \t" << a*b*c << endl;

	clock_t end = clock();

	double seconds = (double)(end - start) / CLOCKS_PER_SEC;

	cout << "��������� �� �������: " << seconds << " ������." << endl;

	system("pause");
	return 0;
}