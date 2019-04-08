#include <cstdio>
#include <cstdlib>

struct Node
{
	int data;
	Node* prev;
	Node* next;
};

class List
{
private:
	Node* head; //dummy node
	Node* tail; //dummy node

	Node* AllocNode(int data)
	{
		Node* p = new Node;
		p->data = data;
		p->prev = p->next = NULL;
		return p;
	}
public:
	void AddList(int data)
	{
		Node* p = AllocNode(data); //new node
		Node* ptail = tail->prev;  //new node is inserted between last node(ptail) and tail node
		ptail->next = p;
		p->prev = ptail;
		tail->prev = p;
	}

	void PrintNextList()
	{
		for(Node* p=head->next; p!=tail; p=p->next)
			printf("%d\n", p->data);
	}

	void PrintPrevList()
	{
		for (Node* p = tail->prev; p != head; p = p->prev)
			printf("%d\n", p->data);
	}

	List()
	{
		head = AllocNode(0);
		tail = AllocNode(0);
		head->next = tail;
		tail->prev = head;
	}

	~List()
	{
		for (Node* p = head; p != NULL; p = p->next)
		{
			Node* np = p->next;
			delete p;
			p = np;
		}
	}
};

int main()
{
	List lt;

	lt.AddList(10);
	lt.AddList(20);
	lt.AddList(30);

	lt.PrintNextList();
	lt.PrintPrevList();

	system("pause");
}
