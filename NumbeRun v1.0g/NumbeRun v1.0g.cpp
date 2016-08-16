 

		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*						*** NUMBERUN ***							*
		*																	*
		*	Nome:			NumbeRun.cpp									*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			Gioco - NumbeRun (modalità grafica)				*
		*	Piattaforma:	Windows											*
		*	Copyright:		2006 / 2007										*
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
#include "NUMBERUN_G.H"

//Librerie di sistema
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>

#include <GL/glut.h> // The GL Utility Toolkit (GLUT) Header

//COSTANTI GLOBALI
const short RIGHE = 22;
const short COLONNE = 80;

//VARIABILI PER LA GRAFICA
float dimensione_pixel = 10.0;							//Dimensione pixel degli oggetti
int WinWidth = dimensione_pixel * COLONNE + 1;          //Altezza della finestra windows
int WinHeight = dimensione_pixel * RIGHE + 1;			//Larghezza della finestra windows
int RotationPoint[2];									//Cordinate per il coloramento pixel
GLdouble GlobalMatrix[2];								//Matrix to hold transformations

//VARIABILI GLOBALI (GIOCO TESTUALE)
int A[RIGHE][COLONNE];		//Matrice di gioco
int i, j;					//Posizione del personaggio
int life;					//Vita del personaggio
int score_p = 0;			//Punteggio realizzato da protagonista (parziale)
int score_m = 0;			//Punteggio realizzato dai mostri (parziale)
int scoreTOT_p = 0;			//Punteggio totale realizzato da protagonista
int scoreTOT_m = 0;			//Punteggio totale realizzato dai mostri
bool collisione = false;	//Caso di contrasto tra personaggio e mostro
char scelta_menu = '0';		//Variabile che contiene la scelta del menu
char sentin_menu = 'S';		//Sentilla per il refresh del menù
char chat[50];				//variabile per i trucchi del gioco
bool snake_game = false;	//variabile per giocare a snake 
int pozioni_crystal = 0;	//variabile che contiene il numero di pozioni cristallizzanti
bool gioco_normale = false;	//è true se il gioco è impostato per livello normale
bool gioco_bonus = false;	//è true se il gioco è impostato per livello bonus
bool menu_del_gioco = true;	//è true se il gioco deve caricare il menu
int timer = 0;				//il timer delle mappe bonus
bool stampa_tutto = true;	//se è true stampa tutta l'intera matrice, se false solo gli oggetti
bool stampa_niente = false;	//se è true disattiva la stampa di qualunque cosa
bool reset = true;			//prima volta che il gioco viene avviato
bool livello_caricato = false;	//se è true il livello è già stato caricato, altrimenti lo carica
bool vittoria_livello = false;
bool CARICA_MENU = true;		//mostra il menu (usata nel caso di altre scelte di menu)
bool disegna_statistiche = true;//se TRUE mostra a video le statistiche del gioco
//Variabili per trucchi
	//velocità di gioco
	int velocita_mostri = 250000;		//imposta la velocità del gioco
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


//DICHIARAZIONE FUNZIONI (GIOCO TESTUALE)
void azzera_matrice();				//Azzera la matrice (la riempie di 0)
void mostra_matrice();				//Stampa la matrice a video
void punteggio();					//Gestione punteggio
void imposta_mura_generali();		//Imposta le mura standard del gioco
void controllo_vittoria();			//Controlla se il giocatore ha vinto
void controllo_livelli();			//Controlla l'ordine dei livelli e carica il successivo
void GIOCO_NORMALE();				//Funzione principale del gioco normale
void GIOCO_BONUS();					//Funzione principale del gioco bonus
void reset_variabili();				//Ripristina l'originalità delle variabili principali
void salva_punteggio();				//Funzione per il salvataggio del punteggio

//DICHIARAZIONE FUNZIONI GRAFICHE
void SetCameraPosition(void);
void ClearMatrix(GLdouble);
void IdentityMatrix(GLdouble);
void Initialize(void);
void DrawPoints(int, int, float, float, float);
void DrawPoint(int, int, float, float, float);
void ReshapeWindow(int, int);

