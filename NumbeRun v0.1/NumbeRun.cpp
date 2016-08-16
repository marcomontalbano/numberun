//Librerie personalizzate
#include "NUMBERUN.H"

//Librerie di sistema
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>

const short RIGHE = 22;
const short COLONNE = 80;

int A[RIGHE][COLONNE];
int i, j;
int o, k;
int life;
int score;
char m;


void azzera_matrice();
void mostra_matrice();
void mov_mostro8();
void punteggio();
void mov_pers5();
void imposta_mura_generali();
void level1();

int main()
{
    life = 5;
    do
	{
		i = 18;
        j = 3;
        o = 8;
        k = 8;
		system("cls");
        azzera_matrice();
		imposta_mura_generali();
		//{Scrivere qua Level1}
		level1();

        do
		{
			mostra_matrice();
			mov_pers5();
			mov_mostro8();
		} while ((i != o) || (j != k));
		life--;
		color(9);
        gotoxy(0,RIGHE + 2);
		printf("Coordinate: Pers[%d,%d]   Life = %d   Score: %d", i, j, life, score);
	} while ((i != o) || (j != k) || (life != 0));
    i = o;
    j = k;
    //dead;
	
	return 0;
}

// {Azzera la matrice}
void azzera_matrice()
{
	int a, b;
	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			A[a][b] = 0;
		}
	}
}

// {Mostra la matrice}
void mostra_matrice()
{
	int a, b, x, y;
	x = 0;
	y = 0;
	gotoxy(0,0);
	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			if (A[a][b] == 0)	//{Strada (arancione)}
				color(6);
			if (A[a][b] == 5)	//{Protagonista (fucsia)}
				color (13);
            if (A[a][b] == 8)	//{Mostro (verde)}
				color (2);
            if (A[a][b] == 2)	//{Tesoro (giallo)}
				color (14);
            if (A[a][b] == 7)	//{Mura (grigio)}
				color (8);
            if (A[a][b] == 3)	//{Teletrasporto (bianco)}
				color (15);
            if (A[a][b] == 1)	//{Morte.. Game Over (Verde Chiaro)}
				color (11);
			
			printf("%d",A[a][b]);

		}
		y++;
		gotoxy(x,y);
	}
}

//{Movimento del mostro (8)}
void mov_mostro8()
{
	int mov;

	srand(time(NULL));
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o][k] = 0;
			o--;
			if (A[o][k] == 7)
				o++;
			A[o][k] = 8;
			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o][k] = 0;
			o++;
			if (A[o][k] == 7)
				o--;
			A[o][k] = 8;
			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o][k] = 0;
			k++;
			if (A[o][k] == 7)
				k--;
			A[o][k] = 8;
			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o][k] = 0;
			k--;
			if (A[o][k] == 7)
				k++;
			A[o][k] = 8;
			break;
		}
	}
}

//{Procedura per il punteggio}
void punteggio()
{
	if (A[i][j] == 2)
		score = score + 10;
}


//{Genera il movimento del Protagonista (5)}
void mov_pers5()
{
	int tratto = 0;
	color(9);
    gotoxy(0,RIGHE + 2);
    printf("Coordinate: Pers[%d,%d]   Life = %d   Score: %d", i, j, life, score);
    gotoxy(0,RIGHE + 1);
	do
	{
		printf("-");
		tratto++;
	} while (tratto != COLONNE);
	gotoxy(0,RIGHE);
	m = getch();

	switch(m)
	{
		//{Movimento UP}
		case ('8'):
		{
			A[i][j] = 0;
			i--;
			if (A[i][j] == 7)
				i++;
			punteggio();
			A[i][j] = 5;

			break;
		}
		//{Movimento DOWN}
		case ('5'):
		{
			A[i][j] = 0;
			i++;
			if (A[i][j] == 7)
				i--;
			punteggio();
			A[i][j] = 5;

			break;
		}
		//{Movimento RIGHT}
		case ('6'):
		{
			A[i][j] = 0;
			j++;
			if (A[i][j] == 7)
				j--;
			punteggio();
			A[i][j] = 5;

			break;
		}
		//{Movimento LEFT}
		case ('4'):
		{
			A[i][j] = 0;
			j--;
			if (A[i][j] == 7)
				j++;
			punteggio();
			A[i][j] = 5;

			break;
		}
	}
}

