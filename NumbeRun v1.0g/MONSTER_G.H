
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** MONSTER ***							*
		*																	*
		*	Nome:			MONSTER.H										*
		*	Programmato da: Montalbano Marco & Brambilla Giacomo			*
		*	Genere:			Libreria del gioco (gestione eventi dei mostri)	*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/



//Elenco funzioni contenute
void controllo_mostri_nel_gioco();
void controllo_collisione_con_mostro();
void controlla_punteggio_mostri();
void mov_mostro8_1();
void mov_mostro8_2();
void mov_mostro8_3();
void mov_mostro8_4();
void mov_mostro8_5();
void mov_mostro8_6();
void mov_mostro8_7();
void mov_mostro8_8();
void mov_mostro8_9();
void mov_mostro8_10();
void mov_mostro8_11();
void mov_mostro8_12();
void mov_mostro8_13();
void mov_mostro8_14();
void mov_mostro8_15();
void mov_mostro8_16();
void mov_mostro8_17();
void mov_mostro8_18();
void mov_mostro8_19();
void mov_mostro8_20();
void mov_mostro8_21();
void mov_mostro8_22();
void mov_mostro8_23();
void mov_mostro8_24();
void mov_mostro8_25();



//Dichiarazione delle varibili globali del mostro
int mostri;				//Numero dei mostri della mappa in questione

int o1, k1;				//Posizione 1a mostro
int o2, k2;				//Posizione 2a mostro
int o3, k3;				//Posizione 3a mostro
int o4, k4;				//Posizione 4a mostro
int o5, k5;				//Posizione 5a mostro
int o6, k6;				//Posizione 6a mostro
int o7, k7;				//Posizione 7a mostro
int o8, k8;				//Posizione 8a mostro
int o9, k9;				//Posizione 9a mostro
int o10, k10;				//Posizione 10a mostro
int o11, k11;				//Posizione 11a mostro
int o12, k12;				//Posizione 12a mostro
int o13, k13;				//Posizione 13a mostro
int o14, k14;				//Posizione 14a mostro
int o15, k15;				//Posizione 15a mostro
int o16, k16;				//Posizione 16a mostro
int o17, k17;				//Posizione 17a mostro
int o18, k18;				//Posizione 18a mostro
int o19, k19;				//Posizione 19a mostro
int o20, k20;				//Posizione 20a mostro
int o21, k21;				//Posizione 21a mostro
int o22, k22;				//Posizione 22a mostro
int o23, k23;				//Posizione 23a mostro
int o24, k24;				//Posizione 24a mostro
int o25, k25;				//Posizione 25a mostro

//Controlla quanti saranno i mostri usati nel livello selezionato
void controllo_mostri_nel_gioco()
{
	//Gestione del movimento mostri nella mappa
	if (mostri == 1)
	{
		mov_mostro8_1();
	}
	if (mostri == 2)
	{
		mov_mostro8_1();
		mov_mostro8_2();
	}
	if (mostri == 3)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
	}
	if (mostri == 4)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
	}
	if (mostri == 5)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
	}
	if (mostri == 6)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
	}
	if (mostri == 7)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
	}
	if (mostri == 8)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
	}
	if (mostri == 9)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
	}
	if (mostri == 10)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
	}
	if (mostri == 11)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
	}
	if (mostri == 12)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
	}
	if (mostri == 13)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
	}
	if (mostri == 14)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
	}
	if (mostri == 15)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
	}
	if (mostri == 16)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
	}
	if (mostri == 17)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
	}
	if (mostri == 18)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
	}
	if (mostri == 19)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
	}
	if (mostri == 20)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
	}
	if (mostri == 21)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
		mov_mostro8_21();
	}
	if (mostri == 22)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
		mov_mostro8_21();
		mov_mostro8_22();
	}
	if (mostri == 23)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
		mov_mostro8_21();
		mov_mostro8_22();
		mov_mostro8_23();
	}
	if (mostri == 24)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
		mov_mostro8_21();
		mov_mostro8_22();
		mov_mostro8_23();
		mov_mostro8_24();
	}
	if (mostri == 25)
	{
		mov_mostro8_1();
		mov_mostro8_2();
		mov_mostro8_3();
		mov_mostro8_4();
		mov_mostro8_5();
		mov_mostro8_6();
		mov_mostro8_7();
		mov_mostro8_8();
		mov_mostro8_9();
		mov_mostro8_10();
		mov_mostro8_11();
		mov_mostro8_12();
		mov_mostro8_13();
		mov_mostro8_14();
		mov_mostro8_15();
		mov_mostro8_16();
		mov_mostro8_17();
		mov_mostro8_18();
		mov_mostro8_19();
		mov_mostro8_20();
		mov_mostro8_21();
		mov_mostro8_22();
		mov_mostro8_23();
		mov_mostro8_24();
		mov_mostro8_25();
	}
}

//Gestione delle collisioni del personaggio con i mostri
void controllo_collisione_con_mostro()
{
	if (((i == o1) && (j == k1)) && (god_mode == false))
		collisione = true;
	if (((i == o2) && (j == k2)) && (god_mode == false))
		collisione = true;
	if (((i == o3) && (j == k3)) && (god_mode == false))
		collisione = true;
	if (((i == o4) && (j == k4)) && (god_mode == false))
		collisione = true;
	if (((i == o5) && (j == k5)) && (god_mode == false))
		collisione = true;
	if (((i == o6) && (j == k6)) && (god_mode == false))
		collisione = true;
	if (((i == o7) && (j == k7)) && (god_mode == false))
		collisione = true;
	if (((i == o8) && (j == k8)) && (god_mode == false))
		collisione = true;
	if (((i == o9) && (j == k9)) && (god_mode == false))
		collisione = true;
	if (((i == o10) && (j == k10)) && (god_mode == false))
		collisione = true;
	if (((i == o11) && (j == k11)) && (god_mode == false))
		collisione = true;
	if (((i == o12) && (j == k12)) && (god_mode == false))
		collisione = true;
	if (((i == o13) && (j == k13)) && (god_mode == false))
		collisione = true;
	if (((i == o14) && (j == k14)) && (god_mode == false))
		collisione = true;
	if (((i == o15) && (j == k15)) && (god_mode == false))
		collisione = true;
	if (((i == o16) && (j == k16)) && (god_mode == false))
		collisione = true;
	if (((i == o17) && (j == k17)) && (god_mode == false))
		collisione = true;
	if (((i == o18) && (j == k18)) && (god_mode == false))
		collisione = true;
	if (((i == o19) && (j == k19)) && (god_mode == false))
		collisione = true;
	if (((i == o20) && (j == k20)) && (god_mode == false))
		collisione = true;
	if (((i == o21) && (j == k21)) && (god_mode == false))
		collisione = true;
	if (((i == o22) && (j == k22)) && (god_mode == false))
		collisione = true;
	if (((i == o23) && (j == k23)) && (god_mode == false))
		collisione = true;
	if (((i == o24) && (j == k24)) && (god_mode == false))
		collisione = true;
	if (((i == o25) && (j == k25)) && (god_mode == false))
		collisione = true;
}

