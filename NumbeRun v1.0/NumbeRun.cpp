
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** NUMBERUN ***							*
		*																	*
		*	Nome:			NumbeRun.cpp									*
		*	Programmato da: Montalbano Marco & Brambilla Giacomo			*
		*	Genere:			Gioco - NumbeRun								*
		*	Piattaforma:	Windows											*
		*	Copyright:		2005 / 2006										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/


//Per la compilazione del progetto:
/*
*
*	aggiungere nelle proprieta' del progetto,
*	nel tab del link, moduli oggetto/librerie
*	la libreria:		winmm.lib
*	(INIZIALIZZA PER L'AUDIO)
*
*/



//Libreria del gioco (contiene le funzioni principali: colore e spostamento cursore)
#include "NUMBERUN.H"

//Librerie di sistema
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>

//COSTANTI GLOBALI
const short RIGHE = 22;
const short COLONNE = 80;

//VARIABILI GLOBALI
int A[RIGHE][COLONNE];	//Matrice di gioco
int i, j;				//Posizione del personaggio
int life;				//Vita del personaggio
int score_p = 0;		//Punteggio realizzato da protagonista (parziale)
int score_m = 0;		//Punteggio realizzato dai mostri (parziale)
int scoreTOT_p = 0;		//Punteggio totale realizzato da protagonista
int scoreTOT_m = 0;		//Punteggio totale realizzato dai mostri
bool collisione = false;//Caso di contrasto tra personaggio e mostro
char m;					//Movimento del personaggio
char scelta_menu = '0';	//Variabile che contiene la scelta del menu
char sentin_menu = 'S';	//Sentilla per il refresh del menù
char chat[50];			//variabile per i trucchi del gioco
bool snake_game = false;//variabile per giocare a snake 
int pozioni_crystal = 0;//variabile che contiene il numero di pozioni cristallizzanti
//Variabili per trucchi
	//velocità di gioco
	int velocita_mostri = 10000;		//imposta la velocità del gioco
	//direzione simmetrica
	bool direzione_simmetrica = false;	//dis-abilita la direzione simmetrica
	//clip_mode
	bool clip_mode = false;				//dis-abilita la modalità clip_mode
	//modalità god-mode
	bool god_mode = false;				//variabile booleana per il trucco di invincibilità
	//modalità scelta di velocità
	bool choose_motion = false;			//dis-abilita la modalità choose_motion
	//E' true se sono stati usati trucchi nel gioco
	bool usati_trucchi = false;


//DICHIARAZIONE FUNZIONI
void azzera_matrice();			//Azzera la matrice (la riempie di 0)
void mostra_matrice();			//Stampa la matrice a video
void punteggio();				//Gestione punteggio
void mov_pers5(bool, int);		//Gestisce il movimento del personaggio
void imposta_mura_generali();	//Imposta le mura standard del gioco
void controllo_vittoria();		//Controlla se il giocatore ha vinto
void controllo_livelli();		//Controlla l'ordine dei livelli e carica il successivo
void GIOCO_NORMALE();			//Funzione principale del gioco normale
void GIOCO_BONUS();				//Funzione principale del gioco bonus
void reset_variabili();			//Ripristina l'originalità delle variabili principali
void salva_punteggio();			//Funzione per il salvataggio del punteggio
void mostra_high_score();		//Mostra l'high score del gioco


//Libreria da includere dopo le variabili globali e la dichiarazione delle funzioni
	//guida del gioco
	#include "GUIDA.H"
	//mostri del gioco
	#include "MONSTER.H"
	//scritte grafiche del game over
	#include "GAME_OVER.H"
	//scritte grafiche dei crediti del gioco
	#include "CREDITI_GRAFICI.H"
	//livelli del gioco
	#include "LEVEL.H"
	//scritte testuali dei crediti del gioco
	#include "CREDITI_TESTO.H"
	//scritte grafiche del menu
	#include "MENU.H"
	//trucchi del gioco
	#include "TRUCCHI.H"

