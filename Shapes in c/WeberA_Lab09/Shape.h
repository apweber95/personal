#include <stdio.h>
#include <stdlib.h>

#ifndef Shape_H
#define Shape_H

typedef struct _Shape Shape;
typedef double (*fptrArea)(Shape*);
typedef double (*fptrPerimeter)(Shape*);


typedef struct _Shape {

	void* derivedObj;
	fptrArea Area;
	fptrPerimeter Perimeter;

}Shape;

Shape* New_Shape();

#endif // !Shape_H