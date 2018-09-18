#include <stdio.h>
#include <stdlib.h>
#include "Shape.h"

#ifndef Square_H
#define Square_H

typedef struct _square {
	Shape* sObjectS;
	double length;

}Square;

Shape* New_Square(double);
double Perimeter(Shape*);
double Area(Shape*);
#endif