void Disegna_Veloce(int, int);
void KeyPressed(unsigned char, int, int);
void SpecialKeyPressed(int, int, int);

void Disegna_Tabella_Statistiche(void);

void Converti_Matrice_In_Grafica(void);
void Converti_Matrice_In_Grafica_Oggetti(void);
void Converti_Cordinate_In_Grafica(int, int);
void stampa_matrice_grafica(void);
void MAIN_GIOCO(void);

void Carica_BackGround(int, int);
void Carica_Oggetti(int, int);

//Libreria principali personali
	//mostri del gioco
		#include "MONSTER_G.H"
	//scritte grafiche del game over
		#include "GAME_OVER_G.H"
	//scritte testuali dei crediti del gioco
		#include "CREDITI_TESTO_G.H"
		#include "CREDITI_GRAFICI_G.H"
	//trucchi del gioco
		#include "TRUCCHI_G.H"

//LIBRERIA GRAFICA DELLE IMMAGINI
	//funzioni per il movimento della grafica
		#include "MOVIMENTO_GRAFICO.H"

	//scritta grafica 'menu'
		#include "MENU_GRAFICO.H"
	//scritta grafica 'High Score'
		#include "HIGH_SCORE_GRAFICO.H"
	//scritta grafica 'guida'
		#include "GUIDA_GRAFICO.H"
	//scritta grafica 'crediti'
		#include "CREDITI_TESTUALI_GRAFICO.H"
	//scritta grafica 'Game Over'
		#include "GAME_OVER_GRAFICO.H"

	//livelli del gioco
		#include "LEVEL_G.H"

//Librerie grafiche per gli oggetti
	//Grafica del protagonista
		#include "FIVERUN_GRAFICA_G.H"
	//Grafica dei mostri
		#include "MOSTRI_GRAFICA_G.H"
	//Grafica dei tesori
		#include "TESORI_GRAFICA_G.H"
	//Grafica delle mura
		#include "MURA_GRAFICA_G.H"
	//Grafica del terreno
		#include "TERRENO_GRAFICA_G.H"
	//Grafica del fine gioco
		#include "FINE_GIOCO_GRAFICA_G.H"
	//Grafica delle pozioni cristallizzanti
		#include "CRYSTAL_POTION_GRAFICA_G.H"
	//Grafica degli ostacoli
		#include "OSTACOLO_GRAFICA_G.H"


// {Main del gioco per la grafica}
int main(int argc, char** argv)
{
	glutInit(&argc,argv);

	Initialize();    //Set up main window and variables

	printf("ATTENZIONE. . .\n");
	color(4);
	printf("spostare questa finestra piu\' in basso possibile dello schermo\n");
	printf("in modo tale pero\' che sia ancora completamente visibile.\n");
	printf("Buon divertimento!\n\n");
	system("pause");

	//disabilita il cursore
	glutSetCursor(GLUT_CURSOR_NONE);

	//GRAFICA
	glutSpecialFunc(SpecialKeyPressed);
	glutKeyboardFunc(KeyPressed);
	glutReshapeFunc(ReshapeWindow);

	glutDisplayFunc(stampa_matrice_grafica);
	glutIdleFunc(MAIN_GIOCO);
	

	//GRAFICA
	glutMainLoop();
	
	return 0;
}

void MAIN_GIOCO(void)
{
	static int contatore = 0;
	int contatore_MAX = 300000;
	if (reset == true)
	{
		//GIOCA_A_NUMBERUN();
		//Inizializzazione TIMER
		srand(time(NULL));

		//Inizializzazione LIVELLO (LEVEL.H)
		livello_corrente = 1;
		//Inizializzazione VITE
		life = 5;

		//Azzeramento punteggi
		score_p = 0;
		score_m = 0;
		scoreTOT_p = 0;
		scoreTOT_m = 0;

		system("cls");

		reset = false;
	}
	
	if (menu_del_gioco == false)
	{
		controllo_livelli();
	} else
	if (menu_del_gioco == true)
	{
		if (CARICA_MENU == true)
		{
			MOSTRA_MENU_GRAFICO();
		}
		if (contatore > contatore_MAX)
		{
			muovi_oggetti_nel_menu(9);
			muovi_oggetti_nel_menu(8);
			contatore = -1;
		}
		contatore++;
	}

}

