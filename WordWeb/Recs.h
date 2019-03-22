#ifndef _RECS_H
#define _RECS_H

#include "WordWebOps.h"

struct Vector2
{
	double X;
	double Y;
	void LerpTowards(Vector2 other, double f)
	{
		X = WWO::Lerp(X, other.X, f);
		Y = WWO::Lerp(Y, other.Y, f);
	}
};


#endif