#ifndef _NODE_H
#define _NODE_H

#include "Recs.h"

class Node
{
	public:
		Node();
		~Node();
		void Converge(Node* node);
		Vector2 GetPosition();
	private:
		Vector2 position;
};

#endif