void reset_variabili()
{
	//Ripristino variabili
	pozioni_crystal = 0;
	god_mode = false;
	velocita_mostri = 250000;
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
	CARICA_MENU = true;
	reset = true;
	menu_del_gioco = true;

}

// fuonzione principale del gioco a livelli normali
void GIOCO_NORMALE()
{
	static int CONTATORE_velocita_mostri = 0;
	static bool prima_volta = true;

	stampa_tutto = true;

	if (prima_volta == true)
	{
		disegna_statistiche = true;

		gioco_normale = true;
		gioco_bonus = false;


		prima_volta = false;
	}

	if (collisione == false)
	{
		//Ciclo principale

			//rallenta la velocità dei mostri
			if (CONTATORE_velocita_mostri > velocita_mostri)
			{
				//Controlla qnt mostri giocheranno nel livello selezionato (MONSTER.H)
				controllo_mostri_nel_gioco();
				CONTATORE_velocita_mostri = -1;
			}
			CONTATORE_velocita_mostri++;

			//Gestione delle collisioni del personaggio con i mostri (MONSTER.H)
			controllo_collisione_con_mostro();
	} else
	if (collisione == true)
	{
			if (vittoria_livello == true)
			{
				//Passaggio a livello successivo (LEVEL.H)
				livello_corrente++;
				vittoria_livello = false;
			}

			//disegna le statistiche del gioco
			disegna_statistiche = true;
			prima_volta = true;

			//Perdita di una vita
			life--;
			
			//Reset della collisione
			collisione = false;

			//Generamento livello di default
			azzera_matrice();
			imposta_mura_generali();

			//Per stampare l'intera matrice
			stampa_tutto = true;
			//Per far si di caricare il livello successivo
			livello_caricato = false;

			glutPostRedisplay();
			
			//Controlla il livello successivo da caricare
			controllo_livelli();
	}

}

// fuonzione principale del gioco a livelli bonus
void GIOCO_BONUS()
{
	//glutPostRedisplay();
	static int a, b;				//Variabili di controllo 2
	static bool numeri_due = false;		//Esiste almeno un 2
	static int num_casuale;		//Variabile che contiene un numero casuale
	static int tempo = 0;				//Variabile del tempo
	static int tempo_effettivo = 0;
	const int TEMPO_MAX = 60;	//Costante di tempo massima (circa 5.5 secondi ogni 100)
	static bool prima_volta = true;
	static int punteggio_OLD = 0;

	stampa_tutto = true;

	if (prima_volta == true)
	{
		timer = TEMPO_MAX - tempo_effettivo;
		disegna_statistiche = true;

		punteggio_OLD = score_p;

		gioco_normale = false;
		gioco_bonus = true;

		prima_volta = false;
	}

	//Mostra la matrice del livello (grafica)
	//Converti_Matrice_In_Grafica();

		//Ciclo principale
        if ((tempo_effettivo < TEMPO_MAX)  && (vittoria_livello == false))
		{
			
			//Muove il protagonista
			timer = TEMPO_MAX - tempo_effettivo;

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
					Converti_Cordinate_In_Grafica(a,b);
			}

			if (score_p != punteggio_OLD)
			{
				numeri_due = false;

				punteggio_OLD = score_p;
			} else
				numeri_due = true;


			//Incremento del tempo
			if (tempo == 5000000)
			{
				disegna_statistiche = true;
				tempo_effettivo++;
				tempo = 0;
			}
			tempo++;
			

		}

		if ((tempo_effettivo >= TEMPO_MAX) || (vittoria_livello == true))
		{

			score_p = 0;
			life--;

			tempo_effettivo = 0;
			tempo = 0;
			vittoria_livello = false;
			prima_volta = true;

			//Reset della collisione
			collisione = false;

			//Generamento livello di default
			azzera_matrice();
			imposta_mura_generali();

			//Per stampare l'intera matrice
			stampa_tutto = true;
			//Per far si di caricare il livello successivo
			livello_caricato = false;

			livello_corrente++;
			
			//Controlla il livello successivo da caricare
			controllo_livelli();
		}
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
		if (disegna_statistiche == true)
			Disegna_Tabella_Statistiche();
		GIOCA_A_NUMBERUN();
	} else
	{
		god_mode = false;

		if (usati_trucchi == true)
			livello_corrente = 0;

		//Mostra 'Game Over' ( game_over() -> animazione testuale )
			game_over_gia_stampato = false;
			MOSTRA_GAME_OVER_GRAFICO();
			game_over();
			//mostra_matrice();


		//Salvataggio del punteggio
		salva_punteggio();

		//Chiamate al sistema
			system("cls");

		//Reset
			reset_variabili();

		//Azzera la matrice del gioco
			azzera_matrice();

		//mostra il menu del gioco
			menu_del_gioco = true;
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
		disegna_statistiche = true;
		score_p = score_p + 10;
		scoreTOT_p = scoreTOT_p + 10;
	}

	//Punteggio dei mostri (MONSTER.H)
	controlla_punteggio_mostri();
}

