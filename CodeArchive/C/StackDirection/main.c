#include <stdio.h>

int total = 0;

void SumRecursion(int n) {
	int x = 0;
	int arr[] = { 1, 2, 3 };

	n += 1;
	total += 1;
	printf("n is %d, total is %d &x=[%d]\n", n, total, &x);
	for (int i = 0; i < 3; i++) {
		printf("&arr[%d] is %d\n", i, &arr[i]);
	}
	if (total < 3) {
		SumRecursion(n);
	}
	printf("...n is %d, total is %d &x=[%d]\n", n, total, &x);
}


int main(int argc, char **argv) {
	printf("At START: total is %d\n", total);
	SumRecursion(0);
	printf("At END: total is %d\n", total);
	return 0;
}