//Punteggio dei mostri
void controlla_punteggio_mostri()
{
	if (A[o1][k1] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o2][k2] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o3][k3] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o4][k4] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o5][k5] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o6][k6] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o7][k7] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o8][k8] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o9][k9] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o10][k10] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o11][k11] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o12][k12] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o13][k13] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o14][k14] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o15][k15] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o16][k16] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o17][k17] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o18][k18] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o19][k19] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o20][k20] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o21][k21] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o22][k22] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o23][k23] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o24][k24] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
	if (A[o25][k25] == 2)
	{
		//Aggiornamento punteggi
		disegna_statistiche = true;
		score_m = score_m + 10;
		scoreTOT_m = scoreTOT_m + 10;
	}
}

//{Movimento del mostro (8) 1}
void mov_mostro8_1()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o1][k1] = 0;
			o1--;
			//Caso collisione muro
			if (A[o1][k1] == 7)
				o1++;
			//Caso di collizione personaggio
			if ((A[o1][k1] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o1][k1] == 1)
				o1++;
			//Caso di collizione fine gioco
			if (A[o1][k1] == 9)
				o1++;
			//Caso di collizione crystal potion
			if (A[o1][k1] == 3)
				o1++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o1][k1] = 0;
			o1++;
			//Caso collisione muro
			if (A[o1][k1] == 7)
				o1--;
			//Caso di collizione personaggio
			if ((A[o1][k1] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o1][k1] == 1)
				o1--;
			//Caso di collizione fine gioco
			if (A[o1][k1] == 9)
				o1--;
			//Caso di collizione crystal potion
			if (A[o1][k1] == 3)
				o1--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o1][k1] = 0;
			k1++;
			//Caso collisione muro
			if (A[o1][k1] == 7)
				k1--;
			//Caso di collizione personaggio
			if ((A[o1][k1] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o1][k1] == 1)
				k1--;
			//Caso di collizione fine gioco
			if (A[o1][k1] == 9)
				k1--;
			//Caso di collizione crystal potion
			if (A[o1][k1] == 3)
				k1--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o1][k1] = 0;
			k1--;
			//Caso collisione muro
			if (A[o1][k1] == 7)
				k1++;
			//Caso di collizione personaggio
			if ((A[o1][k1] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o1][k1] == 1)
				k1++;
			//Caso di collizione fine gioco
			if (A[o1][k1] == 9)
				k1++;
			//Caso di collizione crystal potion
			if (A[o1][k1] == 3)
				k1++;

			break;
		}
	}
	punteggio();
	A[o1][k1] = 8;
	Disegna_Veloce(o1,k1);
}

//{Movimento del mostro (8) 2}
void mov_mostro8_2()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o2][k2] = 0;
			o2--;
			//Caso collisione muro
			if (A[o2][k2] == 7)
				o2++;
			//Caso di collizione personaggio
			if ((A[o2][k2] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o2][k2] == 1)
				o2++;
			//Caso di collizione fine gioco
			if (A[o2][k2] == 9)
				o2++;
			//Caso di collizione crystal potion
			if (A[o2][k2] == 3)
				o2++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o2][k2] = 0;
			o2++;
			//Caso collisione muro
			if (A[o2][k2] == 7)
				o2--;
			//Caso di collizione personaggio
			if ((A[o2][k2] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o2][k2] == 1)
				o2--;
			//Caso di collizione fine gioco
			if (A[o2][k2] == 9)
				o2--;
			//Caso di collizione crystal potion
			if (A[o2][k2] == 3)
				o2--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o2][k2] = 0;
			k2++;
			//Caso collisione muro
			if (A[o2][k2] == 7)
				k2--;
			//Caso di collizione personaggio
			if ((A[o2][k2] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o2][k2] == 1)
				k2--;
			//Caso di collizione fine gioco
			if (A[o2][k2] == 9)
				k2--;
			//Caso di collizione crystal potion
			if (A[o2][k2] == 3)
				k2--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o2][k2] = 0;
			k2--;
			//Caso collisione muro
			if (A[o2][k2] == 7)
				k2++;
			//Caso di collizione personaggio
			if ((A[o2][k2] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o2][k2] == 1)
				k2++;
			//Caso di collizione fine gioco
			if (A[o2][k2] == 9)
				k2++;
			//Caso di collizione crystal potion
			if (A[o2][k2] == 3)
				k2++;

			break;
		}
	}
	punteggio();
	A[o2][k2] = 8;
	Disegna_Veloce(o2,k2);
}

//{Movimento del mostro (8) 3}
void mov_mostro8_3()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o3][k3] = 0;
			o3--;
			//Caso collisione muro
			if (A[o3][k3] == 7)
				o3++;
			//Caso di collizione personaggio
			if ((A[o3][k3] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o3][k3] == 1)
				o3++;
			//Caso di collizione fine gioco
			if (A[o3][k3] == 9)
				o3++;
			//Caso di collizione crystal potion
			if (A[o3][k3] == 3)
				o3++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o3][k3] = 0;
			o3++;
			//Caso collisione muro
			if (A[o3][k3] == 7)
				o3--;
			//Caso di collizione personaggio
			if ((A[o3][k3] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o3][k3] == 1)
				o3--;
			//Caso di collizione fine gioco
			if (A[o3][k3] == 9)
				o3--;
			//Caso di collizione crystal potion
			if (A[o3][k3] == 3)
				o3--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o3][k3] = 0;
			k3++;
			//Caso collisione muro
			if (A[o3][k3] == 7)
				k3--;
			//Caso di collizione personaggio
			if ((A[o3][k3] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o3][k3] == 1)
				k3--;
			//Caso di collizione fine gioco
			if (A[o3][k3] == 9)
				k3--;
			//Caso di collizione crystal potion
			if (A[o3][k3] == 3)
				k3--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o3][k3] = 0;
			k3--;
			//Caso collisione muro
			if (A[o3][k3] == 7)
				k3++;
			//Caso di collizione personaggio
			if ((A[o3][k3] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o3][k3] == 1)
				k3++;
			//Caso di collizione fine gioco
			if (A[o3][k3] == 9)
				k3++;
			//Caso di collizione crystal potion
			if (A[o3][k3] == 3)
				k3++;

			break;
		}
	}
	punteggio();
	A[o3][k3] = 8;
	Disegna_Veloce(o3,k3);
}