void Disegna_Tabella_Statistiche(void)
{
	disegna_statistiche = false;

	//Imposta colore bianco per la scrittura
	gotoxy(0,0);

	color(15);
	printf("  |-------------------------------------------------------------------------|\n");
	printf("  |                          ");
	color(10);
	printf("STATISTICHE DEL GIOCO");
	color(15);
	printf("                          |\n");
	printf("  |-------------------------------------------------------------------------|\n");
	printf("                                                                             \n");

	//Imposta colore bianco per la scrittura
	color(15);

	//Scrittura tabella
		//Scrittura della barra sottostante al gioco
			//Riga della tabella
				printf("  |----------------------------------|   |----------------------------------|\n");
			//Livello del gioco
				printf("  |    Livello gioco    |%11d |   |    Score FiveRun    |%11d |\n", livello_corrente, score_p);
			//Riga della tabella
				printf("  |----------------------------------|   |----------------------------------|\n");
			//Vite
				printf("  |         Vite        |%11d |   |     Score mostri    |%11d |\n", life, score_m);	
			//Riga della tabella
				printf("  |----------------------------------|   |----------------------------------|\n");
			//Cristal Potion
				printf("  |    Crystal potion   |%11d |   |----------------------------------|\n", pozioni_crystal);	
			//Riga della tabella
				printf("  |----------------------------------|   | Score tot. FiveRun  |%11d |\n", scoreTOT_p);
			//Riga della tabella
				printf("                                         |----------------------------------|\n");
			//Riga della tabella
				printf("                                         |  Score tot. mostri  |%11d |\n", scoreTOT_m);
			//Riga della tabella
				printf("                                         |----------------------------------|\n");



			//Timer del tempo (GIOCO BONUS)
			if (gioco_bonus == true)
			{
				//Riga della tabella
					printf("  |----------------------------------|\n");
				//Livello del gioco
					printf("  |     Tempo bonus     |%11d |\n", timer);
				//Riga della tabella
					printf("  |----------------------------------|\n");
			}
			//Timer del tempo (GIOCO BONUS)
			if (gioco_bonus == false)
			{
				//Riga della tabella
					printf("                                      \n");
				//Livello del gioco
					printf("                                      \n");
				//Riga della tabella
					printf("                                      \n");
			}

		gotoxy(0,19);
		printf("  |-------------------------------------------------------------------------|\n");
		printf("  | ");
		color(4);
		printf("chat:");
		color(15);
		printf("                                                                   |\n");
		printf("  |-------------------------------------------------------------------------|\n");
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
			vittoria_livello = true;
			//Azzeramento punteggi parziali
			score_p = 0;
			score_m = 0;
			//Finta morte del protagonista
			collisione = true;
			life++;
		}

	}
}

//GRAFICA

