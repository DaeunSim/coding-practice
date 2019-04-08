#include <cstdio>
#include <cstdlib>

class Stack
{
private:
	int* stack;
	int top;
	int capacity;
public:
	//copy constructor(복사 생성자)
	Stack(const Stack& arg)
	{
		stack = new int[capacity = arg.capacity];
		top = arg.top;
		for (int i = 0; i < top; i++)
			stack[i] = arg.stack[i];
	}

	//copy assignment operator(복사 대입 연산자)
	const Stack operator=(const Stack& arg)
	{
		stack = new int[capacity = arg.capacity];
		top = arg.top;
		for (int i = 0; i < top; i++)
			stack[i] = arg.stack[i];
		return *this;
	}
	
	//constructor
	Stack(int cap) 
	{
		capacity = cap;
		stack = new int[capacity]; //dynamic memory allocation
		top = 0;
	}

	void Push(int data)
	{
		stack[top++] = data;
	}

	int Pop()
	{
		return stack[--top];
	}

	~Stack() 
	{
		delete[] stack;
	}
};

void main() 
{
	Stack st(1000);
	
	st.Push(100);
	st.Push(200);
	st.Push(300); 

	Stack st2 = st;

	printf("%d\n", st2.Pop());
	printf("%d\n", st2.Pop());
	printf("%d\n", st2.Pop());

	system("pause");
}

