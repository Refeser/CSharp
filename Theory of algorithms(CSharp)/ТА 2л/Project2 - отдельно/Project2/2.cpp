#include <iostream>
using namespace std;
void main()

{
	setlocale(LC_ALL, "Russian");
	int k;
	cout << "������� ������ ������� �� 9999" << endl;
	cin >> k;
	int a[9999];
	cout << "������� ������" << endl;
	for (int i = 0; i < k; i++)
	{
		cin >> a[i];
	}
	//////////////////////////////
	int val;
	cout << "������� �������� ��� ������: " << endl;
	cin >> val;
	int left = 0, right = k - 1, mid;
	while (left < right)
	{
		mid = ((left + right) / 2);
		if (a[mid] >= val)
			right = mid;
		else left = mid + 1;
	}
	if (val == a[left])
		cout << "������� : " << left + 1 << endl;
	else
		cout << "�� �������." << endl;
	//////////////////////////////
	system("pause");
}