void SetCameraPosition(void)
{
  /* Set the viewing transformation */
  glMatrixMode(GL_PROJECTION);
  glLoadIdentity();
  gluOrtho2D(0.0,(GLdouble)WinWidth+1.0,(GLdouble)WinHeight+1.0,0.0);
  glMatrixMode(GL_MODELVIEW);
}

void ClearMatrix(GLdouble Matrix[])
{
  int i;

  for (i = 0; i < 16; i++)
    Matrix[i] = 0.0;
}

void IdentityMatrix(GLdouble Matrix[])
{
  int i;

  ClearMatrix(Matrix);      // First, clear all matrix entries 
  for (i = 0; i < 16; i+=5) // Then, set the diagonal entries to 1.0 
    Matrix[i] = 1.0;
}

void Initialize(void)
{
  //Initialize the window and color mode
  //glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
  glutInitDisplayMode(GLUT_RGBA | GLUT_DOUBLE);
  glutInitWindowSize(WinWidth,WinHeight);
  glutCreateWindow("NumbeRun v1.0g");

  glClearColor(0.5,0.5,0.5,0.0);   // Background is black

  glClear(GL_COLOR_BUFFER_BIT);   //Clear the main window
 
  SetCameraPosition();

  IdentityMatrix(GlobalMatrix);  // Initialize global transformation matrix 
}

void Disegna_Veloce(int a, int b)
{
	a--;
	b--;
	int c = a;
	int d = b;
	int e = a+2;
	int f = b+2;
	for(c=a; c<=e; c++)
	{
		for(d=b; d<=f; d++)
		{
			Converti_Cordinate_In_Grafica(c,d);
		}
	}
}

void Converti_Cordinate_In_Grafica(int a ,int b)
{
	if (A[a][b] == 0)	//{Strada (nero)}
		TERRENO_GRAFICA_G(a, b);
	
	if (A[a][b] == 5)	//{Protagonista (fucsia)}
		FIVERUN_GRAFICA_G(a, b);

    if (A[a][b] == 8)	//{Mostro (verde chiaro)}
		MOSTRI_GRAFICA_G(a, b);

    if (A[a][b] == 2)	//{Tesoro (giallo)}
		TESORI_GRAFICA_G(a, b);

    if (A[a][b] == 7)	//{Mura (grigio chiaro)}
		MURA_GRAFICA_G(a, b);

    if (A[a][b] == 1)	//{Ostacolo (azzurro chiaro)}
		OSTACOLO_GRAFICA_G(a, b);

	if (A[a][b] == 9)	//{Fine del gioco (verde scuro)}
		FINE_GIOCO_GRAFICA_G(a, b);

	if (A[a][b] == 3)	//{Pozione crystal (bianco)}
		CRYSTAL_POTION_GRAFICA_G(a, b);
}

void Converti_Matrice_In_Grafica_Oggetti(void)
{
	int a, b;

	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			Carica_Oggetti(a, b);
		}
	}
}

void stampa_matrice_grafica(void)
{
	if (stampa_niente == false)
	{
		if (stampa_tutto == true)
		{
			glFlush();
			glClear(GL_COLOR_BUFFER_BIT);
			imposta_mura_generali();
			Converti_Matrice_In_Grafica();
			stampa_tutto = false;
		} else
		if (stampa_tutto == false)
		{
			Converti_Matrice_In_Grafica_Oggetti();
		}
	}
	if (menu_del_gioco == true)
	{
		menu_gia_stampato = false;	
	}
}

void Converti_Matrice_In_Grafica(void)
{
	int a, b;

	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			Carica_BackGround(a, b);
		}
	}
	for (a = 0; a < RIGHE; a++)
	{
		for (b = 0; b < COLONNE; b++)
		{
			Carica_Oggetti(a, b);
		}
	}

}

void Carica_BackGround(int a ,int b)
{
	TERRENO_GRAFICA_G(a, b);
	
	if (A[a][b] == 7)	//{Mura (grigio chiaro)}
		MURA_GRAFICA_G(a, b);
}