//{Movimento del mostro (8) 4}
void mov_mostro8_4()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o4][k4] = 0;
			o4--;
			//Caso collisione muro
			if (A[o4][k4] == 7)
				o4++;
			//Caso di collizione personaggio
			if ((A[o4][k4] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o4][k4] == 1)
				o4++;
			//Caso di collizione fine gioco
			if (A[o4][k4] == 9)
				o4++;
			//Caso di collizione crystal potion
			if (A[o4][k4] == 3)
				o4++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o4][k4] = 0;
			o4++;
			//Caso collisione muro
			if (A[o4][k4] == 7)
				o4--;
			//Caso di collizione personaggio
			if ((A[o4][k4] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o4][k4] == 1)
				o4--;
			//Caso di collizione fine gioco
			if (A[o4][k4] == 9)
				o4--;
			//Caso di collizione crystal potion
			if (A[o4][k4] == 3)
				o4--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o4][k4] = 0;
			k4++;
			//Caso collisione muro
			if (A[o4][k4] == 7)
				k4--;
			//Caso di collizione personaggio
			if ((A[o4][k4] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o4][k4] == 1)
				k4--;
			//Caso di collizione fine gioco
			if (A[o4][k4] == 9)
				k4--;
			//Caso di collizione crystal potion
			if (A[o4][k4] == 3)
				k4--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o4][k4] = 0;
			k4--;
			//Caso collisione muro
			if (A[o4][k4] == 7)
				k4++;
			//Caso di collizione personaggio
			if ((A[o4][k4] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o4][k4] == 1)
				k4++;
			//Caso di collizione fine gioco
			if (A[o4][k4] == 9)
				k4++;
			//Caso di collizione crystal potion
			if (A[o4][k4] == 3)
				k4++;

			break;
		}
	}
	punteggio();
	A[o4][k4] = 8;
	Disegna_Veloce(o4,k4);
}

//{Movimento del mostro (8) 5}
void mov_mostro8_5()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o5][k5] = 0;
			o5--;
			//Caso collisione muro
			if (A[o5][k5] == 7)
				o5++;
			//Caso di collizione personaggio
			if ((A[o5][k5] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o5][k5] == 1)
				o5++;
			//Caso di collizione fine gioco
			if (A[o5][k5] == 9)
				o5++;
			//Caso di collizione crystal potion
			if (A[o5][k5] == 3)
				o5++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o5][k5] = 0;
			o5++;
			//Caso collisione muro
			if (A[o5][k5] == 7)
				o5--;
			//Caso di collizione personaggio
			if ((A[o5][k5] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o5][k5] == 1)
				o5--;
			//Caso di collizione fine gioco
			if (A[o5][k5] == 9)
				o5--;
			//Caso di collizione crystal potion
			if (A[o5][k5] == 3)
				o5--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o5][k5] = 0;
			k5++;
			//Caso collisione muro
			if (A[o5][k5] == 7)
				k5--;
			//Caso di collizione personaggio
			if ((A[o5][k5] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o5][k5] == 1)
				k5--;
			//Caso di collizione fine gioco
			if (A[o5][k5] == 9)
				k5--;
			//Caso di collizione crystal potion
			if (A[o5][k5] == 3)
				k5--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o5][k5] = 0;
			k5--;
			//Caso collisione muro
			if (A[o5][k5] == 7)
				k5++;
			//Caso di collizione personaggio
			if ((A[o5][k5] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o5][k5] == 1)
				k5++;
			//Caso di collizione fine gioco
			if (A[o5][k5] == 9)
				k5++;
			//Caso di collizione crystal potion
			if (A[o5][k5] == 3)
				k5++;

			break;
		}
	}
	punteggio();
	A[o5][k5] = 8;
	Disegna_Veloce(o5,k5);
}

//{Movimento del mostro (8) 6}
void mov_mostro8_6()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o6][k6] = 0;
			o6--;
			//Caso collisione muro
			if (A[o6][k6] == 7)
				o6++;
			//Caso di collizione personaggio
			if ((A[o6][k6] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o6][k6] == 1)
				o6++;
			//Caso di collizione fine gioco
			if (A[o6][k6] == 9)
				o6++;
			//Caso di collizione crystal potion
			if (A[o6][k6] == 3)
				o6++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o6][k6] = 0;
			o6++;
			//Caso collisione muro
			if (A[o6][k6] == 7)
				o6--;
			//Caso di collizione personaggio
			if ((A[o6][k6] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o6][k6] == 1)
				o6--;
			//Caso di collizione fine gioco
			if (A[o6][k6] == 9)
				o6--;
			//Caso di collizione crystal potion
			if (A[o6][k6] == 3)
				o6--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o6][k6] = 0;
			k6++;
			//Caso collisione muro
			if (A[o6][k6] == 7)
				k6--;
			//Caso di collizione personaggio
			if ((A[o6][k6] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o6][k6] == 1)
				k6--;
			//Caso di collizione fine gioco
			if (A[o6][k6] == 9)
				k6--;
			//Caso di collizione crystal potion
			if (A[o6][k6] == 3)
				k6--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o6][k6] = 0;
			k6--;
			//Caso collisione muro
			if (A[o6][k6] == 7)
				k6++;
			//Caso di collizione personaggio
			if ((A[o6][k6] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o6][k6] == 1)
				k6++;
			//Caso di collizione fine gioco
			if (A[o6][k6] == 9)
				k6++;
			//Caso di collizione crystal potion
			if (A[o6][k6] == 3)
				k6++;

			break;
		}
	}
	punteggio();
	A[o6][k6] = 8;
	Disegna_Veloce(o6,k6);
}

//{Movimento del mostro (8) 7}
void mov_mostro8_7()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o7][k7] = 0;
			o7--;
			//Caso collisione muro
			if (A[o7][k7] == 7)
				o7++;
			//Caso di collizione personaggio
			if ((A[o7][k7] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o7][k7] == 1)
				o7++;
			//Caso di collizione fine gioco
			if (A[o7][k7] == 9)
				o7++;
			//Caso di collizione crystal potion
			if (A[o7][k7] == 3)
				o7++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o7][k7] = 0;
			o7++;
			//Caso collisione muro
			if (A[o7][k7] == 7)
				o7--;
			//Caso di collizione personaggio
			if ((A[o7][k7] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o7][k7] == 1)
				o7--;
			//Caso di collizione fine gioco
			if (A[o7][k7] == 9)
				o7--;
			//Caso di collizione crystal potion
			if (A[o7][k7] == 3)
				o7--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o7][k7] = 0;
			k7++;
			//Caso collisione muro
			if (A[o7][k7] == 7)
				k7--;
			//Caso di collizione personaggio
			if ((A[o7][k7] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o7][k7] == 1)
				k7--;
			//Caso di collizione fine gioco
			if (A[o7][k7] == 9)
				k7--;
			//Caso di collizione crystal potion
			if (A[o7][k7] == 3)
				k7--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o7][k7] = 0;
			k7--;
			//Caso collisione muro
			if (A[o7][k7] == 7)
				k7++;
			//Caso di collizione personaggio
			if ((A[o7][k7] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o7][k7] == 1)
				k7++;
			//Caso di collizione fine gioco
			if (A[o7][k7] == 9)
				k7++;
			//Caso di collizione crystal potion
			if (A[o7][k7] == 3)
				k7++;

			break;
		}
	}
	punteggio();
	A[o7][k7] = 8;
	Disegna_Veloce(o7,k7);
}

