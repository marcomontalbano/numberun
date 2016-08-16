
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** CREDITI ***							*
		*																	*
		*	Nome:			CREDITI_TESTO.H									*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			libreria del gioco (crediti del gioco - testo)	*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
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
void mostra_crediti_testo();


//Mostra la guida del gioco
void mostra_crediti_testo()
{
	int a = 0, b = 0;		//Variabili x e y della gotoxy


	//Pulisce lo schermo (lo rende pronto per la scrittura)
	system("cls");

	//GUIDA
	printf("\n\n");
		//NumbeRun
			color(15);	printf("*** ");
			color(14);	printf("N");
			color(6);	printf("u");
			color(4);	printf("m");
			color(5);	printf("b");
			color(8);	printf("e");
			color(2);	printf("R");
			color(10);	printf("u");
			color(11);	printf("n");

			color(8);	printf("  v 1.0");
			color(15);	printf(" ***");
			printf("\n");
		//Autori
			color(10);	printf("> programmato da: ");
			color(11);	printf("Marco Montalbano & Giacomo Brambilla");
			printf("\n\n");
		//Direttore
			color(12);	printf(">\tDIRETTORE DEL PROGETTO:");	printf("\n");
			color(3);	printf("\tMontalbano Marco");	printf("\n");
			printf("\n");
		//Programmatori
			color(12);	printf(">\tPROGRAMMATO DA:");	printf("\n");
			color(3);	printf("\tMontalbano Marco");	printf("\n");
			color(3);	printf("\tBrambilla Giacomo");	printf("\n");
			printf("\n");
		//Grafica
			color(12);	printf(">\tGRAFICA:");	printf("\n");
			color(3);	printf("\tMontalbano Marco");	printf("\n");
			printf("\n");
		//Game Design
			color(12);	printf(">\tGAME DESIGN:");	printf("\n");
			color(3);	printf("\tMontalbano Marco");	printf("\n");
			color(3);	printf("\tBrambilla Giacomo");	printf("\n");
			printf("\n");
		//Collaboratori
			color(12);	printf(">\tCOLLABORATORI:");	printf("\n");
			color(3);	printf("\tMontalbano Marco");	printf("\n");
			color(3);	printf("\tBrambilla Giacomo");	printf("\n");
			color(3);	printf("\tBrunelli Matteo");	printf("\n");
			color(3);	printf("\tStraniero Luca");	printf("\n");
			color(3);	printf("\tBelzoino Simone");	printf("\n");
			color(3);	printf("\tNeri Salvatore");	printf("\n");
			color(3);	printf("\tCurci Mirko");	printf("\n");
			color(3);	printf("\tCordara Edriano");	printf("\n");
			color(3);	printf("\tTavazzani Marco");	printf("\n");
			color(3);	printf("\tRizzo Mariacristina");	printf("\n");
			color(3);	printf("\tMirean Marius");	printf("\n");
			printf("\n");
		//Sviluppatori
			color(12);	printf(">\tSVILUPPATO DA:");	printf("\n");
			color(3);	printf("\tThree Thousand");	printf("\n");
			printf("\n");
		//Collaborazione con:
			color(12);	printf(">\tIN COLLABORAZIONE CON:");	printf("\n");
			color(3);	printf("\tMarkS Laboratory");	printf("\n");
			color(3);	printf("\tBrambi Lab");	printf("\n");
			printf("\n");


		gotoxy(a,b);
}