void Carica_Oggetti(int a ,int b)
{
	if (A[a][b] == 5)	//{Protagonista (fucsia)}
		FIVERUN_GRAFICA_G(a, b);

    if (A[a][b] == 8)	//{Mostro (verde chiaro)}
		MOSTRI_GRAFICA_G(a, b);

    if (A[a][b] == 2)	//{Tesoro (giallo)}
		TESORI_GRAFICA_G(a, b);

    if (A[a][b] == 1)	//{Ostacolo (azzurro chiaro)}
		OSTACOLO_GRAFICA_G(a, b);

	if (A[a][b] == 9)	//{Fine del gioco (verde scuro)}
		FINE_GIOCO_GRAFICA_G(a, b);

	if (A[a][b] == 3)	//{Pozione crystal (bianco)}
		CRYSTAL_POTION_GRAFICA_G(a, b);
}

void DrawPoints(int C, int D, float ROSSO, float VERDE, float BLU)
{

	//glClear(GL_COLOR_BUFFER_BIT);   //Clear the main window

	//Set the Rotation point
    RotationPoint[0] = C + (0);
    RotationPoint[1] = D + (0);

	//glLoadIdentity();    //Load the identity matrix - fresh start

	glPointSize(1.0);
	glBegin(GL_POINTS);
	{
		glColor3ub(ROSSO, VERDE, BLU);
		glVertex2iv(RotationPoint);    /* Draw Rotation Point */
	} 
	glEnd();

	//glFlush();           /* Flush all output to the main window */
}

void DrawPoint(int C, int D, float ROSSO, float VERDE, float BLU)
{

	//glClear(GL_COLOR_BUFFER_BIT);   //Clear the main window

	//Set the Rotation point
    RotationPoint[0] = C + (dimensione_pixel/2+1);
    RotationPoint[1] = D + (dimensione_pixel/2+1);

	//glLoadIdentity();    //Load the identity matrix - fresh start

	glPointSize(dimensione_pixel);
	glBegin(GL_POINTS);
	{
		glColor3ub(ROSSO, VERDE, BLU);
		glVertex2iv(RotationPoint);    /* Draw Rotation Point */
	} 
	glEnd();

	//glFlush();           /* Flush all output to the main window */
}

void ReshapeWindow(int Width, int Height)
{
  WinWidth = Width;     /* Update the global WinWidth/WinHeight variables */
  WinHeight = Height;
  SetCameraPosition();  /* Update the camera view to be full screen */
  glViewport(0,0,WinWidth,WinHeight);
}

