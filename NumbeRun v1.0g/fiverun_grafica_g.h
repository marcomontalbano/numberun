
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** FIVERUN ***							*
		*																	*
		*	Nome:			FIVERUN_GRAFICA_G.H								*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			libreria del gioco (grafica FiveRun)			*
		*	Piattaforma:	Windows											*
		*	Copyright:		2006 / 2007										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/


//Elenco funzioni contenute
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

//Elenco funzioni contenute
void FIVERUN_GRAFICA_G(int, int);


//Mostra la guida del gioco
void FIVERUN_GRAFICA_G(int b, int a)
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

