#include <stdio.h>

int total = 0;

void SumRecursion(int callnum, int n) {
	int localtotal;

	callnum++;
	if (callnum <= 3) {
		localtotal = n + 1;
		total = n + 1;
		printf("a) In SumRecursion() call#%d localtotal=%d, total=%d\n", callnum, localtotal, total);
		SumRecursion(callnum, localtotal);		
		printf("b) In SumRecursion() call#%d localtotal=%d, total=%d\n", callnum, localtotal, total);
	}
}


int main(int argc, char **argv) {
	int startnum = 0;

	SumRecursion(0, startnum);
	printf("\nmain: After recursion total=%d\n", total);
	return 0;
}