
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** MOVIMENTO GRAFICO ***					*
		*																	*
		*	Nome:			MOVIMENTO_GRAFICO.H								*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			Libreria del gioco (movimento grafico del gioco)*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/


//fiverun è il numero 9

//Elenco funzioni contenute
	//muove i FiveRun nelle mappe del menù
	void  muovi_oggetti_nel_menu(int);
	void Disegna_Veloce_Menu(int, int);
	void Converti_Cordinate_In_Grafica_Menu(int, int);
		//funzioni per il disegno grafico
		void menu_0(int, int);
		void menu_1(int, int);
		void menu_2(int, int);
		void menu_3(int, int);
		void menu_4(int, int);
		void menu_5(int, int);
		void menu_6(int, int);
		void menu_7(int, int);
		void menu_8(int, int);
		void menu_9(int, int);
		void menu_10(int, int);


void muovi_oggetti_nel_menu(int oggetto)
{
	int mov, a, b;
	//RANDOM CASUALE
	mov =  (rand()%4)+1;


	//Generamento di un 2 in modo random
	do
	{
		//1a RANDOM CASUALE
		a =  (rand()%22)+1;			
		//2a RANDOM CASUALE
		b =  (rand()%80)+1;			

	//condizione di uscita
	} while (A[a][b] != oggetto);

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[a][b] = 0;
			if ((A[a-1][b] == 0) && ((a-1 < RIGHE-2) && (a-1 > 1)) && ((b < COLONNE-2) && (b > 0)))
			{
				a--;
			}
			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[a][b] = 0;
			if ((A[a+1][b] == 0) && ((a+1 < RIGHE-2) && (a+1 > 0)) && ((b < COLONNE-2) && (b > 0)))
			{
				a++;
			}
			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[a][b] = 0;
			if ((A[a][b+1] == 0) && ((a < RIGHE-1) && (a > 0)) && ((b+1 < COLONNE-1) && (b+1 > 0)))
			{
				b++;
			}
			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[a][b] = 0;
			if ((A[a][b-1] == 0) && ((a < RIGHE-1) && (a > 0)) && ((b-1 < COLONNE-1) && (b-1 > 0)))
			{
				b--;
			}
			break;
		}
	}
	A[a][b] = oggetto;
	Disegna_Veloce_Menu(a,b);
}

void Disegna_Veloce_Menu(int a, int b)
{
	a--;
	b--;
	int c = a;
	int d = b;
	int e = a+2;
	int f = b+2;
	for(c=a; c<=e; c++)
	{
		for(d=b; d<=f; d++)
		{
			Converti_Cordinate_In_Grafica_Menu(c,d);
		}
	}
}

void Converti_Cordinate_In_Grafica_Menu(int a ,int b)
{
			if (A[a][b] == 0)
				menu_0(a, b);		//terreno del gioco

			if (A[a][b] == 1)
				menu_1(a, b);		//angolo basso sinistro

            if (A[a][b] == 2)
				menu_2(a, b);		//angolo basso destro

            if (A[a][b] == 3)
				menu_3(a, b);		//angolo alto destro

            if (A[a][b] == 4)
				menu_4(a, b);		//angolo alto sinistro

            if (A[a][b] == 5)
				menu_5(a, b);		//angoli alti

			if (A[a][b] == 6)
				menu_6(a, b);		//pozza d'acqua

			if (A[a][b] == 7)
				menu_7(a, b);		//angoli sinistri
			
			if (A[a][b] == 8)
				menu_8(a, b);		//Mostro

			if (A[a][b] == 9)
				menu_9(a, b);		//FiveRun

			if (A[a][b] == 10)
				menu_10(a, b);		//intero
}

//Mostra la guida del gioco
void menu_0(int b, int a)
{

DrawPoints(0 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 102, 102, 102);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 0, 0);

}

void menu_1(int b, int a)
{

DrawPoints(0 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}
void menu_2(int b, int a)
{

DrawPoints(0 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);

}

void menu_3(int b, int a)
{

DrawPoints(0 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}

void menu_4(int b, int a)
{

DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}

void menu_5(int b, int a)
{

DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}

void menu_6(int b, int a)
{

DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 255);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 230);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 0, 204);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 0, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 0, 179);

}

void menu_7(int b, int a)
{

DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}

void menu_8(int b, int a)
{

DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 102, 153);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 51, 179, 26);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 77, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 77, 0);

}

void menu_9(int b, int a)
{

DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 221, 156, 230);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 234, 109, 255);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 219, 115, 5);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 253, 151, 43);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 234, 109, 255);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 5, 50, 255);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 158, 134, 59);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 158, 134, 59);

}

void menu_10(int b, int a)
{

DrawPoints(0 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 0 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 1 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 2 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 3 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(6 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 4 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(2 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(4 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(5 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(7 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(9 + (dimensione_pixel*a), 5 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(1 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 6 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(0 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(1 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(3 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(8 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 7 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(0 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(2 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(9 + (dimensione_pixel*a), 8 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(0 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(1 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(2 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(3 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(4 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(5 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(6 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 26, 26, 179);
DrawPoints(7 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 230, 255, 0);
DrawPoints(8 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);
DrawPoints(9 + (dimensione_pixel*a), 9 + (dimensione_pixel*b), 0, 204, 0);

}
