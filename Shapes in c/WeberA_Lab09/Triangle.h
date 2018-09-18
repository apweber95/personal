#include <stdio.h>
#include <stdlib.h>
#include "Shape.h"


typedef struct _triangle {

	Shape* sObjectT;

	double height;
	double width;
	double left;
	double right;
}Triangle;

Shape* New_Triangle(double, double, double, double);
double Perimeter(Shape*);
double Area(Shape*);