// {Main del gioco}
int main()
{
		//Inizializzazione TIMER
		srand(time(NULL));
		
		do
		{
			//Inizializzazione LIVELLO (LEVEL.H)
			livello_corrente = 1;
			//Inizializzazione VITE
			life = 5;

			//Azzeramento punteggi
			score_p = 0;
			score_m = 0;
			scoreTOT_p = 0;
			scoreTOT_m = 0;
			
			if (sentin_menu == 'S')
			{
				//Generazione mappa di default
				system("cls");
				azzera_matrice();
				imposta_mura_generali();
				
				sentin_menu = 'N';
			}

			//Chiama il menù del gioco (SCRITTE.H)
			numberun_menu();

		} while (scelta_menu != '5');
		

	//Ritorno della funzione MAIN()
	system("pause");
	return 0;
}

void mostra_high_score()
{

	typedef struct
	{
		char nome_giocatore[20];	//Nome del giocatore
		int p_personaggio;			//Punteggio del personaggio
		int p_mostro;				//Punteggio del mostro
		int copia_livello;			//Copia del livello
	} punteggi;

	punteggi p_salva;
	long conta_bit = sizeof(punteggi);

	char cursore;				//Caso di uscita dalla guida
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

		cursore = 'z';

		//Aspetta il premere di un tasto
		while ((cursore == 'a') || (cursore == 'z'))
		{
			cursore = getch();

			if ((cursore == 'a') && (b > 0))
				b--;

			if ((cursore == 'z') && (b < incremento_max + 9))
				b++;

			gotoxy(a,b);
		}
}

void reset_variabili()
{
	//Ripristino variabili
	pozioni_crystal = 0;
	god_mode = false;
	velocita_mostri = 10000;
	direzione_simmetrica = false;
	clip_mode = false;
	choose_motion = false;
	life = 5;
	collisione = false;
	score_p = 0;
	score_m = 0;
	scoreTOT_p = 0;
	scoreTOT_m = 0;
	livello_corrente = 1;
	usati_trucchi = false;

}

void GIOCO_NORMALE()
{
		//Ciclo principale
        do
		{
			//Mostra la matrice del livello
			mostra_matrice();
			//Muove il protagonista
			mov_pers5(true, 0);

			//Controlla qnt mostri giocheranno nel livello selezionato (MONSTER.H)
			controllo_mostri_nel_gioco();

			//Gestione delle collisioni del personaggio con i mostri (MONSTER.H)
			controllo_collisione_con_mostro();

		} while (collisione == false);
		//Perdita di una vita
		life--;
		
		//Reset della collisione
		collisione = false;

		//Modalità SNAKE
		m = NULL;

		//Generamento livello di default
		system("cls");
		azzera_matrice();
		imposta_mura_generali();
		
		//Controlla il livello successivo da caricare
		controllo_livelli();
}

void GIOCO_BONUS()
{
	int a, b;				//Variabili di controllo 2
	bool numeri_due;		//Esiste almeno un 2
	int num_casuale;		//Variabile che contiene un numero casuale
	int tempo = 0;			//Variabile del tempo
	const int TEMPO_MAX = 1100;	//Costante di tempo massima (circa 5.5 secondi ogni 100)


		//Ciclo principale
        do
		{
			//Mostra la matrice del livello
			mostra_matrice();
			
			//Muove il protagonista
			mov_pers5(false, (TEMPO_MAX - tempo));

			//Controllo di 2 nella mappa
			for (a = 0; a < RIGHE; a++)
			{
				for (b = 0; b < COLONNE; b++)
				{
					if (A[a][b] == 2)
					{
						numeri_due = true;
					}
				}
			}

			if (numeri_due == false)
			{
				//Generamento di un 2 in modo random
					do
					{
						//1a RANDOM CASUALE
						num_casuale =  (rand()%22)+1;
					
						a = num_casuale;

						//2a RANDOM CASUALE
						num_casuale =  (rand()%80)+1;
					
						b = num_casuale;

						//
					} while (A[a][b] != 0);

					A[a][b] = 2;
			}

			numeri_due = false;

			//Incremento del tempo
			tempo++;

			if (collisione == true)
			{
				life = 0;
				break;
			}
		} while (tempo != TEMPO_MAX);

		//Modalità SNAKE
		m = NULL;

		//Generamento livello di default
			system("cls");
			azzera_matrice();
			imposta_mura_generali();

		//Livello successivo
			if (collisione == false)
			{
				//Passaggio a livello successivo (LEVEL.H)
				livello_corrente++;
			}

			score_p = 0;
		
			//Controlla il livello successivo da caricare
			controllo_livelli();
}

