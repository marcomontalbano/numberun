
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** TRUCCHI ***							*
		*																	*
		*	Nome:			TRUCCHI.H										*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			libreria del gioco (trucchi del gioco)			*
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
void trucchi_game();

void trucchi_game()
{

	//porta a 25 il numero dei mostri
	if (strcmp(chat, "mi_chiamo_Lupin_III") == 0)
	{
		usati_trucchi = false;
	}

	//porta a 25 il numero dei mostri
	if (strcmp(chat, "clip_mode") == 0)
	{
		if (clip_mode == true)
		{
			clip_mode = false;
		} else
		{
			clip_mode = true;
		}

		usati_trucchi = true;
	}

	//porta a 25 il numero dei mostri
	if (strcmp(chat, "masochista_edition") == 0)
	{
		o1 = 19; k1 = 30;				//Posizione 1a mostro
		o2 = 1; k2 = 13;				//Posizione 2a mostro
		o3 = 10; k3 = 8;				//Posizione 3a mostro
		o4 = 17; k4 = 52;				//Posizione 4a mostro
		o5 = 2; k5 = 63;				//Posizione 5a mostro
		o6 = 4; k6 = 15;				//Posizione 6a mostro
		o7 = 19; k7 = 32;				//Posizione 7a mostro
		o8 = 10; k8 = 19;				//Posizione 8a mostro
		o9 = 2; k9 = 70;				//Posizione 9a mostro
		o10 = 4; k10 = 17;				//Posizione 10a mostro
		o11 = 19; k11 = 36;				//Posizione 11a mostro
		o12 = 2; k12 = 11;				//Posizione 12a mostro
		o13 = 21; k13 = 76;				//Posizione 13a mostro
		o14 = 9; k14 = 31;				//Posizione 14a mostro
		o15 = 4; k15 = 34;				//Posizione 15a mostro
		o16 = 8; k16 = 78;				//Posizione 16a mostro
		o17 = 3; k17 = 43;				//Posizione 17a mostro
		o18 = 17; k18 = 13;				//Posizione 18a mostro
		o19 = 6; k19 = 31;				//Posizione 19a mostro
		o20 = 15; k20 = 53;				//Posizione 20a mostro
		o21 = 2; k21 = 76;				//Posizione 21a mostro
		o22 = 4; k22 = 13;				//Posizione 22a mostro
		o23 = 17; k23 = 3;				//Posizione 23a mostro
		o24 = 8; k24 = 9;				//Posizione 24a mostro
		o25 = 20; k25 = 73;				//Posizione 25a mostro
		mostri = 25;

		usati_trucchi = true;
	}

	//inverte in modo simmetrico il movimento
	if (strcmp(chat, "simmetry_direction") == 0)
	{
		if (direzione_simmetrica == true)
		{
			direzione_simmetrica = false;
		} else
		{
			direzione_simmetrica = true;
		}

		usati_trucchi = true;
	}

	//aumenta la velocità di gioco
	if (strcmp(chat, "can_i_choose_motion") == 0)
	{
		if (choose_motion == true)
		{
			choose_motion = false;
		} else
		{
			choose_motion = true;
		}

		usati_trucchi = true;
	}

	//aumenta la velocità di gioco
	if (strcmp(chat, "evil_power") == 0)
	{
		velocita_mostri = 1;

		usati_trucchi = true;
	}

	//ripristina la velocità di gioco
	if (strcmp(chat, "normal_velocity") == 0)
	{
		velocita_mostri = 10000;
	}

	//diminuisce la velocità di gioco
	if (strcmp(chat, "slow_motion") == 0)
	{
		velocita_mostri = 50000;

		usati_trucchi = true;
	}

	//salta al livello successivo
	if (strcmp(chat, "non_ho_tempo_da_perdere") == 0)
	{
		//Azzeramento punteggi parziali
		score_p = 0;
		score_m = 0;
		//Finta morte del protagonista
		life++;
		collisione = true;
		//Passaggio a livello successivo (LEVEL.H)
		livello_corrente++;

		usati_trucchi = true;
	}

	//self_destruction
	if (strcmp(chat, "self_destruction") == 0)
	{
		life = 1;
		collisione = true;

		usati_trucchi = true;
	}

	//magnitude_10
	if (strcmp(chat, "magnitude_10") == 0)
	{
		int a, b;
		for (a = 0; a < RIGHE; a++)
		{
			for (b = 0; b < COLONNE; b++)
			{
				if ((A[a][b] == 7) || (A[a][b] == 1))
				{
					A[a][b] = 0;
				}
			}
		}	
		imposta_mura_generali();

		usati_trucchi = true;
	}

	//arriva_l_apocalisse
	if (strcmp(chat, "arriva_l_apocalisse") == 0)
	{
		int a, b;
		for (a = 0; a < RIGHE; a++)
		{
			for (b = 0; b < COLONNE; b++)
			{
				if ((A[a][b] == 7) || (A[a][b] == 1))
				{
					A[a][b] = 0;
				}
			}
			mostri = 0;
		}	
		imposta_mura_generali();

		usati_trucchi = true;
	}

	//ferma i mostri
	if (strcmp(chat, "monster_hunter") == 0)
	{
		mostri = 0;

		usati_trucchi = true;
	}

	//elimina tutte le pozze d'acqua
	if (strcmp(chat, "please_can_i_drink") == 0)
	{
		int a, b;
		for (a = 0; a < RIGHE; a++)
		{
			for (b = 0; b < COLONNE; b++)
			{
				if (A[a][b] == 1)
				{
					A[a][b] = 0;
				}
			}	
		}
		imposta_mura_generali();	

		usati_trucchi = true;
	}

	//simula il movimento di snake
	if (strcmp(chat, "si_snaking") == 0)
	{
		snake_game = true;

		usati_trucchi = true;
	}

	//toglie la simulazione di snake
	if (strcmp(chat, "no_snaking") == 0)
	{
		snake_game = false;

		usati_trucchi = true;
	}

	//aumenta la vita
	if (strcmp(chat, "santo_graal") == 0)
	{
		if (life < 999)
			life++;

		usati_trucchi = true;
	}

	//aumenta le crystal potion
	if (strcmp(chat, "chelling") == 0)
	{
		if (pozioni_crystal < 999)
			pozioni_crystal++;

		usati_trucchi = true;
	}

	//raccogli tutti i 2 e aumenta il punteggio protagonista
	if (strcmp(chat, "rubber_one_piece") == 0)
	{
		int a, b;
		for (a = 0; a < RIGHE; a++)
		{
			for (b = 0; b < COLONNE; b++)
			{
				if (A[a][b] == 2)
				{
					A[a][b] = 0;
					score_p = score_p + 10;
					scoreTOT_p = scoreTOT_p + 10;
				}
			}	
		}
		imposta_mura_generali();
		
		usati_trucchi = true;
	}

	//riempie di 7 la mappa, spianandoti però la strada
	if (strcmp(chat, "reveal_my_way") == 0)
	{
		int a, b;
		int cinque_x = i, cinque_y = j;		//coordinate del numero 5
		int nove_x = 0,nove_y = 0;			//coordinate del numero 9

		for (a = 0; a < RIGHE; a++)
		{
			for (b = 0; b < COLONNE; b++)
			{
				//murifica la mappa
				if (A[a][b] == 0)
				{
					A[a][b] = 7;
				}

				//trova le cordinate del fine gioco
				if (A[a][b] == 9)
				{
					nove_x = a;
					nove_y = b;
				}
			}	
		}
		
		
		//Spiana la strada
		if (cinque_x < nove_x)
		{
			for (; cinque_x <= nove_x; cinque_x++)
			{
				A[cinque_x][cinque_y] = 0;
			}

			//Resetta la variabile cinque_x
			cinque_x--;

		} else
		
		if (cinque_x > nove_x)
		{
			for (; cinque_x >= nove_x; cinque_x--)
			{
				A[cinque_x][cinque_y] = 0;
			}

			//Resetta la variabile cinque_x
			cinque_x++;

		}

		if (cinque_y < nove_y)
		{
			for (; cinque_y <= nove_y; cinque_y++)
			{
				A[cinque_x][cinque_y] = 0;
			}

		} else

		if (cinque_y > nove_y)
		{
			for (; cinque_y >= nove_y; cinque_y--)
			{
				A[cinque_x][cinque_y] = 0;
			}

		}

		//Stampa la fine del gioco
		A[nove_x][nove_y] = 9;

		imposta_mura_generali();

		usati_trucchi = true;
	}

	//invincibilità del personaggio
	if (strcmp(chat, "i_want_to_become_hulk") == 0)
	{
		if (god_mode == true)
		{
			god_mode = false;
		} else
		{
			god_mode = true;
		}

		usati_trucchi = true;
	}
}
