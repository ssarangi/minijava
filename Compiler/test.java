class MainClass
{
    public static void main(String[] a)
	{
		int a = 10;
		int b = 5;
		int c = a * b;
    }
}

class Vehicle
{
	int DoorCount;
}

class Car extends Vehicle
{
	public int SetDoorCount(int count)
	{
		DoorCount = count;
		return DoorCount;
	}
}

class test
{
	Car c;

	public int t1(int count)
	{
		int t;
		c = new Car();
		c.DoorCount = count;
        System.out.println(52);
		return c.DoorCount;
	}
}

