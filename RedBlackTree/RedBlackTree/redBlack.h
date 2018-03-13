#include <cstdlib>
#include <stdexcept>
#include <iostream>
using namespace std;

template<typename Key, typename Value>
class RedBlack
{
public:
	RedBlack()
		: Goc(NULL)
	{
	}

	~RedBlack()
	{
		DeleteNode(Goc);
	}

	void Insert(const Key& key, const Value& value)
	{
		Node *node, *Cha, *z;

		Cha = NULL;
		node = Goc;
		while (node)
		{
			Cha = node;
			if (key < node->key)
			{
				node = node->Trai;
			}
			else
			{
				node = node->Phai;
			}
		}

		if (!Cha)
		{
			z = Goc = new Node;
			z->key = key;
			z->value = value;
			z->mau = BLACK;
			z->Cha = z->Trai = z->Phai = NULL;
		}
		else
		{
			z = new Node;
			z->key = key;
			z->value = value;
			z->mau = RED;
			z->Cha = Cha;
			z->Trai = z->Phai = NULL;

			if (z->key < Cha->key)
			{
				Cha->Trai = z;
			}
			else
			{
				Cha->Phai = z;
			}
		}

		Node *uncle;
		bool side;
		while (z->Cha && z->Cha->mau == RED)
		{
			if ((side = (z->Cha == z->Cha->Cha->Trai)))
			{
				uncle = z->Cha->Cha->Phai;
			}
			else
			{
				uncle = z->Cha->Cha->Trai;
			}

			if (uncle && uncle->mau == RED)
			{
				z->Cha->mau = BLACK;
				uncle->mau = BLACK;
				z->Cha->Cha->mau = RED;
				z = z->Cha->Cha;
			}
			else
			{
				if (z == (side ? z->Cha->Phai : z->Cha->Trai))
				{
					z = z->Cha;
					side ? QuayTrai(z) : QuayPhai(z);
				}

				z->Cha->mau = BLACK;
				z->Cha->Cha->mau = RED;
				side ? QuayPhai(z->Cha->Cha) : QuayTrai(z->Cha->Cha);
			}
		}

		Goc->mau = BLACK;
	}



	void Delete(const Key& key)
	{
		Node *node = Goc;
		while (node)
		{
			if (node->key > key)
			{
				node = node->Trai;
			}
			else if (node->key < key)
			{
				node = node->Phai;
			}
			else
			{
				break;
			}
		}

		if (!node || node->key != key)
		{
			return;
		}

		mau original=BLACK;
		Node *sub = new Node();
		Node *old = new Node();
		if (!node->Trai)
		{
			Ghep(node, sub = node->Phai);
		}
		else if (!node->Phai)
		{
			Ghep(node, sub = node->Trai);
		}
		else
		{
			old = Minimum(node->Phai);
			original = old->mau;
			sub = old->Phai;

			if (old->Cha == node)
			{
				sub->Cha = node;
			}
			else
			{
				Ghep(old, old->Phai);
				old->Phai = node->Phai;
				old->Phai->Cha = old;
			}

			Ghep(node, old);
			old->Trai = node->Trai;
			old->Trai->Cha = old;
			old->mau = node->mau;
		}

		delete node;
		if (original == BLACK)
		{
			bool side;
			Node *sibling;
			while (old != Goc && old->mau == BLACK)
			{
				if ((side = (old == old->Cha->Trai)))
				{
					sibling = old->Cha->Phai;
				}
				else
				{
					sibling = old->Cha->Trai;
				}

				if (sibling->mau == RED)
				{
					sibling->mau = BLACK;
					old->Cha->mau = RED;
					side ? QuayTrai(old->Cha) : QuayPhai(old->Cha);
					sibling = side ? old->Cha->Phai : old->Cha->Trai;
				}

				if (sibling->Trai->mau == BLACK && sibling->Phai->mau == BLACK)
				{
					sibling->mau = RED;
					old = old->Cha;
				}
				else
				{
					if (BLACK == side ? sibling->Phai->mau : sibling->Trai->mau)
					{
						sibling->mau = RED;
						if (side)
						{
							sibling->Trai->mau = BLACK;
							QuayPhai(sibling);
							sibling = old->Cha->Phai;
						}
						else
						{
							sibling->Phai->mau = BLACK;
							QuayTrai(sibling);
							sibling = old->Cha->Trai;
						}
					}

					sibling->mau = old->Cha->mau;
					old->Cha->mau = BLACK;
					if (side)
					{
						sibling->Trai->mau = BLACK;
						QuayTrai(old->Cha);
					}
					else
					{
						sibling->Phai->mau = BLACK;
						QuayPhai(old->Cha);
					}

					old = Goc;
				}
			}
		}
	}

	void outPut()
	{
		outPut(Goc, 0);
	}

private:
	enum mau
	{
		RED,
		BLACK
	};

	struct Node
	{
		mau mau;
		Key key;
		Value value;
		Node *Cha;
		Node *Trai;
		Node *Phai;
	};

	Node *Goc;

	void QuayTrai(Node *x)
	{
		Node *y;

		y = x->Phai;
		x->Phai = y->Trai;
		if (y->Trai)
		{
			y->Trai->Cha = x;
		}

		y->Cha = x->Cha;
		y->Trai = x;

		if (!x->Cha)
		{
			Goc = y;
		}
		else if (x == x->Cha->Trai)
		{
			x->Cha->Trai = y;
		}
		else
		{
			x->Cha->Phai = y;
		}
		x->Cha = y;
	}

	void QuayPhai(Node *y)
	{
		Node *x;

		x = y->Trai;
		y->Trai = x->Phai;
		if (x->Phai)
		{
			x->Phai->Cha = y;
		}

		x->Cha = y->Cha;
		x->Phai = y;

		if (!y->Cha)
		{
			Goc = x;
		}
		else if (y == y->Cha->Trai)
		{
			y->Cha->Trai = x;
		}
		else
		{
			y->Cha->Phai = x;
		}

		y->Cha = x;
	}

	void Ghep(Node *dest, Node *src)
	{
		if (dest->Cha == NULL)
		{
			Goc = src;
		}
		else if (dest == dest->Cha->Trai)
		{
			dest->Cha->Trai = src;
		}
		else
		{
			dest->Cha->Phai = src;
		}

		if (src)
		{
			src->Cha = dest->Cha;
		}
	}

	Node *Minimum(Node *tree)
	{
		while (tree->Trai)
		{
			tree = tree->Trai;
		}

		return tree;
	}

	void outPut(Node *node, int tabs)
	{
		if (!node)
		{
			return;
		}

		outPut(node->Trai, tabs + 1);

		for (int i = 0; i < tabs; ++i)
		{
			std::cout << "\t\t";
		}
		std::cout << node->key << (node->mau ? "B" : "R") << std::endl;

		outPut(node->Phai, tabs + 1);
	}

	void DeleteNode(Node *node)
	{
		if (!node)
		{
			return;
		}

		if (node->Trai)
		{
			DeleteNode(node->Trai);
		}

		if (node->Phai)
		{
			DeleteNode(node->Phai);
		}

		delete node;
	}
};
