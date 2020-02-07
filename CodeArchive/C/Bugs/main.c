#include <stdio.h>

/* Compile and run in both Debug and Release mode.
Also Disable Security Check(C / C++, Code Generation, Security Check)
and Basic Run Time Checks (C / C++, Code Generation, Basic Run Time Checks) to Default
*/

int total = 0;

void test1(int a, int b) {
	int c[2];

	c[0] = 0x55555555;
	c[1] = 0x55555555;
	c[2] = 0x55555555;
	c[3] = 0x55555555;
	printf("test1 finished a=%d, b=%d\n", a, b);
}

void SumRecursion(int n) {
	int c[2];
	
	c[0] = 0x55555555;
	c[1] = 0x55555555;
	c[2] = 0x55555555;
	c[3] = 0x55555555;
/*	c[4] = 0x55555555;
	c[5] = 0x55555555; */


	n += 1;
	total += 1;
	printf("n is %d, total is %d\n", n, total);
	if (total < 3) {
		SumRecursion(n);
	}
	printf("...n is %d, total is %d\n", n, total);	
}


int test2() {
	printf("At START: total is %d\n", total);
	SumRecursion(0);
	printf("At END: total is %d\n", total);
	return 0;
}



int main(int ac, char **av) {

	 // test1(1, 2);
	 test2();
	 printf("Program ends\n");
	return 0;
}
