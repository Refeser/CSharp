#include <iostream>
#include <stdlib.h>
using namespace std;
#define base 10

long stepen(long x, long y) {
	long z = pow(x, y);
	return z;
}

int length(long A)
{
	int count = 1;
	while (A != 0)
	{
		A /= base;
		++count;
	}
	return count;
};

int max(int x, int y)
{
	if (x > y)
		return x;
	return y;
};

long multiply(long a, long b)
{
	int n, a_l, b_l;
	long res, a1, a2, b1, b2, prod1, prod2, prod3;
	a_l = length(a);
	b_l = length(b);
	n = max(length(a), length(b));

	if (n == 1) return a * b;

	a1 = (a - a % (stepen(base, (a_l / 2)))) / (stepen(base, (a_l - a_l / 2))); // X = A*10^(n/2) + B; 
	a2 = a % (stepen(base, (a_l / 2)));

	b1 = (b - b % (stepen(base, (b_l / 2)))) / (stepen(base, (b_l - b_l / 2)));// Y = C*10^(n/2) + D;
	b2 = b % (stepen(base, (b_l / 2)));

	prod1 = multiply(a1, b1);                   // A*C
	prod2 = multiply(a2, b2);                   // B*D
	prod3 = multiply(a1 + a2, b1 + b2);         // (A+B)*(C+D) 

	res = prod1 * (stepen(10, n)) + (prod3 - prod1 - prod2) * pow(base, (n / 2)) + prod2;  // X*Y = A*C*10^n + ((A+B)*(C+D) - A*C -B*D )^(n/2) + B*D;

	return res;
}

int main()
{
	long X, Y, res1, res2;
	cout << "enter X" << endl;
	cin >> X;
	cout << "enter Y" << endl;
	cin >> Y;
	res1 = X*Y;
	cout << res1 << "\n";
	res2 = multiply(X, Y);
	cout << res2;
	cin.get();
	return 0;
}