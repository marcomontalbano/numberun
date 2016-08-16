
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** NUMBERUN ***							*
		*																	*
		*																	*
		*	Realizzata da: Montalbano Marco	& Brambilla Giacomo				*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



//Elenco funzioni contenute
/*
*
*		void getdefaultcolor()
*		void setdefaultcolor()
*		void color(int T_color)
*
*		void gotoxy(int x, int y)
*
*/


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

//Evidenziamenti
/*
	0	<= nero			>= 15,
	16	<= blu_light	>= 31,
	32	<= verde_light	>= 47,
	48	<= azzurro_dark	>= 63,
	64	<= rosso_dark	>= 79,
	80	<= viola_dark	>= 95,
	96	<= giallo_dark	>= 111,
	112	<= grigio_light	>= 127,
	128	<= grigio_dark	>= 143,
	144	<= blu_light	>= 159,
	160	<= verde_light	>= 175,
	176	<= azzurro_light>= 191,
	192	<= rosso_light	>= 207,
	208	<= viola_light	>= 223,
	224	<= giallo_light	>= 239,
	240	<= bianco		>= 255,
*/


//Libreria colorok.h
#include <windows.h>

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
void color(int T_color)
{
int color;
color = T_color;
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