#pragma once

#include <iostream>
#include <string>

using namespace std;

class Workers {
public:
	string Rabochie[15];
	virtual void Soedinenie();
	virtual void Vivod();
};

class Manager :Workers {
public:
	string Managers[5] = { "Maria", "Darina", "Alexandr", "Nina", "Vikttor" };
};

class Admin :Workers {
public:
	string Admins[3] = { "Vladimir", "Renata", "Farida" };
};

class Programmer :Workers {
public:
	string Programmers[7] = { "Vladislav", "Vladislava", "Alexandr", "Alexandra", "Alexei", "Eugene", "Piter" };
};

Workers *Work;
Manager *Man;
Admin *Adm;
Programmer *Prog; 