//{Movimento del mostro (8) 8}
void mov_mostro8_8()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o8][k8] = 0;
			o8--;
			//Caso collisione muro
			if (A[o8][k8] == 7)
				o8++;
			//Caso di collizione personaggio
			if ((A[o8][k8] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o8][k8] == 1)
				o8++;
			//Caso di collizione fine gioco
			if (A[o8][k8] == 9)
				o8++;
			//Caso di collizione crystal potion
			if (A[o8][k8] == 3)
				o8++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o8][k8] = 0;
			o8++;
			//Caso collisione muro
			if (A[o8][k8] == 7)
				o8--;
			//Caso di collizione personaggio
			if ((A[o8][k8] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o8][k8] == 1)
				o8--;
			//Caso di collizione fine gioco
			if (A[o8][k8] == 9)
				o8--;
			//Caso di collizione crystal potion
			if (A[o8][k8] == 3)
				o8--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o8][k8] = 0;
			k8++;
			//Caso collisione muro
			if (A[o8][k8] == 7)
				k8--;
			//Caso di collizione personaggio
			if ((A[o8][k8] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o8][k8] == 1)
				k8--;
			//Caso di collizione fine gioco
			if (A[o8][k8] == 9)
				k8--;
			//Caso di collizione crystal potion
			if (A[o8][k8] == 3)
				k8--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o8][k8] = 0;
			k8--;
			//Caso collisione muro
			if (A[o8][k8] == 7)
				k8++;
			//Caso di collizione personaggio
			if ((A[o8][k8] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o8][k8] == 1)
				k8++;
			//Caso di collizione fine gioco
			if (A[o8][k8] == 9)
				k8++;
			//Caso di collizione crystal potion
			if (A[o8][k8] == 3)
				k8++;

			break;
		}
	}
	punteggio();
	A[o8][k8] = 8;
	Disegna_Veloce(o8,k8);
}

//{Movimento del mostro (8) 9}
void mov_mostro8_9()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o9][k9] = 0;
			o9--;
			//Caso collisione muro
			if (A[o9][k9] == 7)
				o9++;
			//Caso di collizione personaggio
			if ((A[o9][k9] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o9][k9] == 1)
				o9++;
			//Caso di collizione fine gioco
			if (A[o9][k9] == 9)
				o9++;
			//Caso di collizione crystal potion
			if (A[o9][k9] == 3)
				o9++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o9][k9] = 0;
			o9++;
			//Caso collisione muro
			if (A[o9][k9] == 7)
				o9--;
			//Caso di collizione personaggio
			if ((A[o9][k9] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o9][k9] == 1)
				o9--;
			//Caso di collizione fine gioco
			if (A[o9][k9] == 9)
				o9--;
			//Caso di collizione crystal potion
			if (A[o9][k9] == 3)
				o9--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o9][k9] = 0;
			k9++;
			//Caso collisione muro
			if (A[o9][k9] == 7)
				k9--;
			//Caso di collizione personaggio
			if ((A[o9][k9] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o9][k9] == 1)
				k9--;
			//Caso di collizione fine gioco
			if (A[o9][k9] == 9)
				k9--;
			//Caso di collizione crystal potion
			if (A[o9][k9] == 3)
				k9--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o9][k9] = 0;
			k9--;
			//Caso collisione muro
			if (A[o9][k9] == 7)
				k9++;
			//Caso di collizione personaggio
			if ((A[o9][k9] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o9][k9] == 1)
				k9++;
			//Caso di collizione fine gioco
			if (A[o9][k9] == 9)
				k9++;
			//Caso di collizione crystal potion
			if (A[o9][k9] == 3)
				k9++;

			break;
		}
	}
	punteggio();
	A[o9][k9] = 8;
	Disegna_Veloce(o9,k9);
}

//{Movimento del mostro (8) 10}
void mov_mostro8_10()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o10][k10] = 0;
			o10--;
			//Caso collisione muro
			if (A[o10][k10] == 7)
				o10++;
			//Caso di collizione personaggio
			if ((A[o10][k10] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o10][k10] == 1)
				o10++;
			//Caso di collizione fine gioco
			if (A[o10][k10] == 9)
				o10++;
			//Caso di collizione crystal potion
			if (A[o10][k10] == 3)
				o10++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o10][k10] = 0;
			o10++;
			//Caso collisione muro
			if (A[o10][k10] == 7)
				o10--;
			//Caso di collizione personaggio
			if ((A[o10][k10] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o10][k10] == 1)
				o10--;
			//Caso di collizione fine gioco
			if (A[o10][k10] == 9)
				o10--;
			//Caso di collizione crystal potion
			if (A[o10][k10] == 3)
				o10--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o10][k10] = 0;
			k10++;
			//Caso collisione muro
			if (A[o10][k10] == 7)
				k10--;
			//Caso di collizione personaggio
			if ((A[o10][k10] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o10][k10] == 1)
				k10--;
			//Caso di collizione fine gioco
			if (A[o10][k10] == 9)
				k10--;
			//Caso di collizione crystal potion
			if (A[o10][k10] == 3)
				k10--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o10][k10] = 0;
			k10--;
			//Caso collisione muro
			if (A[o10][k10] == 7)
				k10++;
			//Caso di collizione personaggio
			if ((A[o10][k10] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o10][k10] == 1)
				k10++;
			//Caso di collizione fine gioco
			if (A[o10][k10] == 9)
				k10++;
			//Caso di collizione crystal potion
			if (A[o10][k10] == 3)
				k10++;

			break;
		}
	}
	punteggio();
	A[o10][k10] = 8;
	Disegna_Veloce(o10,k10);
}

//{Movimento del mostro (8) 11}
void mov_mostro8_11()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o11][k11] = 0;
			o11--;
			//Caso collisione muro
			if (A[o11][k11] == 7)
				o11++;
			//Caso di collizione personaggio
			if ((A[o11][k11] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o11][k11] == 1)
				o11++;
			//Caso di collizione fine gioco
			if (A[o11][k11] == 9)
				o11++;
			//Caso di collizione crystal potion
			if (A[o11][k11] == 3)
				o11++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o11][k11] = 0;
			o11++;
			//Caso collisione muro
			if (A[o11][k11] == 7)
				o11--;
			//Caso di collizione personaggio
			if ((A[o11][k11] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o11][k11] == 1)
				o11--;
			//Caso di collizione fine gioco
			if (A[o11][k11] == 9)
				o11--;
			//Caso di collizione crystal potion
			if (A[o11][k11] == 3)
				o11--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o11][k11] = 0;
			k11++;
			//Caso collisione muro
			if (A[o11][k11] == 7)
				k11--;
			//Caso di collizione personaggio
			if ((A[o11][k11] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o11][k11] == 1)
				k11--;
			//Caso di collizione fine gioco
			if (A[o11][k11] == 9)
				k11--;
			//Caso di collizione crystal potion
			if (A[o11][k11] == 3)
				k11--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o11][k11] = 0;
			k11--;
			//Caso collisione muro
			if (A[o11][k11] == 7)
				k11++;
			//Caso di collizione personaggio
			if ((A[o11][k11] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o11][k11] == 1)
				k11++;
			//Caso di collizione fine gioco
			if (A[o11][k11] == 9)
				k11++;
			//Caso di collizione crystal potion
			if (A[o11][k11] == 3)
				k11++;

			break;
		}
	}
	punteggio();
	A[o11][k11] = 8;
	Disegna_Veloce(o11,k11);
}

