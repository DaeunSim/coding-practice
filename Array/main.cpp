#include <cstdio>
#include <cstdlib>

template <typename T>
class Array
{
private:
	T* arr; //start address of array
	int size;
	int capacity; //max size of array
public:
	void Add(const T& data) 
	{
		arr[size++] = data;
	}

	int Size()const
	{
		return size;
	}

	const T& At(int idx)const
	{
		return arr[idx];
	}

	void Remove(int idx)
	{
		for (int i = idx; i < size - 1; i++)
			arr[i] = arr[i + 1];
		--size;
	}

	void Print()
	{
		for (int i = 0; i < size; i++)
			printf("%g\n", arr[i]);
	}

	Array(int cap) //constructor
	{
		size = 0;
		capacity = cap;
		arr = new T[cap];
	}

	~Array() //destructor
	{
		delete[] arr;
	}
};

int main()
{
	Array<double> arr(100);

	arr.Add(10);
	arr.Add(1.23);
	arr.Add(14.44);

	arr.Remove(1);
	arr.Print();

	system("pause");
}
