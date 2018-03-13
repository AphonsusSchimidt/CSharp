#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
void SelectSort(int A[], int n)
{
	int temp;
	for (int i = 0; i < n; i++)
	{
		int min = i;
		for (int j = i + 1; j < n; j++)
		{
			if (A[j] < A[min])
			{
				min = j;
			}

		}
		temp = A[min];
		A[min] = A[i];
		A[i] = temp;
	}
	
}
void Show(int A[], int n)
{
	printf("Danh sach: \n");
	for (int i = 0; i < n; i++)
		printf("%d ", A[i]);

	printf("\n\nPress any key to continue...");
	
}
void main()
{
	int a[10];
	for (int i = 0; i < 4; i++)
	{
		printf("nhap vao so Thu [%d]: ",i+1);
		scanf("%d", &a[i]);
	}
	SelectSort(a, 4);
	Show(a, 4);
	_getch();

}