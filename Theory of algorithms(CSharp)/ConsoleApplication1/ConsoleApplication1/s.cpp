#include <iostream>
using namespace std;
struct node {
	node* next;
	int    val;
};
class spisok {
private:
	node*  lst;
	size_t cnt;
public:
	spisok();
	~spisok();
	bool add(int val);
	void clear();
	void inssort();
	void bubblesort();
	void selectionsort();
	size_t size(void)  const { return cnt; }
	bool   empty(void) const { return (lst == NULL); }
	node*  begin(void) const { return lst; }
	node*  begin(void) { return lst; }
};
void spisok_print(std::ostream& _out, const spisok& lst);
spisok::spisok() :lst(NULL), cnt(0) {}
spisok::~spisok() {
	clear();
}
//Сортировка вставками//
void spisok::inssort() {
	node* a, *b, *p, *h = NULL;
	for (node* i = lst; i != NULL; ) {
		a = i;
		i = i->next;
		b = h;
		for (p = NULL; (b != NULL) && (a->val > b->val); ) {
			p = b;
			b = b->next;
		}

		if (p == NULL) {
			a->next = h;
			h = a;
		}
		else {
			a->next = b;
			p->next = a;
		}
	}
	if (h != NULL)
		lst = h;
}
//Пузырьковая сортировка//
void spisok::bubblesort() {
	node* t, *m, *a, *b;
	if (lst == NULL)
		return;
	for (bool go = true; go; ) {
		go = false;
		a = t = lst;
		b = lst->next;
		while (b != NULL) {
			if (a->val > b->val) {
				if (t == a)
					lst = b;
				else
					t->next = b;
				a->next = b->next;
				b->next = a;
				m = a, a = b, b = m;
				go = true;
			}
			t = a;
			a = a->next;
			b = b->next;
		}
	}
}
//Сортировка выбором//
void spisok::selectionsort() {
	node* a, *b;
	node* p1, *p2, *r1, *r2;
	for (p1 = r1 = lst; p1 != NULL; p1 = p1->next) {
		a = p2 = r2 = p1;
		for (b = p1->next; b != NULL; b = b->next) {
			if (b->val < p2->val) {
				r2 = a;
				p2 = b;
			}
			a = b;
		}
		if (p1 != p2) {
			if (p1 == lst)
				lst = p2;
			else
				r1->next = p2;
			b = p2->next;
			if (p1 == r2) {
				p2->next = p1;
				p1->next = b;
			}
			else {
				a = p1->next;
				r1->next = p2;
				r2->next = p1;
				p1->next = b;
				p2->next = a;
			}
			p1 = p2;
		}
		r1 = p1;
	}
}
//добавление//
bool spisok::add(int val) {
	node* p = new (std::nothrow) node();
	if (p != NULL) {
		p->val = val;
		p->next = lst;
		lst = p;
		++cnt;
	}
	return (p != NULL);
}
//удаление всех//
void spisok::clear() {
	node* t;
	while (lst != NULL) {
		t = lst;
		lst = lst->next;
		delete t;
	}
	cnt = 0;
}
//вывод//
void spisok_print(std::ostream& _out, const spisok& lst) {
	for (const node* p = lst.begin(); p != NULL; p = p->next)
		_out << p->val << ' ';
	_out << std::endl;
}

int main() {
	setlocale(LC_ALL, "Rus");
	int   n;
	spisok l1, l2, l3;
	cout << "Введите числа (конец ввода 999):" << endl;
	cin >> n;
	while (n != 999)
	{
		l1.add(n);
		l2.add(n);
		l3.add(n);
		cin >> n;
	}
	cout << "Пузырьковая сортировка" << endl;
	l1.bubblesort();
	spisok_print(std::cout, l1);
	cout << "Сортировка выбором" << endl;
	l2.selectionsort();
	spisok_print(std::cout, l2);
	cout << "Сортировка вставками" << endl;
	l3.inssort();
	spisok_print(std::cout, l3);
	return 0;
	system("pause");
}