//Funzione per il salvataggio del punteggio
void salva_punteggio()
{
	typedef struct
	{
		char nome_giocatore[20];	//Nome del giocatore
		int p_personaggio;			//Punteggio del personaggio
		int p_mostro;				//Punteggio del mostro
		int copia_livello;			//Copia del livello
	} punteggi;

	FILE *file;
	punteggi p_salva;

	//Copia p. personaggio
	p_salva.p_personaggio = scoreTOT_p;

	//Copia p. mostro
	p_salva.p_mostro = scoreTOT_m;

	//Copia del livello
	p_salva.copia_livello = livello_corrente;

		

		//Imposta colore bianco per la scrittura
			color(15);
		
		//posizionamento cursore
			gotoxy(0,RIGHE);
		//Mostra informazioni punteggio
			printf("Punteggio giocatore: %d",scoreTOT_p);

		//posizionamento cursore
			gotoxy(40,RIGHE);
		//Mostra informazioni punteggio
			printf("Punteggio mostri: %d",scoreTOT_m);

		//Imposta colore bianco per la scrittura
			color(3);

		//posizionamento cursore
			gotoxy(0,RIGHE+2);
		//Salva punteggio
			printf("Nome giocatore (MAX 20 char):  ");
			scanf("%s", &p_salva.nome_giocatore);
		//Controlla ed elimina gli spazi nel 'nome'
			
			

		//Salvataggio del FILE
			file = fopen("High Score.txt", "a+b");
			fwrite(&p_salva,sizeof(punteggi),1,file);
			//fprintf(file,"%20s%10d%10d%5d\n", &nome_giocatore, scoreTOT_p, scoreTOT_m, livello_corrente);
			fclose(file);

}

//Controlla l'ordine dei livelli e carica il successivo (LEVEL.H)
void controllo_livelli()
{

	//Controlla il livello da caricare (in caso di protagonista in vita)
	if (life > 0)
	{
		GIOCA_A_NUMBERUN();
	} else
	{
		god_mode = false;

		if (usati_trucchi == true)
			livello_corrente = 0;

		//Mostra 'Game Over'
		game_over();

		//Salvataggio del punteggio
		salva_punteggio();

		//Chiamate al sistema
			system("cls");

		//Reset
		reset_variabili();
	}
}

// {Azzera la matrice}
void azzera_matrice()
{
	int a, b;
	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			A[a][b] = 0;
		}
	}
}

// {Mostra la matrice}
void mostra_matrice()
{
	int a, b, x, y;
	x = 0;
	y = 0;

	static int scegli_colore = 0;

	if (scegli_colore == 0)
	{
		scegli_colore = 1;
	} else
	{
		scegli_colore = 0;
	}

	gotoxy(0,0);
	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			if (A[a][b] == 0)	//{Strada (nero)}
				color(0);
			if (A[a][b] == 5)	//{Protagonista (fucsia)}
				if (god_mode == true)
				{
					if (scegli_colore == 0)
					{
						color (13);
					} else
					{
						color (0);
					}
				} else
				{
					color (13);
				}
            if (A[a][b] == 8)	//{Mostro (verde chiaro)}
				color (10);
            if (A[a][b] == 2)	//{Tesoro (giallo)}
				color (14);
            if (A[a][b] == 7)	//{Mura (grigio chiaro)}
				color (8);
            if (A[a][b] == 3)	//{Teletrasporto (bianco)}
				color (15);
            if (A[a][b] == 1)	//{Ostacolo (azzurro chiaro)}
				color (11);
			if (A[a][b] == 9)	//{Fine del gioco (verde scuro)}
				color (2);
			if (A[a][b] == 3)	//{Pozione crystal (bianco)}
				color (15);
			
			printf("%d",A[a][b]);

		}
		y++;
		gotoxy(x,y);
	}
}