void MOVIMENTO_UP()
{
			if (direzione_simmetrica == false)
			{
				A[i][j] = 0;
				Converti_Cordinate_In_Grafica(i,j);
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
				Converti_Cordinate_In_Grafica(i,j);
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
}

void MOVIMENTO_DOWN()
{
			if (direzione_simmetrica == true)
			{
				A[i][j] = 0;
				Converti_Cordinate_In_Grafica(i,j);
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
				Converti_Cordinate_In_Grafica(i,j);
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
}

void MOVIMENTO_RIGHT()
{
			if (direzione_simmetrica == false)
			{
				A[i][j] = 0;
				Converti_Cordinate_In_Grafica(i,j);
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
				Converti_Cordinate_In_Grafica(i,j);
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
}

void MOVIMENTO_LEFT()
{
			if (direzione_simmetrica == true)
			{
				A[i][j] = 0;
				Converti_Cordinate_In_Grafica(i,j);
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
				Converti_Cordinate_In_Grafica(i,j);
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
}

void CONTROLLO_POST_MOVIMENTO()
{


	//Controlla le condizioni di vittoria
	controllo_vittoria();
	
		//Pozione cristallizzazione
		if (A[i][j] == 3)
		{
			pozioni_crystal++;
			disegna_statistiche = true;
		}
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
				disegna_statistiche = true;
			} else
			{
				collisione = true;
			}
		}

	//Esamina il punteggio
	punteggio();


	//Stampa protagonista
	A[i][j] = 5;

	//Ridisegna protagonista
		Converti_Cordinate_In_Grafica(i,j);
}

void SpecialKeyPressed(int Key, int X, int Y)
{
	switch (Key)
	{
		//{Movimento UP}
		case (GLUT_KEY_UP):
		{
			MOVIMENTO_UP();

			break;
		}
		//{Movimento DOWN}	
		case (GLUT_KEY_DOWN):
		{
			MOVIMENTO_DOWN();

			break;
		}
		//{Movimento RIGHT}
		case (GLUT_KEY_RIGHT):
		{
			MOVIMENTO_RIGHT();

			break;
		}
		//{Movimento LEFT}
		case (GLUT_KEY_LEFT):
		{
			MOVIMENTO_LEFT();

			break;
		}
	}
	if ((gioco_normale == true) || (gioco_bonus == true))
		CONTROLLO_POST_MOVIMENTO();

	//glutPostRedisplay();
}

void KeyPressed(unsigned char Key, int A, int B)
{
	switch(Key)
	{
		//Casi del menù
			//NEW GAME
			case ('1'):
			{
				if (menu_del_gioco == true)
				{
					system("cls");
					//chiude il menù, caricando il gioco
					menu_del_gioco = false;
					
					//resetta matrice
					azzera_matrice();
					imposta_mura_generali();

					//ordina di stampare tutta la matrice
					stampa_niente = false;
					stampa_tutto = true;
				}
				break;
			}
			//HIGH SCORE
			case ('2'):
			{
				if (menu_del_gioco == true)
				{	
					CARICA_MENU = false;

					high_score_gia_stampato = false;
					MOSTRA_HIGH_SCORE_GRAFICO();

				}
				break;
			}
			//GUIDA
			case ('3'):
			{
				if (menu_del_gioco == true)
				{	
					CARICA_MENU = false;

					guida_gia_stampata = false;
					MOSTRA_GUIDA_GRAFICA();
				}
				break;
			}
			//CREDITI
			case ('4'):
			{
				if (menu_del_gioco == true)
				{	
					CARICA_MENU = false;

					crediti_gia_stampati = false;
					MOSTRA_CREDITI_TESTUALI_GRAFICI();
				}
				break;
			}
			//QUIT GAME
			case ('5'):
			{
				if (menu_del_gioco == true)
				{	
					system("cls");
					CARICA_MENU = false;

					//resetta matrice
					exit(0);
				}
				break;
			}
			//DEFAULT
			default:
			{
				if (menu_del_gioco == true)
				{
					CARICA_MENU = true;

					//ordina di stampare tutta la matrice
					stampa_niente = false;
					stampa_tutto = true;
				}
				break;
			}


		//Diminuzione della velocità del gioco
		case ('-'):
		{
			if (menu_del_gioco == false)
			{
				if (choose_motion == true)
				{
					velocita_mostri = velocita_mostri + 500;
				}

				break;
			}
		}
		//Aumento della velocità del gioco
		case ('+'):
		{
			if (menu_del_gioco == false)
			{

				if (choose_motion == true)
				{
					if (velocita_mostri > 1)
						velocita_mostri = velocita_mostri - 500;
					if (velocita_mostri == 0)
						velocita_mostri = 1;
				}

				break;
			}
		}
		//Char del gioco
		case ('\\'):
		{
			if (menu_del_gioco == false)
			{
				gotoxy(4,20);
				color(2);
				printf("chat: ");
				color(15);
				scanf("%s", &chat);

				//Controlla il trucco inserito
				trucchi_game();

				gotoxy(10,20);
				color(4);
				printf("chat: ");
				color(15);
				
				stampa_tutto = true;

				break;
			}
		}
		
		//Uscita dal gioco
		case ('q'):
		case ('Q'):
		{
			if (menu_del_gioco == false)
			{
				life = 1;
				collisione = true;

				break;
			}
		}
		//Refresh dello schermo
		case ('r'):
		case ('R'):
		{
			if (menu_del_gioco == true)
				CARICA_MENU = true;
			//Pulisce l'intero schermo
			glClear(GL_COLOR_BUFFER_BIT);
			//Per stampare l'intera matrice
			stampa_tutto = true;
			/*
			if (menu_del_gioco == true)
				menu_gia_stampato = false;

			m = NULL;
*/
			break;
		}
	}

	glutPostRedisplay();
}
