#include <stdio.h>

int total = 0;

void SumRecursion(int n) {
	n += 1;
	total += 1;
	printf("n is %d, total is %d\n", n, total);
	if (total < 3) {
		SumRecursion(n);
	}
	printf("...n is %d, total is %d\n", n, total);
}


int main(int argc, char **argv) {
	printf("At START: total is %d\n", total);
	SumRecursion(0);
	printf("At END: total is %d\n", total);
	return 0;
}