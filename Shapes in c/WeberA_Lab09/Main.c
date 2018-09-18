#include <stdio.h>
#include <stdlib.h>
#include "Shape.h"
#include "Square.h"
#include "Triangle.h"

int main(int argc, const char * argv[]) {
	double area = 0.0;
	double perim = 0.0;
	Shape* mySquare = New_Square(3);
	Shape * myTriangle = New_Triangle(3, 4, 5, 2);

	area = mySquare->Area(mySquare);
	printf("The area of the square is: %f\n", area);
	perim = mySquare->Perimeter(mySquare);
	printf("The perimeter of the sqaure is: %f\n", perim);

	area = myTriangle->Area(myTriangle);
	printf("The area of the triangle is: %f\n", area);
	perim = myTriangle->Perimeter(myTriangle);
	printf("The perimeter of the Triangle is: %f\n", perim);

	return 0; 



}