
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** HIGH SCORE ***							*
		*																	*
		*	Nome:			HIGH_SCORE_GRAFICO.H							*
		*	Programmato da: Montalbano Marco								*
		*	Grafica di:		Montalbano Marco								*
		*	Genere:			Libreria del gioco (high score grafico)			*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



//Elenco funzioni contenute
	//funzione principale del gioco
		void MOSTRA_HIGH_SCORE_GRAFICO();
	//matrice per la posizione della grafica nel gioco
		void carica_matrice_del_high_score();
	//disegna la grafica del menù
		void DISEGNA_HIGH_SCORE_GRAFICA();


bool high_score_gia_stampato = true;

void MOSTRA_HIGH_SCORE_GRAFICO()
{

	stampa_niente = true;

	if (high_score_gia_stampato == false)
	{

		high_score_gia_stampato = true;

		//Pulisce l'intero schermo
			glClear(GL_COLOR_BUFFER_BIT);
		azzera_matrice();
		DISEGNA_HIGH_SCORE_GRAFICA();
		carica_matrice_del_high_score();
		DISEGNA_HIGH_SCORE_GRAFICA();

		//caricamento dei dati
		typedef struct
		{
			char nome_giocatore[20];	//Nome del giocatore
			int p_personaggio;			//Punteggio del personaggio
			int p_mostro;				//Punteggio del mostro
			int copia_livello;			//Copia del livello
		} punteggi;

		punteggi p_salva;
		long conta_bit = sizeof(punteggi);

		int a = 0, b = 0;			//Variabili x e y della gotoxy
		FILE *file;					//Puntatore al file 'High Score.txt'
		int incremento_max = 0;		//Contatore degli High Score

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

			//Imposta colore
				color(3);
			
			//Scrittura tabella
				printf("|---------------------|------------|------------|-------|\n");
				printf("|        NOME         |  FIVERUN   |   MOSTRI   | LEVEL |\n");
				printf("|---------------------|------------|------------|-------|\n");

			//Caricamento del FILE
			file = fopen("High Score.txt", "a+b");

			//Incrementa volutamente il puntatore di 'sizeof(punteggi)' per controllare
			//il caso della fine del testo
			fread(&p_salva,sizeof(punteggi),1,file);

			while (!(feof(file)))
			{
				//Sposta il puntatore indietro di 'sizeof(punteggi)' posizioni 
				fseek(file,(conta_bit - sizeof(punteggi)),0);

				//Leggi da file e meti i dati in struttura
				fread(&p_salva,sizeof(punteggi),1,file);

				//Leggi da struttura e scrivi a video i dati
				printf("|%20s | %10d | %10d | %5d |\n", &p_salva.nome_giocatore, p_salva.p_personaggio, p_salva.p_mostro, p_salva.copia_livello);

				//Incrementa volutamente il puntatore di 'sizeof(punteggi)' per controllare
				//il caso della fine del testo
				fread(&p_salva,sizeof(punteggi),1,file);

				//Metti in conta_bit la posizione attuale del puntatore
				conta_bit = ftell(file);

				//Aumenta la variabile per lo spostamento nell'High Score
				incremento_max++;

			}

			//Chiusura del FILE
			fclose(file);

			
			//Traccia la fine della tabella
			printf("|---------------------|------------|------------|-------|\n");


		//Movimento all'interno del file
			gotoxy(a,b);
		}
}

