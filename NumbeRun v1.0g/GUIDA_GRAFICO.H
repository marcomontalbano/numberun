
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** GUIDA ***							*
		*																	*
		*	Nome:			MENU.H											*
		*	Programmato da: Montalbano Marco								*
		*	Grafica di:		Montalbano Marco								*
		*	Genere:			Libreria del gioco (guida grafica del gioco)	*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



//Elenco funzioni contenute
	//funzione principale del gioco
		void MOSTRA_GUIDA_GRAFICA();
	//matrice per la posizione della grafica nel gioco
		void carica_matrice_della_guida();
	//disegna la grafica del menù
		void DISEGNA_GUIDA_GRAFICA();
	//

bool guida_gia_stampata = true;

void MOSTRA_GUIDA_GRAFICA()
{

	stampa_niente = true;

	if (guida_gia_stampata == false)
	{

		guida_gia_stampata = true;

		//Pulisce l'intero schermo
			glClear(GL_COLOR_BUFFER_BIT);
		azzera_matrice();
		DISEGNA_GUIDA_GRAFICA();
		carica_matrice_della_guida();
		DISEGNA_GUIDA_GRAFICA();

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
				color(3);	printf("\trefresh:\tr");	printf("\n");
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
		}
}

void carica_matrice_della_guida()
{

A[2][32] = 6;
A[2][37] = 9;
A[3][18] = 4;
A[3][19] = 10;
A[3][20] = 10;
A[3][21] = 10;
A[3][22] = 10;
A[3][23] = 10;
A[3][24] = 10;
A[3][25] = 10;
A[3][26] = 3;
A[3][49] = 6;
A[3][62] = 9;
A[3][71] = 6;
A[4][9] = 8;
A[4][18] = 10;
A[4][19] = 10;
A[4][20] = 10;
A[4][21] = 10;
A[4][22] = 10;
A[4][23] = 10;
A[4][24] = 10;
A[4][25] = 10;
A[4][26] = 2;
A[5][18] = 10;
A[5][19] = 10;
A[5][29] = 4;
A[5][30] = 3;
A[5][34] = 4;
A[5][35] = 3;
A[5][38] = 4;
A[5][39] = 3;
A[5][42] = 4;
A[5][43] = 10;
A[5][44] = 10;
A[5][45] = 3;
A[5][46] = 8;
A[5][51] = 4;
A[5][52] = 10;
A[5][53] = 10;
A[5][54] = 10;
A[5][55] = 10;
A[5][56] = 10;
A[5][57] = 3;
A[6][18] = 10;
A[6][19] = 10;
A[6][24] = 6;
A[6][29] = 10;
A[6][30] = 10;
A[6][34] = 10;
A[6][35] = 10;
A[6][38] = 10;
A[6][39] = 10;
A[6][42] = 10;
A[6][43] = 10;
A[6][44] = 10;
A[6][45] = 10;
A[6][46] = 10;
A[6][47] = 3;
A[6][51] = 10;
A[6][52] = 10;
A[6][53] = 10;
A[6][54] = 10;
A[6][55] = 10;
A[6][56] = 10;
A[6][57] = 10;
A[7][18] = 10;
A[7][19] = 10;
A[7][29] = 10;
A[7][30] = 10;
A[7][34] = 10;
A[7][35] = 10;
A[7][38] = 10;
A[7][39] = 10;
A[7][42] = 10;
A[7][43] = 10;
A[7][46] = 1;
A[7][47] = 10;
A[7][51] = 10;
A[7][52] = 10;
A[7][56] = 10;
A[7][57] = 10;
A[8][8] = 6;
A[8][13] = 9;
A[8][18] = 10;
A[8][19] = 10;
A[8][22] = 4;
A[8][23] = 10;
A[8][24] = 10;
A[8][25] = 10;
A[8][26] = 3;
A[8][29] = 10;
A[8][30] = 10;
A[8][34] = 10;
A[8][35] = 10;
A[8][38] = 10;
A[8][39] = 10;
A[8][42] = 10;
A[8][43] = 10;
A[8][47] = 10;
A[8][48] = 3;
A[8][51] = 10;
A[8][52] = 10;
A[8][54] = 8;
A[8][56] = 10;
A[8][57] = 10;
A[9][18] = 10;
A[9][19] = 10;
A[9][22] = 1;
A[9][23] = 10;
A[9][24] = 10;
A[9][25] = 10;
A[9][26] = 10;
A[9][29] = 10;
A[9][30] = 10;
A[9][34] = 10;
A[9][35] = 10;
A[9][38] = 10;
A[9][39] = 10;
A[9][42] = 10;
A[9][43] = 10;
A[9][47] = 10;
A[9][48] = 10;
A[9][51] = 10;
A[9][52] = 10;
A[9][53] = 10;
A[9][54] = 10;
A[9][55] = 10;
A[9][56] = 10;
A[9][57] = 10;
A[9][62] = 6;
A[9][70] = 9;
A[10][18] = 10;
A[10][19] = 10;
A[10][25] = 10;
A[10][26] = 10;
A[10][29] = 10;
A[10][30] = 10;
A[10][34] = 10;
A[10][35] = 10;
A[10][38] = 10;
A[10][39] = 10;
A[10][42] = 10;
A[10][43] = 10;
A[10][47] = 10;
A[10][48] = 10;
A[10][51] = 10;
A[10][52] = 10;
A[10][53] = 10;
A[10][54] = 10;
A[10][55] = 10;
A[10][56] = 10;
A[10][57] = 10;
A[10][77] = 8;
A[11][18] = 10;
A[11][19] = 10;
A[11][25] = 10;
A[11][26] = 10;
A[11][29] = 10;
A[11][30] = 10;
A[11][34] = 10;
A[11][35] = 10;
A[11][38] = 10;
A[11][39] = 10;
A[11][41] = 6;
A[11][42] = 10;
A[11][43] = 10;
A[11][47] = 10;
A[11][48] = 2;
A[11][51] = 10;
A[11][52] = 10;
A[11][56] = 10;
A[11][57] = 10;
A[12][18] = 10;
A[12][19] = 10;
A[12][24] = 9;
A[12][25] = 10;
A[12][26] = 10;
A[12][29] = 10;
A[12][30] = 10;
A[12][32] = 8;
A[12][34] = 10;
A[12][35] = 10;
A[12][38] = 10;
A[12][39] = 10;
A[12][42] = 10;
A[12][43] = 10;
A[12][46] = 4;
A[12][47] = 10;
A[12][51] = 10;
A[12][52] = 10;
A[12][56] = 10;
A[12][57] = 10;
A[12][63] = 8;
A[13][18] = 10;
A[13][19] = 10;
A[13][20] = 10;
A[13][21] = 10;
A[13][22] = 10;
A[13][23] = 10;
A[13][24] = 10;
A[13][25] = 10;
A[13][26] = 10;
A[13][29] = 10;
A[13][30] = 10;
A[13][31] = 10;
A[13][32] = 10;
A[13][33] = 10;
A[13][34] = 10;
A[13][35] = 10;
A[13][38] = 10;
A[13][39] = 10;
A[13][42] = 10;
A[13][43] = 10;
A[13][44] = 10;
A[13][45] = 10;
A[13][46] = 10;
A[13][47] = 2;
A[13][51] = 10;
A[13][52] = 10;
A[13][56] = 10;
A[13][57] = 10;
A[14][18] = 1;
A[14][19] = 10;
A[14][20] = 10;
A[14][21] = 10;
A[14][22] = 10;
A[14][23] = 10;
A[14][24] = 10;
A[14][25] = 10;
A[14][26] = 2;
A[14][29] = 1;
A[14][30] = 10;
A[14][31] = 10;
A[14][32] = 10;
A[14][33] = 10;
A[14][34] = 10;
A[14][35] = 2;
A[14][38] = 1;
A[14][39] = 2;
A[14][42] = 1;
A[14][43] = 10;
A[14][44] = 10;
A[14][45] = 2;
A[14][51] = 1;
A[14][52] = 2;
A[14][56] = 1;
A[14][57] = 2;
A[15][72] = 6;
A[16][4] = 9;
A[17][20] = 8;
A[18][7] = 6;
A[18][44] = 9;
A[18][56] = 6;
A[19][25] = 6;
A[19][34] = 9;
A[19][63] = 9;
A[19][77] = 6;

}

void DISEGNA_GUIDA_GRAFICA()
{
	int a, b;

	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
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
				menu_6(a, b);		//angoli bassi

			if (A[a][b] == 7)
				menu_7(a, b);		//angoli sinistri
			
			if (A[a][b] == 8)
				menu_8(a, b);		//tutti gli angoli

			if (A[a][b] == 9)
				menu_9(a, b);		//FiveRun

			if (A[a][b] == 10)
				menu_10(a, b);		//intero
		}
	}
}
