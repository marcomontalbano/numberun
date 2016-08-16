
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** CREDITI ***							*
		*																	*
		*	Nome:			MENU.H											*
		*	Programmato da: Montalbano Marco								*
		*	Grafica di:		Montalbano Marco								*
		*	Genere:			Libreria del gioco (cretiti grafici del gioco)	*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



//Elenco funzioni contenute
	//funzione principale del gioco
		void MOSTRA_CREDITI_TESTUALI_GRAFICI();
	//matrice per la posizione della grafica nel gioco
		void carica_matrice_dei_crediti_testuali();
	//disegna la grafica del menù
		void DISEGNA_CREDITI_TESTUALI_GRAFICA();
	//

bool crediti_gia_stampati = true;

void MOSTRA_CREDITI_TESTUALI_GRAFICI()
{

	stampa_niente = true;

	if (crediti_gia_stampati == false)
	{

		crediti_gia_stampati = true;

		//Pulisce l'intero schermo
			glClear(GL_COLOR_BUFFER_BIT);
		azzera_matrice();
		DISEGNA_CREDITI_TESTUALI_GRAFICA();
		carica_matrice_dei_crediti_testuali();
		DISEGNA_CREDITI_TESTUALI_GRAFICA();

		//mostra i crediti testuali
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
}

void carica_matrice_dei_crediti_testuali()
{

A[1][37] = 9;
A[2][22] = 6;
A[2][43] = 6;
A[2][71] = 6;
A[3][13] = 4;
A[3][14] = 10;
A[3][15] = 10;
A[3][16] = 10;
A[3][17] = 10;
A[3][18] = 10;
A[3][19] = 3;
A[3][60] = 6;
A[4][13] = 10;
A[4][14] = 10;
A[4][15] = 10;
A[4][16] = 10;
A[4][17] = 10;
A[4][18] = 10;
A[4][19] = 2;
A[4][25] = 9;
A[4][49] = 8;
A[4][62] = 8;
A[4][69] = 9;
A[5][9] = 9;
A[5][13] = 10;
A[5][14] = 10;
A[5][22] = 4;
A[5][23] = 10;
A[5][24] = 10;
A[5][25] = 10;
A[5][26] = 10;
A[5][27] = 10;
A[5][28] = 3;
A[5][31] = 4;
A[5][32] = 10;
A[5][33] = 10;
A[5][34] = 10;
A[5][35] = 10;
A[5][36] = 3;
A[5][39] = 4;
A[5][40] = 10;
A[5][41] = 10;
A[5][42] = 10;
A[5][43] = 3;
A[5][48] = 4;
A[5][49] = 3;
A[5][52] = 4;
A[5][53] = 10;
A[5][54] = 10;
A[5][55] = 10;
A[5][56] = 10;
A[5][57] = 10;
A[5][58] = 10;
A[5][59] = 3;
A[5][62] = 4;
A[5][63] = 3;
A[6][13] = 10;
A[6][14] = 10;
A[6][22] = 10;
A[6][23] = 10;
A[6][24] = 10;
A[6][25] = 10;
A[6][26] = 10;
A[6][27] = 10;
A[6][28] = 10;
A[6][31] = 10;
A[6][32] = 10;
A[6][33] = 10;
A[6][34] = 10;
A[6][35] = 10;
A[6][36] = 2;
A[6][39] = 10;
A[6][40] = 10;
A[6][41] = 10;
A[6][42] = 10;
A[6][43] = 10;
A[6][44] = 3;
A[6][48] = 10;
A[6][49] = 10;
A[6][52] = 1;
A[6][53] = 10;
A[6][54] = 10;
A[6][55] = 10;
A[6][56] = 10;
A[6][57] = 10;
A[6][58] = 10;
A[6][59] = 2;
A[6][62] = 10;
A[6][63] = 10;
A[7][13] = 10;
A[7][14] = 10;
A[7][22] = 10;
A[7][23] = 10;
A[7][27] = 10;
A[7][28] = 10;
A[7][31] = 10;
A[7][32] = 10;
A[7][39] = 10;
A[7][40] = 10;
A[7][44] = 10;
A[7][48] = 10;
A[7][49] = 10;
A[7][55] = 10;
A[7][56] = 10;
A[7][62] = 10;
A[7][63] = 10;
A[8][7] = 6;
A[8][13] = 10;
A[8][14] = 10;
A[8][17] = 6;
A[8][22] = 10;
A[8][23] = 10;
A[8][27] = 10;
A[8][28] = 10;
A[8][31] = 10;
A[8][32] = 10;
A[8][34] = 8;
A[8][39] = 10;
A[8][40] = 10;
A[8][44] = 10;
A[8][45] = 3;
A[8][48] = 10;
A[8][49] = 10;
A[8][55] = 10;
A[8][56] = 10;
A[8][62] = 10;
A[8][63] = 10;
A[9][13] = 10;
A[9][14] = 10;
A[9][22] = 10;
A[9][23] = 10;
A[9][24] = 10;
A[9][25] = 10;
A[9][26] = 10;
A[9][27] = 10;
A[9][28] = 2;
A[9][31] = 10;
A[9][32] = 10;
A[9][33] = 10;
A[9][34] = 3;
A[9][37] = 6;
A[9][39] = 10;
A[9][40] = 10;
A[9][44] = 10;
A[9][45] = 10;
A[9][48] = 10;
A[9][49] = 10;
A[9][55] = 10;
A[9][56] = 10;
A[9][62] = 10;
A[9][63] = 10;
A[10][13] = 10;
A[10][14] = 10;
A[10][22] = 10;
A[10][23] = 10;
A[10][24] = 10;
A[10][25] = 10;
A[10][26] = 10;
A[10][27] = 2;
A[10][31] = 10;
A[10][32] = 10;
A[10][33] = 10;
A[10][34] = 2;
A[10][39] = 10;
A[10][40] = 10;
A[10][44] = 10;
A[10][45] = 10;
A[10][48] = 10;
A[10][49] = 10;
A[10][55] = 10;
A[10][56] = 10;
A[10][62] = 10;
A[10][63] = 10;
A[11][13] = 10;
A[11][14] = 10;
A[11][22] = 10;
A[11][23] = 10;
A[11][25] = 10;
A[11][26] = 10;
A[11][31] = 10;
A[11][32] = 10;
A[11][39] = 10;
A[11][40] = 10;
A[11][44] = 10;
A[11][45] = 2;
A[11][48] = 10;
A[11][49] = 10;
A[11][52] = 6;
A[11][55] = 10;
A[11][56] = 10;
A[11][59] = 9;
A[11][62] = 10;
A[11][63] = 10;
A[11][67] = 9;
A[11][75] = 6;
A[12][13] = 10;
A[12][14] = 10;
A[12][17] = 8;
A[12][22] = 10;
A[12][23] = 10;
A[12][26] = 10;
A[12][27] = 3;
A[12][31] = 10;
A[12][32] = 10;
A[12][39] = 10;
A[12][40] = 10;
A[12][41] = 8;
A[12][44] = 10;
A[12][48] = 10;
A[12][49] = 10;
A[12][55] = 10;
A[12][56] = 10;
A[12][62] = 10;
A[12][63] = 10;
A[13][5] = 9;
A[13][13] = 10;
A[13][14] = 10;
A[13][15] = 10;
A[13][16] = 10;
A[13][17] = 10;
A[13][18] = 10;
A[13][19] = 3;
A[13][22] = 10;
A[13][23] = 10;
A[13][27] = 10;
A[13][28] = 3;
A[13][31] = 10;
A[13][32] = 10;
A[13][33] = 10;
A[13][34] = 10;
A[13][35] = 10;
A[13][36] = 3;
A[13][39] = 10;
A[13][40] = 10;
A[13][41] = 10;
A[13][42] = 10;
A[13][43] = 10;
A[13][44] = 2;
A[13][48] = 10;
A[13][49] = 10;
A[13][55] = 10;
A[13][56] = 10;
A[13][62] = 10;
A[13][63] = 10;
A[14][13] = 1;
A[14][14] = 10;
A[14][15] = 10;
A[14][16] = 10;
A[14][17] = 10;
A[14][18] = 10;
A[14][19] = 2;
A[14][22] = 1;
A[14][23] = 10;
A[14][27] = 1;
A[14][28] = 2;
A[14][31] = 1;
A[14][32] = 10;
A[14][33] = 10;
A[14][34] = 10;
A[14][35] = 10;
A[14][36] = 2;
A[14][39] = 1;
A[14][40] = 10;
A[14][41] = 10;
A[14][42] = 10;
A[14][43] = 2;
A[14][48] = 1;
A[14][49] = 2;
A[14][55] = 1;
A[14][56] = 2;
A[14][62] = 1;
A[14][63] = 2;
A[15][76] = 8;
A[16][33] = 9;
A[17][4] = 6;
A[17][43] = 9;
A[18][21] = 9;
A[18][27] = 6;
A[18][48] = 6;
A[18][61] = 8;
A[18][67] = 6;
A[19][6] = 8;

}

void DISEGNA_CREDITI_TESTUALI_GRAFICA()
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
