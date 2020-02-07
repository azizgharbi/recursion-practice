#include <stdio.h>

// this returns the sum of the first n integers using recursion
// We start with n (e.g. 10) and count back to 1. We subtract 1 repeatedly (to get 9, 8, 7, 6... etc.)
// and sum all the numbers...

int SumRecursion(int n) {
	int total;

	if (n == 1) {
		total = 1;
	} else {
		total = n + SumRecursion(n - 1);
	}
	return total;
}

// this returns the sum of the first n integers using iteration
// We count from 0 to n and sum all numbers (e.g. 1,2,3,4... etc.)
int SumIteration(int n) {
	int total;

	total = 0;
	for (int i = 1; i <= n; i++) {
		total += i;
	}
	return total;
}

int main(int argc, char** argv) {
	int n = 17;
	//use recursion	
	printf("Sum of the first %d integers using recursion is %d\n", n, SumRecursion(n));
	// use iteration
	printf("Sum of the first %d integers using iteration is %d\n", n, SumIteration(n));
	// you can prove (mathemetically) that Sum(n) = n * (n+1) / 2
	printf("Sum of the first %d integers using mathematics is %d\n", n, (n * (n+1)) / 2);
	

	// so which is best?
	// in this simple case mathematics is the fastest, the iteration and lastly recursion
	// but ...
	// in all but the simplest cases, mathematics is not available
	// recursion can be usually converted to iteration ... but the result is often more compicated and less clear
	// so ... used with care recursion can be a powerful tool
	return 0;
}