//{Movimento del mostro (8) 12}
void mov_mostro8_12()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o12][k12] = 0;
			o12--;
			//Caso collisione muro
			if (A[o12][k12] == 7)
				o12++;
			//Caso di collizione personaggio
			if ((A[o12][k12] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o12][k12] == 1)
				o12++;
			//Caso di collizione fine gioco
			if (A[o12][k12] == 9)
				o12++;
			//Caso di collizione crystal potion
			if (A[o12][k12] == 3)
				o12++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o12][k12] = 0;
			o12++;
			//Caso collisione muro
			if (A[o12][k12] == 7)
				o12--;
			//Caso di collizione personaggio
			if ((A[o12][k12] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o12][k12] == 1)
				o12--;
			//Caso di collizione fine gioco
			if (A[o12][k12] == 9)
				o12--;
			//Caso di collizione crystal potion
			if (A[o12][k12] == 3)
				o12--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o12][k12] = 0;
			k12++;
			//Caso collisione muro
			if (A[o12][k12] == 7)
				k12--;
			//Caso di collizione personaggio
			if ((A[o12][k12] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o12][k12] == 1)
				k12--;
			//Caso di collizione fine gioco
			if (A[o12][k12] == 9)
				k12--;
			//Caso di collizione crystal potion
			if (A[o12][k12] == 3)
				k12--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o12][k12] = 0;
			k12--;
			//Caso collisione muro
			if (A[o12][k12] == 7)
				k12++;
			//Caso di collizione personaggio
			if ((A[o12][k12] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o12][k12] == 1)
				k12++;
			//Caso di collizione fine gioco
			if (A[o12][k12] == 9)
				k12++;
			//Caso di collizione crystal potion
			if (A[o12][k12] == 3)
				k12++;

			break;
		}
	}
	punteggio();
	A[o12][k12] = 8;
	Disegna_Veloce(o12,k12);
}

//{Movimento del mostro (8) 13}
void mov_mostro8_13()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o13][k13] = 0;
			o13--;
			//Caso collisione muro
			if (A[o13][k13] == 7)
				o13++;
			//Caso di collizione personaggio
			if ((A[o13][k13] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o13][k13] == 1)
				o13++;
			//Caso di collizione fine gioco
			if (A[o13][k13] == 9)
				o13++;
			//Caso di collizione crystal potion
			if (A[o13][k13] == 3)
				o13++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o13][k13] = 0;
			o13++;
			//Caso collisione muro
			if (A[o13][k13] == 7)
				o13--;
			//Caso di collizione personaggio
			if ((A[o13][k13] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o13][k13] == 1)
				o13--;
			//Caso di collizione fine gioco
			if (A[o13][k13] == 9)
				o13--;
			//Caso di collizione crystal potion
			if (A[o13][k13] == 3)
				o13--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o13][k13] = 0;
			k13++;
			//Caso collisione muro
			if (A[o13][k13] == 7)
				k13--;
			//Caso di collizione personaggio
			if ((A[o13][k13] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o13][k13] == 1)
				k13--;
			//Caso di collizione fine gioco
			if (A[o13][k13] == 9)
				k13--;
			//Caso di collizione crystal potion
			if (A[o13][k13] == 3)
				k13--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o13][k13] = 0;
			k13--;
			//Caso collisione muro
			if (A[o13][k13] == 7)
				k13++;
			//Caso di collizione personaggio
			if ((A[o13][k13] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o13][k13] == 1)
				k13++;
			//Caso di collizione fine gioco
			if (A[o13][k13] == 9)
				k13++;
			//Caso di collizione crystal potion
			if (A[o13][k13] == 3)
				k13++;

			break;
		}
	}
	punteggio();
	A[o13][k13] = 8;
	Disegna_Veloce(o13,k13);
}

//{Movimento del mostro (8) 14}
void mov_mostro8_14()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o14][k14] = 0;
			o14--;
			//Caso collisione muro
			if (A[o14][k14] == 7)
				o14++;
			//Caso di collizione personaggio
			if ((A[o14][k14] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o14][k14] == 1)
				o14++;
			//Caso di collizione fine gioco
			if (A[o14][k14] == 9)
				o14++;
			//Caso di collizione crystal potion
			if (A[o14][k14] == 3)
				o14++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o14][k14] = 0;
			o14++;
			//Caso collisione muro
			if (A[o14][k14] == 7)
				o14--;
			//Caso di collizione personaggio
			if ((A[o14][k14] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o14][k14] == 1)
				o14--;
			//Caso di collizione fine gioco
			if (A[o14][k14] == 9)
				o14--;
			//Caso di collizione crystal potion
			if (A[o14][k14] == 3)
				o14--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o14][k14] = 0;
			k14++;
			//Caso collisione muro
			if (A[o14][k14] == 7)
				k14--;
			//Caso di collizione personaggio
			if ((A[o14][k14] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o14][k14] == 1)
				k14--;
			//Caso di collizione fine gioco
			if (A[o14][k14] == 9)
				k14--;
			//Caso di collizione crystal potion
			if (A[o14][k14] == 3)
				k14--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o14][k14] = 0;
			k14--;
			//Caso collisione muro
			if (A[o14][k14] == 7)
				k14++;
			//Caso di collizione personaggio
			if ((A[o14][k14] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o14][k14] == 1)
				k14++;
			//Caso di collizione fine gioco
			if (A[o14][k14] == 9)
				k14++;
			//Caso di collizione crystal potion
			if (A[o14][k14] == 3)
				k14++;

			break;
		}
	}
	punteggio();
	A[o14][k14] = 8;
	Disegna_Veloce(o14,k14);
}

