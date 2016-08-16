
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** GUIDA ***								*
		*																	*
		*	Nome:			GUIDA.H											*
		*	Programmato da: Montalbano Marco & Brambilla Giacomo			*
		*	Genere:			libreria del gioco (guida del gioco)			*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



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
void mostra_guida();


//Mostra la guida del gioco
void mostra_guida()
{
	char scelta_guida;		//Caso di uscita dalla guida
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
		//Comandi
			color(12);	printf(">\tCOMANDI:");	printf("\n");
			color(3);	printf("\tsu:\t\tUP");	printf("\n");
			color(3);	printf("\tgiu\':\t\tDOWN");	printf("\n");
			color(3);	printf("\tdestra:\t\tRIGHT");	printf("\n");
			color(3);	printf("\tsinistra:\tLEFT");	printf("\n");
			color(3);	printf("\tchat gioco:\t\\");	printf("\n");
			color(3);	printf("\tesci:\t\tq");	printf("\n");
			printf("\n");
		//Significato dei segni
			color(12);	printf(">\tSIGNIFICATO DEI NUMERI:");	printf("\n");
			//1
				color(11);	printf("\t1");
				color(3);	printf(":\tpozza d\'acqua (-1 vita)");	printf("\n");
			//2
				color(14);	printf("\t2");
				color(3);	printf(":\ttesoro (+10 punti)");	printf("\n");
			//3
				color(15);	printf("\t3");
				color(3);	printf(":\tpozione cristallizzante (cristallizza l\'acqua)");	printf("\n");
			//5
				color(13);	printf("\t5");
				color(3);	printf(":\tFiveRun (il protagonista)");	printf("\n");
			//7
				color(8);	printf("\t7");
				color(3);	printf(":\tmura solide del gioco");	printf("\n");
			//8
				color(10);	printf("\t8");
				color(3);	printf(":\tmostri (-1 vita)");	printf("\n");
			//9
				color(2);	printf("\t9");
				color(3);	printf(":\tfine del gioco");	printf("\n");
			printf("\n");
		//Scopo del gioco
			color(12);	printf(">\tSTORIA E REGOLE DEL GIOCO:");	printf("\n");
			//Inizio storia e regole del gioco
				color(3); //imposto colore azzurro chiaro
				printf("\tFiveRun (5) e\' intrappolato nel castello di DarkRun.");	printf("\n");
				printf("\tAiutalo a fuggire dal castello, stando pero\' attento alle pozze");	printf("\n");
				printf("\td\'acqua (1), che non sarai in grado di sorpassare, a meno che");	printf("\n");
				printf("\ttu non abbia con te una pozione cristallizzante (3); e agli");	printf("\n");
				printf("\tscagnozzi di DarkRun, altrimenti perderai una vita.");	printf("\n");
				printf("\tNel castello sono custoditi antichi tesori (2); accumulane il");	printf("\n");
				printf("\tpiu\' possibile per guadagnare vite.");	printf("\n");
				printf("\tLa porta (9), che ti fara\' uscire da ogni stanza, si aprira\'");	printf("\n");
				printf("\tsolamente quando il tuo punteggio sara\' superiore a quello dei");	printf("\n");
				printf("\tmostri; in contrario scattera\' una trappola che ti farà");	printf("\n");
				printf("\tperdere una vita.");	printf("\n");

		gotoxy(a,b);

		scelta_guida = 'z';

		//Aspetta il premere di un tasto
		while ((scelta_guida == 'a') || (scelta_guida == 'z'))
		{
			scelta_guida = getch();

			if ((scelta_guida == 'a') && (b > 0))
				b--;

			if ((scelta_guida == 'z') && (b < 34))
				b++;

			gotoxy(a,b);
		}
}

