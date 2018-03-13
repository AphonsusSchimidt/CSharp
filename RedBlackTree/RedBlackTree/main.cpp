#define _CRT_SECURE_NO_WARNINGS
#include "redBlack.h"


void main()
{
	RedBlack<int, int> tree;
	int nhap = 0;
	do {
		printf("1.Khoi tao cay\n2.Xem cay\n3.xoa \n4.Thoat\n");
		printf("Nhap Vao Lua Chon: "); scanf("%d", &nhap);
		switch (nhap)
		{
		case 1:
		{
			int n = 0;
			printf("Nhap Vao Chieu cao: "); scanf("%d", &n);
			for (int i = 1; i <= n; ++i)
			{
				tree.Insert(i, i);
			}
			printf("Khoi tao xong \n"); system("pause"); system("cls");
			break;
		}	
		case 2:
			printf("cay duoc Khoi tao \n");
			tree.outPut();
			printf("\n"); system("pause"); system("cls");
			break;
		case 3:
		{
			int key = 0;
			printf("\nNhap key can xoa: key= "); scanf("%d", &key);
			tree.Delete(key);
			tree.outPut();
			printf("\n"); system("pause"); system("cls");
			break;
		}
		case 4:
			return;
		}


	} while (nhap != 4);
	system("pause");

}