//{Movimento del mostro (8) 15}
void mov_mostro8_15()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o15][k15] = 0;
			o15--;
			//Caso collisione muro
			if (A[o15][k15] == 7)
				o15++;
			//Caso di collizione personaggio
			if ((A[o15][k15] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o15][k15] == 1)
				o15++;
			//Caso di collizione fine gioco
			if (A[o15][k15] == 9)
				o15++;
			//Caso di collizione crystal potion
			if (A[o15][k15] == 3)
				o15++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o15][k15] = 0;
			o15++;
			//Caso collisione muro
			if (A[o15][k15] == 7)
				o15--;
			//Caso di collizione personaggio
			if ((A[o15][k15] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o15][k15] == 1)
				o15--;
			//Caso di collizione fine gioco
			if (A[o15][k15] == 9)
				o15--;
			//Caso di collizione crystal potion
			if (A[o15][k15] == 3)
				o15--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o15][k15] = 0;
			k15++;
			//Caso collisione muro
			if (A[o15][k15] == 7)
				k15--;
			//Caso di collizione personaggio
			if ((A[o15][k15] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o15][k15] == 1)
				k15--;
			//Caso di collizione fine gioco
			if (A[o15][k15] == 9)
				k15--;
			//Caso di collizione crystal potion
			if (A[o15][k15] == 3)
				k15--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o15][k15] = 0;
			k15--;
			//Caso collisione muro
			if (A[o15][k15] == 7)
				k15++;
			//Caso di collizione personaggio
			if ((A[o15][k15] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o15][k15] == 1)
				k15++;
			//Caso di collizione fine gioco
			if (A[o15][k15] == 9)
				k15++;
			//Caso di collizione crystal potion
			if (A[o15][k15] == 3)
				k15++;

			break;
		}
	}
	punteggio();
	A[o15][k15] = 8;
	Disegna_Veloce(o15,k15);
}

//{Movimento del mostro (8) 16}
void mov_mostro8_16()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o16][k16] = 0;
			o16--;
			//Caso collisione muro
			if (A[o16][k16] == 7)
				o16++;
			//Caso di collizione personaggio
			if ((A[o16][k16] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o16][k16] == 1)
				o16++;
			//Caso di collizione fine gioco
			if (A[o16][k16] == 9)
				o16++;
			//Caso di collizione crystal potion
			if (A[o16][k16] == 3)
				o16++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o16][k16] = 0;
			o16++;
			//Caso collisione muro
			if (A[o16][k16] == 7)
				o16--;
			//Caso di collizione personaggio
			if ((A[o16][k16] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o16][k16] == 1)
				o16--;
			//Caso di collizione fine gioco
			if (A[o16][k16] == 9)
				o16--;
			//Caso di collizione crystal potion
			if (A[o16][k16] == 3)
				o16--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o16][k16] = 0;
			k16++;
			//Caso collisione muro
			if (A[o16][k16] == 7)
				k16--;
			//Caso di collizione personaggio
			if ((A[o16][k16] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o16][k16] == 1)
				k16--;
			//Caso di collizione fine gioco
			if (A[o16][k16] == 9)
				k16--;
			//Caso di collizione crystal potion
			if (A[o16][k16] == 3)
				k16--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o16][k16] = 0;
			k16--;
			//Caso collisione muro
			if (A[o16][k16] == 7)
				k16++;
			//Caso di collizione personaggio
			if ((A[o16][k16] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o16][k16] == 1)
				k16++;
			//Caso di collizione fine gioco
			if (A[o16][k16] == 9)
				k16++;
			//Caso di collizione crystal potion
			if (A[o16][k16] == 3)
				k16++;

			break;
		}
	}
	punteggio();
	A[o16][k16] = 8;
	Disegna_Veloce(o16,k16);
}

//{Movimento del mostro (8) 17}
void mov_mostro8_17()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o17][k17] = 0;
			o17--;
			//Caso collisione muro
			if (A[o17][k17] == 7)
				o17++;
			//Caso di collizione personaggio
			if ((A[o17][k17] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o17][k17] == 1)
				o17++;
			//Caso di collizione fine gioco
			if (A[o17][k17] == 9)
				o17++;
			//Caso di collizione crystal potion
			if (A[o17][k17] == 3)
				o17++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o17][k17] = 0;
			o17++;
			//Caso collisione muro
			if (A[o17][k17] == 7)
				o17--;
			//Caso di collizione personaggio
			if ((A[o17][k17] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o17][k17] == 1)
				o17--;
			//Caso di collizione fine gioco
			if (A[o17][k17] == 9)
				o17--;
			//Caso di collizione crystal potion
			if (A[o17][k17] == 3)
				o17--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o17][k17] = 0;
			k17++;
			//Caso collisione muro
			if (A[o17][k17] == 7)
				k17--;
			//Caso di collizione personaggio
			if ((A[o17][k17] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o17][k17] == 1)
				k17--;
			//Caso di collizione fine gioco
			if (A[o17][k17] == 9)
				k17--;
			//Caso di collizione crystal potion
			if (A[o17][k17] == 3)
				k17--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o17][k17] = 0;
			k17--;
			//Caso collisione muro
			if (A[o17][k17] == 7)
				k17++;
			//Caso di collizione personaggio
			if ((A[o17][k17] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o17][k17] == 1)
				k17++;
			//Caso di collizione fine gioco
			if (A[o17][k17] == 9)
				k17++;
			//Caso di collizione crystal potion
			if (A[o17][k17] == 3)
				k17++;

			break;
		}
	}
	punteggio();
	A[o17][k17] = 8;
	Disegna_Veloce(o17,k17);
}

//{Movimento del mostro (8) 18}
void mov_mostro8_18()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o18][k18] = 0;
			o18--;
			//Caso collisione muro
			if (A[o18][k18] == 7)
				o18++;
			//Caso di collizione personaggio
			if ((A[o18][k18] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o18][k18] == 1)
				o18++;
			//Caso di collizione fine gioco
			if (A[o18][k18] == 9)
				o18++;
			//Caso di collizione crystal potion
			if (A[o18][k18] == 3)
				o18++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o18][k18] = 0;
			o18++;
			//Caso collisione muro
			if (A[o18][k18] == 7)
				o18--;
			//Caso di collizione personaggio
			if ((A[o18][k18] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o18][k18] == 1)
				o18--;
			//Caso di collizione fine gioco
			if (A[o18][k18] == 9)
				o18--;
			//Caso di collizione crystal potion
			if (A[o18][k18] == 3)
				o18--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o18][k18] = 0;
			k18++;
			//Caso collisione muro
			if (A[o18][k18] == 7)
				k18--;
			//Caso di collizione personaggio
			if ((A[o18][k18] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o18][k18] == 1)
				k18--;
			//Caso di collizione fine gioco
			if (A[o18][k18] == 9)
				k18--;
			//Caso di collizione crystal potion
			if (A[o18][k18] == 3)
				k18--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o18][k18] = 0;
			k18--;
			//Caso collisione muro
			if (A[o18][k18] == 7)
				k18++;
			//Caso di collizione personaggio
			if ((A[o18][k18] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o18][k18] == 1)
				k18++;
			//Caso di collizione fine gioco
			if (A[o18][k18] == 9)
				k18++;
			//Caso di collizione crystal potion
			if (A[o18][k18] == 3)
				k18++;

			break;
		}
	}
	punteggio();
	A[o18][k18] = 8;
	Disegna_Veloce(o18,k18);
}