//{Imposta le mura generali del gioco}
void imposta_mura_generali()
{
	int a, b;
	
	//imposta muro sinistra
	b = 0;
	for (a = 0; a < RIGHE; a++)
	{
		A[a][b] = 7;
	}
	//imposta muro basso
	for (b = 0; b < COLONNE; b++)
	{
		A[a-1][b] = 7;
	}
	//imposta muro destra
	for (; a >= 0; a--)
	{
           A[a][b-1] = 7;
	}
	//imposta muro destra
	for (; b >= 0; b--)
	{
           A[a+1][b] = 7;
	}
}

//{Setta i parametri del level1}
void level1()
{
	int a, b;
	//Posizione giocatore principale
	A[i][j] = 5;

	//Posizione mostri
    A[o][k] = 8;
	//Posizione tesori
    A[5][45] = 2;
	A[19][24] = 2;

	//Mura aggiunte
	for (a = RIGHE; a != 2; a--)
		A[a][5] = 7;
	for (b = COLONNE/4; b != 5; b--)
		A[3][b] = 7;


}

/*


{Procedure scritta GameOver}
Procedure Game_Over;
Var
     i, j: integer;
Begin
     {Genera "G"}
     i:=5;
     j:=6;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=13);
     i:=4;
     j:=7;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     i:=9;
     j:=6;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=13);
     i:=10;
     j:=13;
     Repeat
           i:=i-1;
           A[i,j]:=1;
     Until (i=7);
     i:=7;
     j:=14;
     Repeat
           j:=j-1;
           A[i,j]:=1;
     Until (j=10);
     {Genera "a"}
     i:=4;
     j:=16;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     i:=5;
     j:=15;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=22);
     i:=4;
     j:=22;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     i:=7;
     j:=15;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=22);
     {Genera 'm'}
     i:=4;
     j:=25;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     i:=4;
     j:=31;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     A[5,26]:=1;
     A[6,27]:=1;
     A[7,28]:=1;
     A[6,29]:=1;
     A[5,30]:=1;
     {Genera 'e'}
     i:=4;
     j:=34;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=9);
     i:=5;
     j:=33;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=40);
     i:=7;
     j:=33;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=37);
     i:=9;
     j:=33;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=40);
     {Genera 'O'}
     i:=13;
     j:=37;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=18);
     i:=13;
     j:=43;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=18);
     i:=14;
     j:=36;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=43);
     i:=18;
     j:=36;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=43);
     {Genera 'v'}
     A[14,46]:=1;
     A[15,46]:=1;
     A[16,47]:=1;
     A[17,48]:=1;
     A[18,49]:=1;
     A[17,50]:=1;
     A[16,51]:=1;
     A[15,52]:=1;
     A[14,52]:=1;
     {Genera 'e'}
     i:=13;
     j:=55;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=18);
     i:=14;
     j:=54;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=61);
     i:=16;
     j:=54;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=58);
     i:=18;
     j:=54;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=61);
     {Genera 'r'}
     i:=13;
     j:=64;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=18);
     i:=14;
     j:=63;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=70);
     i:=13;
     j:=70;
     Repeat
           i:=i+1;
           A[i,j]:=1;
     Until (i=16);
     i:=16;
     j:=63;
     Repeat
           j:=j+1;
           A[i,j]:=1;
     Until (j=70);
     A[18,70]:=1;
     A[17,67]:=1;
End;

{Imposta parametri di morte del giocatore}
Procedure Dead;
Begin
     If ((i=o) and (j=k)) then
     Game_Over;
End;

*/  
