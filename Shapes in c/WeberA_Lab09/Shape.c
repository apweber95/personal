#include <stdio.h>
#include <stdlib.h>
#include "Shape.h"


Shape* New_Shape() {
	Shape* sh = NULL;
	sh = (Shape*)malloc(sizeof(Shape));
	sh->Area = NULL;
	sh->Perimeter = NULL;
	sh->derivedObj = NULL;
	return sh;
}