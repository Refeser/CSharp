#include <iostream>
#include <vector>
#include <list>
const int MAX_VALUE = 2000; // �������� ������� [0, MAX_VALUE]
const int BUCKETS = 10;     // ���������� ��������

using namespace std;
//������� ����� 4333
void Input(int n, int *mas)

{
	cout << endl << "������� ������: " << endl;
	for (int i = 0; i < n; i++)
		cin >> mas[i];
}

void Output(int n, int *mas)

{

	cout << endl;

	for (int i = 0; i < n; i++)

		cout << mas[i] << " ";

	cout << endl;

}

void ShellSort(int n, int *mas)
{
	int d = n / 2;

	while (d != 0) {
		for (int i = d; i < n; ++i) {
			int tmp = mas[i];
			int j;

			for (j = i - d; j >= 0 && mas[j] > tmp; j -= d)
				mas[j + d] = mas[j];

			mas[j + d] = tmp;
		}
		d /= 2;
	}
}

void iswap(int &n1, int &n2)
{
	int temp = n1;
	n1 = n2;
	n2 = temp;
}

void HeapSort(int n, int *mas)
{

	int sh = 0;
	bool b = false;
	for (;;)
	{
		b = false;
		for (int i = 0; i < n; i++)
		{
			if (i * 2 + 2 + sh < n)
			{
				if ((mas[i + sh] > mas[i * 2 + 1 + sh]) || (mas[i + sh] > mas[i * 2 + 2 + sh]))
				{
					if (mas[i * 2 + 1 + sh] <  mas[i * 2 + 2 + sh])
					{
						iswap(mas[i + sh], mas[i * 2 + 1 + sh]);
						b = true;
					}
					else if (mas[i * 2 + 2 + sh] < mas[i * 2 + 1 + sh])
					{
						iswap(mas[i + sh], mas[i * 2 + 2 + sh]);
						b = true;
					}
				}
				if (mas[i * 2 + 2 + sh] < mas[i * 2 + 1 + sh])
				{
					iswap(mas[i * 2 + 1 + sh], mas[i * 2 + 2 + sh]);
					b = true;
				}
			}
			else if (i * 2 + 1 + sh < n)
			{
				if (mas[i + sh] > mas[i * 2 + 1 + sh])
				{
					iswap(mas[i + sh], mas[i * 2 + 1 + sh]);
					b = true;
				}
			}
		}
		if (!b) sh++;
		if (sh + 2 == n) break;
	}
}

int main()
{
	int h, *mas = new int[1], n;
	setlocale(LC_ALL, "Russian");
	do
	{
		system("cls");
		cout << "1.������ ������" << endl;
		cout << "2.������� ������" << endl;
		cout << "3.����� ���������� ����" << endl;
		cout << "4.������������� ����������" << endl;
		cout << "5.�����" << endl;
		cin >> h;
		switch (h)
		{
		case 1:
		{
			cout << "������� ���������� ���������: ";
			cin >> n;
			while (n > 9999)
			{
				cout << "������� �������� �������: ";
				cin >> n;
			}
			mas = new int[n];
			Input(n, mas);
			break;
		}

		case 2:

		{
			Output(n, mas);
			break;
		}

		case 3:

		{
			Output(n, mas);
			ShellSort(n, mas);
			Output(n, mas);
			break;
		}

		case 4:

		{
			Output(n, mas);
			HeapSort(n, mas);
			Output(n, mas);
			break;

		}

		case 5:

		{
			break;
		}
		default:

		{

			cout << "����� ���� ������ �� ���������! �������� ���������� ����� 1-5" << endl;

		}

		}

		system("pause");

	} while (h != 5);
}