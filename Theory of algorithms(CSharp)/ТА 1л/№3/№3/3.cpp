#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Rus");
	//Хасанов Алмаз 4333
	double a, b, n;
	cout << "a = "; cin >> a;
	cout << "b = "; cin >> b;
	cout << "n = "; cin >> n;

	double s = a + b;
	double f = n++;
	s /= f;
	f = a;
	f += s;

	while (f < b)
	{
		int y = -0.5 * f;
		y = pow(M_E, y);
		y = 1 - y;
		y *= 5;
		double c = pow(2, M_PI);
		c *= f;
		c = cos(c);
		y *= c;
		cout << "Y = " << y << endl;
		f += s;
	}

	system("pause");
	return 0;
}