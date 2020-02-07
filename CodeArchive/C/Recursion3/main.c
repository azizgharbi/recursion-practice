#include <stdio.h>

int SumRecursion(int callnum, int n) {
	int total;
	int newnum;

	callnum++;
	printf("Enter\t\t#[%d]: SumRecursion(n=%d)\n", callnum, n);
	if (n == 1) {
		total = 1;
		printf("     --- End condition met! total=%d ---\n", total);
	} else {
		newnum = n - 1;
		printf("  before\t#[%d]: SumRecursion(%d)\n", callnum, newnum);
		total = n + SumRecursion(callnum, newnum);
		printf("  after \t#[%d]: total=%d\n", callnum, total);
	}
	printf("Return: n=%d, total=%d\n", n, total);
	return total;
}


int main(int argc, char **argv) {
	int startnum = -3;

	printf("\nmain: Sum of the first %d integers using recursion is %d\n", startnum, SumRecursion(0, startnum));
	return 0;
}