void carica_matrice_del_high_score()
{

A[1][29] = 8;
A[2][15] = 9;
A[2][20] = 6;
A[2][32] = 6;
A[2][51] = 9;
A[2][57] = 6;
A[3][2] = 4;
A[3][3] = 3;
A[3][9] = 4;
A[3][10] = 3;
A[3][38] = 4;
A[3][39] = 10;
A[3][40] = 10;
A[3][41] = 10;
A[3][42] = 10;
A[3][43] = 10;
A[3][44] = 3;
A[3][66] = 6;
A[3][74] = 9;
A[4][2] = 10;
A[4][3] = 10;
A[4][9] = 10;
A[4][10] = 10;
A[4][38] = 10;
A[4][39] = 10;
A[4][40] = 10;
A[4][41] = 10;
A[4][42] = 10;
A[4][43] = 10;
A[4][44] = 10;
A[5][2] = 10;
A[5][3] = 10;
A[5][9] = 10;
A[5][10] = 10;
A[5][13] = 4;
A[5][14] = 3;
A[5][17] = 4;
A[5][18] = 10;
A[5][19] = 10;
A[5][20] = 10;
A[5][21] = 10;
A[5][22] = 10;
A[5][23] = 3;
A[5][26] = 4;
A[5][27] = 3;
A[5][31] = 4;
A[5][32] = 3;
A[5][38] = 10;
A[5][39] = 10;
A[5][47] = 4;
A[5][48] = 10;
A[5][49] = 10;
A[5][50] = 10;
A[5][51] = 10;
A[5][52] = 10;
A[5][53] = 3;
A[5][56] = 4;
A[5][57] = 10;
A[5][58] = 10;
A[5][59] = 10;
A[5][60] = 10;
A[5][61] = 3;
A[5][64] = 4;
A[5][65] = 10;
A[5][66] = 10;
A[5][67] = 10;
A[5][68] = 10;
A[5][69] = 3;
A[5][72] = 4;
A[5][73] = 10;
A[5][74] = 10;
A[5][75] = 10;
A[5][76] = 10;
A[5][77] = 3;
A[6][2] = 10;
A[6][3] = 10;
A[6][9] = 10;
A[6][10] = 10;
A[6][13] = 10;
A[6][14] = 10;
A[6][17] = 10;
A[6][18] = 10;
A[6][19] = 10;
A[6][20] = 10;
A[6][21] = 10;
A[6][22] = 10;
A[6][23] = 2;
A[6][26] = 10;
A[6][27] = 10;
A[6][31] = 10;
A[6][32] = 10;
A[6][38] = 10;
A[6][39] = 10;
A[6][42] = 6;
A[6][47] = 10;
A[6][48] = 10;
A[6][49] = 10;
A[6][50] = 10;
A[6][51] = 10;
A[6][52] = 10;
A[6][53] = 10;
A[6][56] = 10;
A[6][57] = 10;
A[6][58] = 10;
A[6][59] = 10;
A[6][60] = 10;
A[6][61] = 10;
A[6][64] = 10;
A[6][65] = 10;
A[6][66] = 10;
A[6][67] = 10;
A[6][68] = 10;
A[6][69] = 10;
A[6][72] = 10;
A[6][73] = 10;
A[6][74] = 10;
A[6][75] = 10;
A[6][76] = 10;
A[6][77] = 2;
A[7][2] = 10;
A[7][3] = 10;
A[7][6] = 9;
A[7][9] = 10;
A[7][10] = 10;
A[7][13] = 10;
A[7][14] = 10;
A[7][17] = 10;
A[7][18] = 10;
A[7][26] = 10;
A[7][27] = 10;
A[7][31] = 10;
A[7][32] = 10;
A[7][38] = 10;
A[7][39] = 10;
A[7][47] = 10;
A[7][48] = 10;
A[7][56] = 10;
A[7][57] = 10;
A[7][60] = 10;
A[7][61] = 10;
A[7][64] = 10;
A[7][65] = 10;
A[7][68] = 10;
A[7][69] = 10;
A[7][72] = 10;
A[7][73] = 10;
A[8][2] = 10;
A[8][3] = 10;
A[8][4] = 10;
A[8][5] = 10;
A[8][6] = 10;
A[8][7] = 10;
A[8][8] = 10;
A[8][9] = 10;
A[8][10] = 10;
A[8][13] = 10;
A[8][14] = 10;
A[8][17] = 10;
A[8][18] = 10;
A[8][23] = 9;
A[8][26] = 10;
A[8][27] = 10;
A[8][31] = 10;
A[8][32] = 10;
A[8][38] = 10;
A[8][39] = 10;
A[8][40] = 10;
A[8][41] = 10;
A[8][42] = 10;
A[8][43] = 10;
A[8][44] = 3;
A[8][47] = 10;
A[8][48] = 10;
A[8][56] = 10;
A[8][57] = 10;
A[8][60] = 10;
A[8][61] = 10;
A[8][64] = 10;
A[8][65] = 10;
A[8][68] = 10;
A[8][69] = 10;
A[8][72] = 10;
A[8][73] = 10;
A[9][2] = 10;
A[9][3] = 10;
A[9][4] = 10;
A[9][5] = 10;
A[9][6] = 10;
A[9][7] = 10;
A[9][8] = 10;
A[9][9] = 10;
A[9][10] = 10;
A[9][13] = 10;
A[9][14] = 10;
A[9][17] = 10;
A[9][18] = 10;
A[9][21] = 4;
A[9][22] = 10;
A[9][23] = 3;
A[9][26] = 10;
A[9][27] = 10;
A[9][28] = 10;
A[9][29] = 10;
A[9][30] = 10;
A[9][31] = 10;
A[9][32] = 10;
A[9][38] = 10;
A[9][39] = 10;
A[9][40] = 10;
A[9][41] = 10;
A[9][42] = 10;
A[9][43] = 10;
A[9][44] = 10;
A[9][47] = 10;
A[9][48] = 10;
A[9][56] = 10;
A[9][57] = 10;
A[9][60] = 10;
A[9][61] = 10;
A[9][64] = 10;
A[9][65] = 10;
A[9][66] = 10;
A[9][67] = 10;
A[9][68] = 10;
A[9][69] = 2;
A[9][72] = 10;
A[9][73] = 10;
A[9][74] = 10;
A[9][75] = 3;
A[9][78] = 6;
A[10][2] = 10;
A[10][3] = 10;
A[10][9] = 10;
A[10][10] = 10;
A[10][13] = 10;
A[10][14] = 10;
A[10][17] = 10;
A[10][18] = 10;
A[10][20] = 7;
A[10][21] = 10;
A[10][22] = 10;
A[10][23] = 10;
A[10][26] = 10;
A[10][27] = 10;
A[10][28] = 10;
A[10][29] = 10;
A[10][30] = 10;
A[10][31] = 10;
A[10][32] = 10;
A[10][43] = 10;
A[10][44] = 10;
A[10][47] = 10;
A[10][48] = 10;
A[10][56] = 10;
A[10][57] = 10;
A[10][60] = 10;
A[10][61] = 10;
A[10][64] = 10;
A[10][65] = 10;
A[10][66] = 10;
A[10][67] = 10;
A[10][72] = 10;
A[10][73] = 10;
A[10][74] = 10;
A[10][75] = 2;
A[11][2] = 10;
A[11][3] = 10;
A[11][9] = 10;
A[11][10] = 10;
A[11][13] = 10;
A[11][14] = 10;
A[11][17] = 10;
A[11][18] = 10;
A[11][23] = 10;
A[11][26] = 10;
A[11][27] = 10;
A[11][31] = 10;
A[11][32] = 10;
A[11][43] = 10;
A[11][44] = 10;
A[11][47] = 10;
A[11][48] = 10;
A[11][56] = 10;
A[11][57] = 10;
A[11][60] = 10;
A[11][61] = 10;
A[11][64] = 10;
A[11][65] = 10;
A[11][67] = 10;
A[11][68] = 3;
A[11][72] = 10;
A[11][73] = 10;
A[12][2] = 10;
A[12][3] = 10;
A[12][9] = 10;
A[12][10] = 10;
A[12][13] = 10;
A[12][14] = 10;
A[12][17] = 10;
A[12][18] = 10;
A[12][23] = 10;
A[12][26] = 10;
A[12][27] = 10;
A[12][31] = 10;
A[12][32] = 10;
A[12][39] = 8;
A[12][43] = 10;
A[12][44] = 10;
A[12][47] = 10;
A[12][48] = 10;
A[12][56] = 10;
A[12][57] = 10;
A[12][59] = 8;
A[12][60] = 10;
A[12][61] = 10;
A[12][64] = 10;
A[12][65] = 10;
A[12][67] = 1;
A[12][68] = 10;
A[12][72] = 10;
A[12][73] = 10;
A[13][2] = 10;
A[13][3] = 10;
A[13][9] = 10;
A[13][10] = 10;
A[13][13] = 10;
A[13][14] = 10;
A[13][17] = 10;
A[13][18] = 10;
A[13][19] = 10;
A[13][20] = 10;
A[13][21] = 10;
A[13][22] = 10;
A[13][23] = 10;
A[13][26] = 10;
A[13][27] = 10;
A[13][31] = 10;
A[13][32] = 10;
A[13][38] = 4;
A[13][39] = 10;
A[13][40] = 10;
A[13][41] = 10;
A[13][42] = 10;
A[13][43] = 10;
A[13][44] = 10;
A[13][47] = 10;
A[13][48] = 10;
A[13][49] = 10;
A[13][50] = 10;
A[13][51] = 10;
A[13][52] = 10;
A[13][53] = 3;
A[13][56] = 10;
A[13][57] = 10;
A[13][58] = 10;
A[13][59] = 10;
A[13][60] = 10;
A[13][61] = 10;
A[13][64] = 10;
A[13][65] = 10;
A[13][68] = 10;
A[13][69] = 3;
A[13][72] = 10;
A[13][73] = 10;
A[13][74] = 10;
A[13][75] = 10;
A[13][76] = 10;
A[13][77] = 3;
A[14][2] = 1;
A[14][3] = 2;
A[14][9] = 1;
A[14][10] = 2;
A[14][13] = 1;
A[14][14] = 2;
A[14][17] = 1;
A[14][18] = 10;
A[14][19] = 10;
A[14][20] = 10;
A[14][21] = 10;
A[14][22] = 10;
A[14][23] = 2;
A[14][26] = 1;
A[14][27] = 10;
A[14][29] = 6;
A[14][31] = 1;
A[14][32] = 2;
A[14][38] = 1;
A[14][39] = 10;
A[14][40] = 10;
A[14][41] = 10;
A[14][42] = 10;
A[14][43] = 10;
A[14][44] = 2;
A[14][47] = 1;
A[14][48] = 10;
A[14][49] = 10;
A[14][50] = 10;
A[14][51] = 10;
A[14][52] = 10;
A[14][53] = 2;
A[14][56] = 1;
A[14][57] = 10;
A[14][58] = 10;
A[14][59] = 10;
A[14][60] = 10;
A[14][61] = 2;
A[14][64] = 1;
A[14][65] = 2;
A[14][68] = 1;
A[14][69] = 2;
A[14][72] = 1;
A[14][73] = 10;
A[14][74] = 10;
A[14][75] = 10;
A[14][76] = 10;
A[14][77] = 2;
A[17][27] = 9;
A[17][54] = 6;
A[17][64] = 8;
A[18][2] = 9;
A[18][9] = 6;
A[18][13] = 8;
A[18][77] = 9;
A[19][37] = 6;
A[19][49] = 9;
A[20][67] = 6;

}

void DISEGNA_HIGH_SCORE_GRAFICA()
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
