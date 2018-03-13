#include <iostream>
#include<string>
using namespace std;

class Car
{
private:
	int speed;
	string mark;
	float price;
public:
	void setSpeed(int);
	int getSpeed();
	void setMark(string);
	string getMark();
	void setPrice(float);
	float getPrice();
	void Init(int, string , float);
};
void Car::setSpeed(int speedIn)
{
	speed = speedIn;
}
int Car::getSpeed()
{
	return speed;
}
void Car::setMark(string Mark)
{
	mark = Mark;
}
string Car::getMark()
{
	return mark;
}
void Car::setPrice(float pri)
{
	price = pri;
}
float Car::getPrice()
{
	return price;
}
void Car::Init(int speedIn, string Mark, float pri)
{
	speed = speedIn;
	mark = Mark;
	price = pri;
}
int main()
{
	Car myCar;
	cout << "Xe thu nhat " << endl;
	myCar.Init(1000, "C", 120.5);
	cout << "Toc do: " << myCar.getSpeed() << endl;
	cout << "Nhan hieu xe: " << myCar.getMark() << endl;
	cout << "Gia tien: " << myCar.getPrice() << endl;

	cout << "\nXe thu 2: " << endl;
	myCar.setSpeed(150);
	cout << "Toc do: " << myCar.getSpeed() << endl;
	myCar.setMark("C");
	cout << "Nhan hieu xe: " << myCar.getMark() << endl;
	myCar.setPrice(169.3);
	cout << "Gia tien: " << myCar.getPrice() << endl;
	system("pause");
	return 0;
}