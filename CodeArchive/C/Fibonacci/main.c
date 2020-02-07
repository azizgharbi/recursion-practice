#include <stdio.h>
long long  number_of_calls = 0;		// this is the number of times that the Fibonacci procedure is called


// this calculates the nth number in the Fibonacci sequence
int FibonacciRecursion(int n) {
	int r;

	number_of_calls += 1;
	switch (n) {
	case 0:
		r = 0;
		break;
	case 1:
		r = 1;
		break;
	default:
		r = FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
		break;
	}
	return r;
}


int FibonacciIteration(int n) {
	int r = 1;
	int y = 0;

	switch (n) {
	case 0:
		r = 0;
		break;
	case 1:
		r = 1;
		break;
	default:
		for (int i = 1; i < n; i++) {
			r += y;
			y = r - y;
		}
		break;
	}
	return r;
}

int main(int ac, char** av) {
	int r;
	// now let's look at something where recursion isn't really that good - you'll often see Fibonacci numbers evaluated recursively in examples of recursion
	// but here the number of calls grows exponentially - which makes the method totally unusable for large Fibonacci numbers (or even quite modest Fibonacci numbers)
	// if you try calculating the 50th Fibonacci number using this method, you'll be waiting some time, so let's try the 45th ...
//	r = FibonacciRecursion(45);
//	printf("The %d Fibonacci number is %d (with %lld calls)\n", 45, r, number_of_calls);

	// let's just do the first 10
	for (int i = 0; i < 10; i++) {
		number_of_calls = 0;			// reset the number of times the procedure has been called
		 r = FibonacciRecursion(i);
		 printf("a) The %d Fibonacci number is %d (with %lld calls)\n", i, r, number_of_calls);
		// NOTE: if I did the calculation like this ...
	// printf("b) The %d Fibonacci number is %d (with %lld calls)\n", i, FibonacciRecursion(i), number_of_calls);
		// the 'number-of-calls' is *not* what you might expect here!
		// this is because the 'number_of_calls' is pushed onto the stack *before* FibonacciRecursion is called - so it is always zero!
		// something to watch out for!
		// Now, if I did it like this it would work ...
	// printf("c) The %d Fibonacci number (with %lld calls) is %d \n", i, number_of_calls, FibonacciRecursion(i));
		// but this is *not* good coding!!! 
		// anything that relies on the order of parameters being evaluated in a function call is 
		// a) difficult to debug
		// b) likely to depend on the compiler used
		// so DO NOT DO THIS
	}


	// now lets do it by iteration
	for (int i = 0; i < 10; i++) {
		number_of_calls = 0;			// reset the number of times the procedure has been called
		r = FibonacciIteration(i);
		printf("The %d Fibonacci number is %ld\n", i, r);
	}
	// and this runs quickly as you would expect
	r = FibonacciIteration(45);
	printf("\n\nThe %d Fibonacci number is %ld\n", 45, r);
}