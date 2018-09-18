#include <stdio.h>
#include <stdlib.h>
#include "Triangle.h"

double Triangle_Perimeter(Shape* s);
double Triangle_Area(Shape* s);

Shape* New_Triangle(double left, double base, double right, double height) {
	Triangle* tr = NULL;
	tr = (Triangle*)malloc(sizeof(Triangle));
	if (tr == NULL) {
		return NULL;
	}
	tr->sObjectT = New_Shape();
	tr->sObjectT->derivedObj = tr;
	
	tr->height = height;
	tr->left = left;
	tr->right = right;
	tr->width = base;
	tr->sObjectT->Area = Triangle_Area;
	tr->sObjectT->Perimeter = Triangle_Perimeter;
	return tr->sObjectT;
}

double Triangle_Perimeter(Shape* s) {
	double p = 0.0;
	double left = ((Triangle*)s->derivedObj)->left;
	double right = ((Triangle*)s->derivedObj)->right;
	double base = ((Triangle*)s->derivedObj)->width;
	p = left + right + base;
	return p;

}

double Triangle_Area(Shape* s) {
	double a = 0.0;
	
	double base = ((Triangle*)s->derivedObj)->width;
	double height = ((Triangle*)s->derivedObj)->height;
	a = (base * height) / 2;
	return a;

}