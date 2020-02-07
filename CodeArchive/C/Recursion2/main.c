#include <stdio.h>


int total = 0;

void SumRecursion(int callnum, int n) {
	int newnum;

	callnum++;
	printf("Enter\t\t#[%d]: SumRecursion(n=%d)\n", callnum, n);
	if (n == 1) {
		total = 1;
		printf("     --- End condition met! total=%d ---\n", total);
	} else {
		newnum = n - 1;
		printf("  before\t#[%d]: SumRecursion(%d)\n", callnum, newnum);
		SumRecursion(callnum, newnum);
		total = n + total;
		printf("  after \t#[%d]: total=%d\n", callnum, total);
	}
	printf("Return: n=%d, total=%d\n", n, total);
}

int main(int argc, char **argv) {
	int startnum = 3;

	SumRecursion(0, startnum);
	printf("\nmain: Sum of the first %d integers using recursion is %d\n", startnum, total);
	return 0;
}