#include "Header.h"

void Workers::Soedinenie() {
	int j = 0, k = 0;
	for (int i = 0; i < 5; i++)
		Work->Rabochie[i] += Man->Managers[i];
	for (int i = 5; i < 8; i++) {
		Work->Rabochie[i] += Adm->Admins[j];
		j++;
	}
	for (int i = 8; i < 15; i++) {
		Work->Rabochie[i] += Prog->Programmers[k];
		k++;
	}
}

void Workers::Vivod() {
	cout << "Состав работников: " << endl;
	cout << "  Менеджеры: " << endl;
	for (int i = 0; i < 5; i++)
		cout << "\t" << Rabochie[i] << endl;
	cout << "  Администраторы: " << endl;
	for (int i = 5; i < 8; i++)
		cout << "\t" << Rabochie[i] << endl;
	cout << "  Программисты: " << endl;
	for (int i = 8; i < 15; i++)
		cout << "\t" << Rabochie[i] << endl;
}

int main() {
	setlocale(LC_ALL, "Rus");
	Work = new Workers();
	Man = new Manager();
	Adm = new Admin();
	Prog = new Programmer();
	Work->Soedinenie();
	Work->Vivod();
	system("pause");
	return 0;
}