//{Movimento del mostro (8) 19}
void mov_mostro8_19()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o19][k19] = 0;
			o19--;
			//Caso collisione muro
			if (A[o19][k19] == 7)
				o19++;
			//Caso di collizione personaggio
			if ((A[o19][k19] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o19][k19] == 1)
				o19++;
			//Caso di collizione fine gioco
			if (A[o19][k19] == 9)
				o19++;
			//Caso di collizione crystal potion
			if (A[o19][k19] == 3)
				o19++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o19][k19] = 0;
			o19++;
			//Caso collisione muro
			if (A[o19][k19] == 7)
				o19--;
			//Caso di collizione personaggio
			if ((A[o19][k19] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o19][k19] == 1)
				o19--;
			//Caso di collizione fine gioco
			if (A[o19][k19] == 9)
				o19--;
			//Caso di collizione crystal potion
			if (A[o19][k19] == 3)
				o19--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o19][k19] = 0;
			k19++;
			//Caso collisione muro
			if (A[o19][k19] == 7)
				k19--;
			//Caso di collizione personaggio
			if ((A[o19][k19] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o19][k19] == 1)
				k19--;
			//Caso di collizione fine gioco
			if (A[o19][k19] == 9)
				k19--;
			//Caso di collizione crystal potion
			if (A[o19][k19] == 3)
				k19--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o19][k19] = 0;
			k19--;
			//Caso collisione muro
			if (A[o19][k19] == 7)
				k19++;
			//Caso di collizione personaggio
			if ((A[o19][k19] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o19][k19] == 1)
				k19++;
			//Caso di collizione fine gioco
			if (A[o19][k19] == 9)
				k19++;
			//Caso di collizione crystal potion
			if (A[o19][k19] == 3)
				k19++;

			break;
		}
	}
	punteggio();
	A[o19][k19] = 8;
	Disegna_Veloce(o19,k19);
}

//{Movimento del mostro (8) 20}
void mov_mostro8_20()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o20][k20] = 0;
			o20--;
			//Caso collisione muro
			if (A[o20][k20] == 7)
				o20++;
			//Caso di collizione personaggio
			if ((A[o20][k20] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o20][k20] == 1)
				o20++;
			//Caso di collizione fine gioco
			if (A[o20][k20] == 9)
				o20++;
			//Caso di collizione crystal potion
			if (A[o20][k20] == 3)
				o20++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o20][k20] = 0;
			o20++;
			//Caso collisione muro
			if (A[o20][k20] == 7)
				o20--;
			//Caso di collizione personaggio
			if ((A[o20][k20] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o20][k20] == 1)
				o20--;
			//Caso di collizione fine gioco
			if (A[o20][k20] == 9)
				o20--;
			//Caso di collizione crystal potion
			if (A[o20][k20] == 3)
				o20--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o20][k20] = 0;
			k20++;
			//Caso collisione muro
			if (A[o20][k20] == 7)
				k20--;
			//Caso di collizione personaggio
			if ((A[o20][k20] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o20][k20] == 1)
				k20--;
			//Caso di collizione fine gioco
			if (A[o20][k20] == 9)
				k20--;
			//Caso di collizione crystal potion
			if (A[o20][k20] == 3)
				k20--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o20][k20] = 0;
			k20--;
			//Caso collisione muro
			if (A[o20][k20] == 7)
				k20++;
			//Caso di collizione personaggio
			if ((A[o20][k20] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o20][k20] == 1)
				k20++;
			//Caso di collizione fine gioco
			if (A[o20][k20] == 9)
				k20++;
			//Caso di collizione crystal potion
			if (A[o20][k20] == 3)
				k20++;

			break;
		}
	}
	punteggio();
	A[o20][k20] = 8;
	Disegna_Veloce(o20,k20);
}

//{Movimento del mostro (8) 21}
void mov_mostro8_21()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o21][k21] = 0;
			o21--;
			//Caso collisione muro
			if (A[o21][k21] == 7)
				o21++;
			//Caso di collizione personaggio
			if ((A[o21][k21] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o21][k21] == 1)
				o21++;
			//Caso di collizione fine gioco
			if (A[o21][k21] == 9)
				o21++;
			//Caso di collizione crystal potion
			if (A[o21][k21] == 3)
				o21++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o21][k21] = 0;
			o21++;
			//Caso collisione muro
			if (A[o21][k21] == 7)
				o21--;
			//Caso di collizione personaggio
			if ((A[o21][k21] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o21][k21] == 1)
				o21--;
			//Caso di collizione fine gioco
			if (A[o21][k21] == 9)
				o21--;
			//Caso di collizione crystal potion
			if (A[o21][k21] == 3)
				o21--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o21][k21] = 0;
			k21++;
			//Caso collisione muro
			if (A[o21][k21] == 7)
				k21--;
			//Caso di collizione personaggio
			if ((A[o21][k21] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o21][k21] == 1)
				k21--;
			//Caso di collizione fine gioco
			if (A[o21][k21] == 9)
				k21--;
			//Caso di collizione crystal potion
			if (A[o21][k21] == 3)
				k21--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o21][k21] = 0;
			k21--;
			//Caso collisione muro
			if (A[o21][k21] == 7)
				k21++;
			//Caso di collizione personaggio
			if ((A[o21][k21] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o21][k21] == 1)
				k21++;
			//Caso di collizione fine gioco
			if (A[o21][k21] == 9)
				k21++;
			//Caso di collizione crystal potion
			if (A[o21][k21] == 3)
				k21++;

			break;
		}
	}
	punteggio();
	A[o21][k21] = 8;
	Disegna_Veloce(o21,k21);
}

//{Movimento del mostro (8) 22}
void mov_mostro8_22()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o22][k22] = 0;
			o22--;
			//Caso collisione muro
			if (A[o22][k22] == 7)
				o22++;
			//Caso di collizione personaggio
			if ((A[o22][k22] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o22][k22] == 1)
				o22++;
			//Caso di collizione fine gioco
			if (A[o22][k22] == 9)
				o22++;
			//Caso di collizione crystal potion
			if (A[o22][k22] == 3)
				o22++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o22][k22] = 0;
			o22++;
			//Caso collisione muro
			if (A[o22][k22] == 7)
				o22--;
			//Caso di collizione personaggio
			if ((A[o22][k22] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o22][k22] == 1)
				o22--;
			//Caso di collizione fine gioco
			if (A[o22][k22] == 9)
				o22--;
			//Caso di collizione crystal potion
			if (A[o22][k22] == 3)
				o22--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o22][k22] = 0;
			k22++;
			//Caso collisione muro
			if (A[o22][k22] == 7)
				k22--;
			//Caso di collizione personaggio
			if ((A[o22][k22] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o22][k22] == 1)
				k22--;
			//Caso di collizione fine gioco
			if (A[o22][k22] == 9)
				k22--;
			//Caso di collizione crystal potion
			if (A[o22][k22] == 3)
				k22--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o22][k22] = 0;
			k22--;
			//Caso collisione muro
			if (A[o22][k22] == 7)
				k22++;
			//Caso di collizione personaggio
			if ((A[o22][k22] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o22][k22] == 1)
				k22++;
			//Caso di collizione fine gioco
			if (A[o22][k22] == 9)
				k22++;
			//Caso di collizione crystal potion
			if (A[o22][k22] == 3)
				k22++;

			break;
		}
	}
	punteggio();
	A[o22][k22] = 8;
	Disegna_Veloce(o22,k22);
}

