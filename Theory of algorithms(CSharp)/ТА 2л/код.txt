#include <iostream>

//Хасанов Алмаз 4333

using namespace std;

void Input(int n, int *mas)

{
	cout << endl << "Введите массив: " << endl;
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

void LineSearch(int n, int *mas)

{

	cout << "Введите значение для поиска:" << endl;

	int value, pos = -1, i = 0;

	cin >> value;

	while ((pos == -1) && (i < n))

	{

		if (mas[i] == value)

			pos = i;

		i++;

	}

	if (pos == -1)

		cout << "Значение не найдено!";

	else

		cout << "Позиция числа : " << pos + 1;

	cout << endl;

}

int BinarSearch(int value, int n, int *mas)

{

	int left = 0, right = n - 1, midle;

	while (left < right)

	{

		midle = ((left + right) / 2);

		if (mas[midle] >= value)

			right = midle;

		else left = midle + 1;

	}

	if (value == mas[left])

		return left;

}

void SelectSort(int n, int *mas)

{

	for (int i = 0; i<n - 1; i++)

		for (int j = i; j < n; j++)

		{

			if (mas[i] > mas[j])

			{

				int a = mas[i];

				mas[i] = mas[j];

				mas[j] = a;

			}

		}

}

void BubbleSort(int n, int *mas)

{

	for (int i = 1; i < n; i++)

		for (int j = i; j >= 1; j = j - 1)

			if (mas[j - 1] > mas[j])

			{

				int a = mas[j - 1];

				mas[j - 1] = mas[j];

				mas[j] = a;

			}

}

void IncludeSort(int n, int *mas)

{

	int a, pos;

	for (int j = 0; j < n; j++)

	{

		a = mas[j];

		pos = BinarSearch(a, n, mas);

		while (pos < j)

		{

			for (int i = j - 1; i >= pos; i--)
				mas[i + 1] = mas[i];

			mas[pos] = a;

			break;

		}

	}

}

void QuickSort(int *mas, int left, int right)

{

	int i, j, m;

	i = left;

	j = right;

	m = mas[(i + j + 1) / 2];

	while (i <= j)

	{

		while (mas[i] < m)

			i++;

		while (mas[j] > m)

			j--;

		if (i <= j)

		{

			int a = mas[i];

			mas[i] = mas[j];

			mas[j] = a;

			i++;

			j--;

		}

	} 

	if (left < j)

		QuickSort(mas, left, j);

	if (i < right)

		QuickSort(mas, i, right);

}

void main()

{

	int h, *mas = new int[1], n;

	setlocale(LC_ALL, "Russian");

	do

	{

		system("cls");

		cout << "1.Ввести массив" << endl;

		cout << "2.Вывести массив" << endl;

		cout << "3.Метод линейного поиска" << endl;

		cout << "4.Метод двоичного поиска" << endl;

		cout << "5.Метод сортировки выбором" << endl;

		cout << "6.Метод сортировки пузырьком" << endl;

		cout << "7.Метод сортировки включением" << endl;

		cout << "8.Метод быстрой сортировки" << endl;

		cout << "9.Выход" << endl;

		cin >> h;

		switch (h)

		{

		case 1:

		{

			cout << "Введите количество элементов: ";

			cin >> n;

			while (n > 9999)

			{

				cout << "Введите элементы массива: ";

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

			LineSearch(n, mas);

			break;

		}

		case 4:

		{

			int value;

			cout << "Искомое значение: " << endl;

			cin >> value;

			int pos = BinarSearch(value, n, mas);

			if (value == mas[pos])

				cout << "Позиция : " << pos + 1 << endl;

			else

				cout << "Не найдено." << endl;

			break;

		}

		case 5:

		{

			Output(n, mas);

			SelectSort(n, mas);

			Output(n, mas);

			break;
		}

		case 6:

		{

			Output(n, mas);

			BubbleSort(n, mas);

			Output(n, mas);

			break;

		}

		case 7:

		{

			Output(n, mas);

			IncludeSort(n, mas);

			Output(n, mas);

			break;

		}

		case 8:

		{

			Output(n, mas);

			QuickSort(mas, 0, n - 1);

			Output(n, mas);

			break;

		}

		case 9:

		{

			break;

		}

		default:

		{

			cout << "Пункт меню выбран не правильно! Выберите подходящий пункт 1-9" << endl;

		}

		}

		system("pause");

	} while (h != 9);

}