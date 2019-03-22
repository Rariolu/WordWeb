#include "Node.h"

Node::Node()
{

}

Node::~Node()
{

}

void Node::Converge(Node* node)
{
	position.LerpTowards(node->GetPosition(),1);
}

Vector2 Node::GetPosition()
{
	return position;
}