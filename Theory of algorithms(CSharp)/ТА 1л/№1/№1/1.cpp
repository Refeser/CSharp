#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");
	//Хасанов Алмаз 4333
	double Y, gam, c, b, x, z, r, f;

	cout << "Gamma = "; cin >> gam;
	cout << "c = "; cin >> c;
	cout << "b = "; cin >> b;
	cout << "x = "; cin >> x;
	cout << "z = "; cin >> z;
	cout << "r = "; cin >> r;
	cout << "f = "; cin >> f;

	double a = b*b;
	a += c;
	a = log(a);
	double d = sin(x);
	a /= d;
	d = -(gam) + f;
	d = pow(M_E, d);
	a += d;
	d = pow(r, b);
	a += d;
	d = z + r;
	d = sqrt(d);
	Y = a + d;
	cout << "Результат Y = " << Y <<endl;

	system("pause");
	return 0;
}