//{Procedura per il punteggio}
void punteggio()
{
	//Punteggio del protagonista
	if (A[i][j] == 2)
	{
		//Aggiornamento punteggi
		score_p = score_p + 10;
		scoreTOT_p = scoreTOT_p + 10;
	}

	//Punteggio dei mostri (MONSTER.H)
	controlla_punteggio_mostri();
}

//{Genera il movimento del Protagonista (5)}
void mov_pers5(bool normale, int timer)
{
	int tratto = 0;		//Variabile per il tratteggio dello status
	int ritardo = 0;	//Ritardo dei mostri
	//char chatP;
	//int ciclo = 0;

	//Imposta colore blu per la scrittura
	color(15);
    
	//Scrittura della barra sottostante al gioco
		//Pozioni cristallizzanti
		gotoxy(0,RIGHE + 2);
		printf("# = %d", pozioni_crystal);
		//Livello attuale
		gotoxy(9,RIGHE + 2);
		printf("Livello = %d", livello_corrente);
		//Vite del personaggio
		gotoxy(24,RIGHE + 2);
		printf("Life = %d", life);
		//Punteggio del personaggio
		gotoxy(36,RIGHE + 2);
		printf("Your score: %d", score_p);
		//Punteggio dei mostri (GIOCO NORMALE)
		if (normale == true)
		{
			gotoxy(57,RIGHE + 2);
			printf("Monster score: %d", score_m);
		}
		//Timer del tempo (GIOCO BONUS)
		if (normale == false)
		{
			gotoxy(57,RIGHE + 2);
			printf("Timer bonus: %d    ", timer);
		}


		//Tratteggio
		gotoxy(0,RIGHE + 1);
		do
		{
			printf("-");
			tratto++;
		} while (tratto != COLONNE);
	
	//Movimento del personaggio
		//Ritardo di qualche decimo di secondo (per rallentare i mostri)
		for (ritardo = 0; ritardo < velocita_mostri; ritardo++)
		{
			//Controllo del tasto premuto
			if (kbhit())
			{
				m = getch();
			}
		}
	

	switch(m)
	{
		//Diminuzione della velocità del gioco
		case ('-'):
		{

			if (choose_motion == true)
			{
				velocita_mostri = velocita_mostri + 500;
			}
			
			m = NULL;

			break;
		}
		//Aumento della velocità del gioco
		case ('+'):
		{

			if (choose_motion == true)
			{
				if (velocita_mostri > 1)
					velocita_mostri = velocita_mostri - 500;
				if (velocita_mostri == 0)
					velocita_mostri = 1;
			}
			
			m = NULL;

			break;
		}
		//Char del gioco
		case ('\\'):
		{
			gotoxy(0,RIGHE);
			printf("< ");
			scanf("%s", &chat);

			//Controlla il trucco inserito
			trucchi_game();
			
			m = NULL;

			//pulisci lo schermo
			system("cls");
			break;
		}
		//Uscita dal gioco
		case ('q'):
		{
			life = 1;
			collisione = true;

			m = NULL;

			break;
		}
		//{Movimento UP}
		case ('H'):
		{
			if (direzione_simmetrica == false)
			{
				A[i][j] = 0;
				i--;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							i++;
						} else
						{
							i--;
							if (i == -1)
								i = 21;
						}
				} while (A[i][j] == 7);
			} else
			{
				A[i][j] = 0;
				i++;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							i--;
						} else
						{
							i++;
							if (i == 22)
								i = 1;
						}
				} while (A[i][j] == 7);
			}

			break;
		}
		//{Movimento DOWN}	
		case ('P'):
		{
			if (direzione_simmetrica == true)
			{
				A[i][j] = 0;
				i--;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							i++;
						} else
						{
							i--;
							if (i == -1)
								i = 21;
						}
				} while (A[i][j] == 7);
			} else
			{
				A[i][j] = 0;
				i++;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							i--;
						} else
						{
							i++;
							if (i == 22)
								i = 1;
						}
				} while (A[i][j] == 7);
			}

			break;
		}
		//{Movimento RIGHT}
		case ('M'):
		{
			if (direzione_simmetrica == false)
			{
				A[i][j] = 0;
				j++;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							j--;
						} else
						{
							j++;
							if (j == 80)
								j = 0;
						}
				} while (A[i][j] == 7);
			} else
			{
				A[i][j] = 0;
				j--;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							j++;
						} else
						{
							j--;
							if (j == -1)
								j = 79;
						}
				} while (A[i][j] == 7);
			}

			break;
		}
		//{Movimento LEFT}
		case ('K'):
		{
			if (direzione_simmetrica == true)
			{
				A[i][j] = 0;
				j++;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							j--;
						} else
						{
							j++;
							if (j == 80)
								j = 0;
						}
				} while (A[i][j] == 7);
			} else
			{
				A[i][j] = 0;
				j--;
				//Caso di collizione mura
				do
				{
					if (A[i][j] == 7)
						if (clip_mode == false)
						{
							j++;
						} else
						{
							j--;
							if (j == -1)
								j = 79;
						}
				} while (A[i][j] == 7);
			}

			break;
		}
	}

	//Controlla le condizioni di vittoria
	controllo_vittoria();
	
		//Pozione cristallizzazione
		if (A[i][j] == 3)
			pozioni_crystal++;
	//CASI DI MORTE
		//Caso di collizione personaggio
		if ((A[i][j] == 8) && (god_mode == false))
			collisione = true;
		//Caso di collizione ostacolo
		if ((A[i][j] == 1) && (god_mode == false))
		{
			//Se hai una pozione crystal non muori
			if (pozioni_crystal > 0)
			{
				pozioni_crystal--;
			} else
			{
				collisione = true;
			}
		}

	//Esamina il punteggio
	punteggio();

	//Stampa protagonista
	A[i][j] = 5;

	//Trucco del gioco (si_snake o no_snake)
	if (snake_game == false)
		m = NULL;
}

//{Imposta le mura generali del gioco}
void imposta_mura_generali()
{
	int a, b;
	
	//imposta muro sinistra
	b = 0;
	for (a = 0; a < RIGHE; a++)
	{
		A[a][b] = 7;
	}
	//imposta muro basso
	for (b = 0; b < COLONNE; b++)
	{
		A[a-1][b] = 7;
	}
	//imposta muro destra
	for (; a >= 0; a--)
	{
           A[a][b-1] = 7;
	}
	//imposta muro destra
	for (; b >= 0; b--)
	{
           A[a+1][b] = 7;
	}
}

void controllo_vittoria()
{
	//Controllo del punteggio per eventuale vittoria
	if (A[i][j] == 9)
	{
		//Punteggio uguale (perdita)
		if (score_p == score_m)
		{
			collisione = true;
		}
		//Punteggio pers. minore (perdita)
		if (score_p < score_m)
		{
			collisione = true;
		}
		//Punteggio pers. maggiore (vittoria)
		if (score_p > score_m)
		{
			//Azzeramento punteggi parziali
			score_p = 0;
			score_m = 0;
			//Finta morte del protagonista
			collisione = true;
			life++;
			//Passaggio a livello successivo (LEVEL.H)
			livello_corrente++;
		}
	}
}
