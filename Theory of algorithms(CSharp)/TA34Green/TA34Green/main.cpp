#include <iostream>

using namespace std;

void Uravnenie(int &a, int &b, double &x) {
	
	double c = -b;

	x = c / a;

}

int main() {
	setlocale(LC_ALL, "Rus");

	int a, b;
	double x;

	int &aRef = a, &bRef = b;

	double &xRef = x;

	cout << "������� a:" << endl;
	cin >> aRef;

	cout << "������� b:" << endl;
	cin >> bRef;

	Uravnenie(aRef, bRef, xRef);

	cout << aRef << "x + " << b << " = 0" << endl;

	cout << "�����: " << x << endl;

	system("pause");
	return 0;
}