#include<iostream>
#include <time.h>

using namespace std;

int main() {
	setlocale(LC_ALL, "Rus");

	clock_t start = clock();

	int a, b, c;

	cout << "Ведите числа: " << endl;

	cin >> a; cin >> b; cin >> c;

	cout << "Ответ: \t" << a*b*c << endl;

	clock_t end = clock();

	double seconds = (double)(end - start) / CLOCKS_PER_SEC;

	cout << "Сложность по времени: " << seconds << " секунд." << endl;

	system("pause");
	return 0;
}