
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** NUMBERUN ***							*
		*																	*
		*	Nome:			NUMBERUN.H										*
		*	Programmato da: Montalbano Marco & Brambilla Giacomo			*
		*	Genere:			Libreria del gioco (colore e spostamenti cur.)	*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/


//Libreria colorok.h
#include <windows.h>


//Elenco funzioni contenute
	//Colore
	void getdefaultcolor();
	void setdefaultcolor();
	void color(int);

	//Spostamento cursore
	void gotoxy(int, int);

	//Fusioni di funzioni
	void colorxy(int, int, int); 



//Lista colori base di sistema
/*
	0	Nero			0
	1	Blu (Dark)		1
	2	Verde (Dark)	2
	3	Azzurro (Dark)	3
	4	Rosso (Dark)	4
	5	Viola (Dark)	5
	6	Giallo (Dark)	6
	7	Grigio (Light)	7
	8	Grigio (Dark)	8
	9	Blu (Light)		9
	10	Verde (light)	A
	11	Azzurro (Light)	B
	12	Rosso (Light)	C
	13	Viola (Light)	D
	14	Giallo (Light)	E
	15	Bianco			F
*/

//Variabili globali
WORD wDefaultColorAttrs;

//Memorizza il colore del default
void getdefaultcolor()
{
HANDLE hStdout; 
CONSOLE_SCREEN_BUFFER_INFO csbiInfo;

hStdout = GetStdHandle(STD_OUTPUT_HANDLE); 
GetConsoleScreenBufferInfo(hStdout, &csbiInfo);
wDefaultColorAttrs = csbiInfo.wAttributes; 
}

//Setta il colore in default
void setdefaultcolor()
{
HANDLE hStdout; 

hStdout = GetStdHandle(STD_OUTPUT_HANDLE); 
SetConsoleTextAttribute(hStdout, wDefaultColorAttrs);
}

//Sceglie il colore da usare da un momento preciso in poi
void color(int color)
{
HANDLE hStdout;  

hStdout = GetStdHandle(STD_OUTPUT_HANDLE); 
SetConsoleTextAttribute(hStdout, color);
}

//Sposta il cursore in posizione X & Y
void gotoxy(int x, int y)
{
COORD coord;
coord.X = x;
coord.Y = y;
SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

void colorxy(int color, int x, int y)
{
//Colore del testo
HANDLE hStdout;  

hStdout = GetStdHandle(STD_OUTPUT_HANDLE); 
SetConsoleTextAttribute(hStdout, color);

//Cordinate del testo
COORD coord;
coord.X = x;
coord.Y = y;
SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

