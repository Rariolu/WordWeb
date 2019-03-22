#include "WordWebOps.h"

double WordWebOps::Lerp(double a, double b, double f)
{
	return a + f*(b - a);
}