#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include <stdio.h>

int indent = 0;

int GetDir(char* dirName) {
	WIN32_FIND_DATA ffd;
	long long filesize;
	char s[MAX_PATH];
	HANDLE h;
	DWORD r;

	indent += 1;									// increment the indent level for printing
	filesize = 0;									// initialize the file size (a 64-bit quantity) to zero

	// append '\*' to the directory name
	strncpy(s, dirName, MAX_PATH);
	strncat(s, "\\*", MAX_PATH);

	// find the first file in the directory using a windows API call
	h = FindFirstFile(s, &ffd);
	if (h == INVALID_HANDLE_VALUE) {
		printf("FindFirstFile failed\n");
		r = GetLastError();
		goto exit;
	}

	// list the directories and calculate the total file size in the directory
	// we don't want to know about the current directory '.' or the parent directory '..' so ignore those
	do {
		// look for a directory by examining the file's attributes
		if (ffd.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) {
			if (strcmp(ffd.cFileName, ".") != 0 && strcmp(ffd.cFileName, "..") != 0) {
				strncpy(s, dirName, MAX_PATH);
				strncat(s, "\\", MAX_PATH);
				strncat(s, ffd.cFileName, MAX_PATH);
				GetDir(s);							// get the next level of directory information
			}
		} else {
			// we've got an ordinary file, so add its size to the total
			// note the cast here - the 32-bit ints must be converted to 64-bit ints *before* the left shift
			filesize += (long long)ffd.nFileSizeLow + ((long long)ffd.nFileSizeHigh << 32);
		}
	} while (FindNextFile(h, &ffd) != 0);			// loop until 'FindNextFile' returns '0'

	// check that the return value from 'FindNextFile' is what we want
	r = GetLastError();
	if (r != ERROR_NO_MORE_FILES) {
		printf("FindNextFile failed\n");
		goto exit;
	}

	// print out the information
	if (strcmp(ffd.cFileName, ".") != 0 && strcmp(ffd.cFileName, "..") != 0) {
		for (int i = 0; i < indent; i++) {
			printf(" ");
		}
		printf("%s [%lld]\n", dirName, filesize);
	}

	FindClose(h);				// release the handle
	indent -= 1;

exit:
	return r;
}

int main(int ac, char** av) {

	// get some directory information (note that this prints out the data in an 'upside-down' way
	// if you want a top down listing we will have to do quite a bit more work
	// NOTE: Use an EXISTING Directory name here!!!
	GetDir("E:\\Test");
	return 0;
}