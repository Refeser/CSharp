#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

//интерпол€ционный поиск
int InterpolSearch(int mas[], int n)
{
	int mid, left = 0, right = 999;
	while (mas[left] <= n && mas[right] >= n)
	{
		mid = left + ((n - mas[left])*(right - left)) / (mas[right] - mas[left]);
		if (mas[mid]<n) left = mid + 1;
		else if (mas[mid] > n) right = mid - 1;
		else return mid;
	}
	if (mas[left] == n) return left;
	else return -1;
}

int main() {
	setlocale(LC_ALL, "Rus");

	srand(time(0));
	int mas[1000];

	for (int i = 0; i < 1000; i++) {
		mas[i] = rand() % 10000;
	}

	int tmp = 0;

	for (int i = 0; i<1000; i++) {
		for (int j = 999; j >= (i + 1); j--) {
			if (mas[j]<mas[j - 1]) {
				tmp = mas[j];
				mas[j] = mas[j - 1];
				mas[j - 1] = tmp;
			}
		}
	}

	int n;

	cout << "¬ведите число дл€ поиска его позиции: \t";
	cin >> n;

	if (InterpolSearch(mas, n) == -1) 
		cout << "Ёлемент не найден!" << endl;
	else cout << "ѕозици€ элемента в массиве: \t" << InterpolSearch(mas, n) << endl;

	system("pause");
	return 0;
}