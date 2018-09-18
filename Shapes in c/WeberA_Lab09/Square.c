#include <stdio.h>
#include <stdlib.h>
#include "Square.h"

double Square_Perimeter(Shape*);
double Square_Area(Shape*);

Shape* New_Square(double length) {
	Square* square = NULL;
	square = (Square*)malloc(sizeof(Square));
	if (square == NULL) {
		return NULL; 
	}
	square->sObjectS = New_Shape();
	square->sObjectS->derivedObj = square; 
	

	square->length = length;
	square->sObjectS->Area = Square_Area;
	square->sObjectS->Perimeter = Square_Perimeter;

	return square->sObjectS;
}

double Square_Perimeter(Shape* s) {
	double p = 0.0;
	double length = ((Square*)(s->derivedObj))->length;
	p = length + length + length + length;
	return p;
}

double Square_Area(Shape* s) {
	double a = 0.0;
	double length = ((Square*)(s->derivedObj))->length;
	a = length * 2;
	return a;

}