//{Movimento del mostro (8) 23}
void mov_mostro8_23()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o23][k23] = 0;
			o23--;
			//Caso collisione muro
			if (A[o23][k23] == 7)
				o23++;
			//Caso di collizione personaggio
			if ((A[o23][k23] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o23][k23] == 1)
				o23++;
			//Caso di collizione fine gioco
			if (A[o23][k23] == 9)
				o23++;
			//Caso di collizione crystal potion
			if (A[o23][k23] == 3)
				o23++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o23][k23] = 0;
			o23++;
			//Caso collisione muro
			if (A[o23][k23] == 7)
				o23--;
			//Caso di collizione personaggio
			if ((A[o23][k23] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o23][k23] == 1)
				o23--;
			//Caso di collizione fine gioco
			if (A[o23][k23] == 9)
				o23--;
			//Caso di collizione crystal potion
			if (A[o23][k23] == 3)
				o23--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o23][k23] = 0;
			k23++;
			//Caso collisione muro
			if (A[o23][k23] == 7)
				k23--;
			//Caso di collizione personaggio
			if ((A[o23][k23] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o23][k23] == 1)
				k23--;
			//Caso di collizione fine gioco
			if (A[o23][k23] == 9)
				k23--;
			//Caso di collizione crystal potion
			if (A[o23][k23] == 3)
				k23--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o23][k23] = 0;
			k23--;
			//Caso collisione muro
			if (A[o23][k23] == 7)
				k23++;
			//Caso di collizione personaggio
			if ((A[o23][k23] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o23][k23] == 1)
				k23++;
			//Caso di collizione fine gioco
			if (A[o23][k23] == 9)
				k23++;
			//Caso di collizione crystal potion
			if (A[o23][k23] == 3)
				k23++;

			break;
		}
	}
	punteggio();
	A[o23][k23] = 8;
	Disegna_Veloce(o23,k23);
}

//{Movimento del mostro (8) 24}
void mov_mostro8_24()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o24][k24] = 0;
			o24--;
			//Caso collisione muro
			if (A[o24][k24] == 7)
				o24++;
			//Caso di collizione personaggio
			if ((A[o24][k24] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o24][k24] == 1)
				o24++;
			//Caso di collizione fine gioco
			if (A[o24][k24] == 9)
				o24++;
			//Caso di collizione crystal potion
			if (A[o24][k24] == 3)
				o24++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o24][k24] = 0;
			o24++;
			//Caso collisione muro
			if (A[o24][k24] == 7)
				o24--;
			//Caso di collizione personaggio
			if ((A[o24][k24] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o24][k24] == 1)
				o24--;
			//Caso di collizione fine gioco
			if (A[o24][k24] == 9)
				o24--;
			//Caso di collizione crystal potion
			if (A[o24][k24] == 3)
				o24--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o24][k24] = 0;
			k24++;
			//Caso collisione muro
			if (A[o24][k24] == 7)
				k24--;
			//Caso di collizione personaggio
			if ((A[o24][k24] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o24][k24] == 1)
				k24--;
			//Caso di collizione fine gioco
			if (A[o24][k24] == 9)
				k24--;
			//Caso di collizione crystal potion
			if (A[o24][k24] == 3)
				k24--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o24][k24] = 0;
			k24--;
			//Caso collisione muro
			if (A[o24][k24] == 7)
				k24++;
			//Caso di collizione personaggio
			if ((A[o24][k24] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o24][k24] == 1)
				k24++;
			//Caso di collizione fine gioco
			if (A[o24][k24] == 9)
				k24++;
			//Caso di collizione crystal potion
			if (A[o24][k24] == 3)
				k24++;

			break;
		}
	}
	punteggio();
	A[o24][k24] = 8;
	Disegna_Veloce(o24,k24);
}

//{Movimento del mostro (8) 25}
void mov_mostro8_25()
{
	int mov;

	//RANDOM CASUALE
	mov =  (rand()%4)+1;

	switch(mov)
	{
		//{Movimento UP}
		case (1):
		{
			A[o25][k25] = 0;
			o25--;
			//Caso collisione muro
			if (A[o25][k25] == 7)
				o25++;
			//Caso di collizione personaggio
			if ((A[o25][k25] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o25][k25] == 1)
				o25++;
			//Caso di collizione fine gioco
			if (A[o25][k25] == 9)
				o25++;
			//Caso di collizione crystal potion
			if (A[o25][k25] == 3)
				o25++;

			break;
		}
		//{Movimento DOWN}
		case (2):
		{
			A[o25][k25] = 0;
			o25++;
			//Caso collisione muro
			if (A[o25][k25] == 7)
				o25--;
			//Caso di collizione personaggio
			if ((A[o25][k25] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o25][k25] == 1)
				o25--;
			//Caso di collizione fine gioco
			if (A[o25][k25] == 9)
				o25--;
			//Caso di collizione crystal potion
			if (A[o25][k25] == 3)
				o25--;

			break;
		}
		//{Movimento RIGHT}
		case (3):
		{
			A[o25][k25] = 0;
			k25++;
			//Caso collisione muro
			if (A[o25][k25] == 7)
				k25--;
			//Caso di collizione personaggio
			if ((A[o25][k25] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o25][k25] == 1)
				k25--;
			//Caso di collizione fine gioco
			if (A[o25][k25] == 9)
				k25--;
			//Caso di collizione crystal potion
			if (A[o25][k25] == 3)
				k25--;

			break;
		}
		//{Movimento LEFT}
		case (4):
		{
			A[o25][k25] = 0;
			k25--;
			//Caso collisione muro
			if (A[o25][k25] == 7)
				k25++;
			//Caso di collizione personaggio
			if ((A[o25][k25] == 5) && (god_mode == false))
				collisione = true;
			//Caso di collizione ostacolo
			if (A[o25][k25] == 1)
				k25++;
			//Caso di collizione fine gioco
			if (A[o25][k25] == 9)
				k25++;
			//Caso di collizione crystal potion
			if (A[o25][k25] == 3)
				k25++;

			break;
		}
	}
	punteggio();
	A[o25][k25] = 8;
	Disegna_Veloce(o25,k25);
}
