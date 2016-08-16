
#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

using System.Text;
#endregion

namespace VariabiliGlobali
{
    public class Globals
    {

        /// <summary>
        /// 
        /// </summary>
        //public static Collisioni MyCollisioni = new Collisioni();

        /// <summary>
        /// Informazione per la connessione al DB
        /// </summary>
        public static myDataBaseInformation myDBinformation = new myDataBaseInformation();

        /// <summary>
        /// Indica se la modalità del gioco è online
        /// </summary>
        public static bool bModOnLine = false;

        /// <summary>
        /// SEMAFORO: indica se il punteggio è già stato salvato
        /// </summary>
        public static bool bSEM_PunteggioSalvato = false;

        /// <summary>
        /// Il nickname dell'utente loggato
        /// </summary>
        public static string sNomeUtente = "";

        /// <summary>
        /// La password dell'utente loggato
        /// </summary>
        public static string sPasswordUtente = "";

        /// <summary>
        /// Ip della macchina su cui risiede il DataBase
        /// </summary>
        public static string sDataBaseIP = "";

        public static GraphicsDeviceManager valore_graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }
        public static GraphicsDeviceManager graphics;

        public static ContentManager valore_content
        {
            get { return content; }
            set { content = value; }
        }
        public static ContentManager content;

        /// <summary>
        /// Oggetto che permette di disegnare gli sprites
        /// </summary>
        public static SpriteBatch spriteBatch;

        /// <summary>
        /// Variable we will need for Keyboard Input
        /// </summary>
        public static KeyboardState ksKeyboardState;

        public enum GameState
        {
            StateMainMenu,
            StateSelectCharset,
            StatePlaying,
            StateHighScore,
            StateGuida,
            StateCrediti,
            StateGameOver,
            StateEsci,
        }
        
        /// <summary>
        /// Variabile di stato. Indica, nell'esecuzione del gioco, dove mi trovo:
        /// "menu" - Menù iniziale.
        /// "mod_game" - Gioco.
        /// "esci" - Esci.
        /// </summary>
        public static GameState iStato = GameState.StateMainMenu;

        public static int iNumeroCampi = 0;
        public static string[] sHS_Nome = new string[10];
        public static int[] iHS_Punteggio = new int[10];
        public static string[] sHS_Livello = new string[10];

        /// <summary>
        /// Indica lo stato su cui si trova la freccia. Se premuto invio viene selezionato
        /// la 'iStato'.
        /// </summary>
        public static int iStatoTemporaneo = 0;

        /// <summary>
        /// Indica se è già stato caricato il gioco; ovvero se è stata iniziato un 'Nuovo Gioco'.
        /// </summary>
        public static bool bGiocoAttivo = false;

        public static Level valore_myLevels
        {
            get { return myLevels; }
        }
        /// <summary>
        /// Include la classe per il caricamento delle mappe
        /// </summary>
        public static Level myLevels = new Level();

        /// <summary>
        /// Numero del livello corrente.
        /// </summary>
        public static int iNumeroLivello = 1;

        /// <summary>
        /// Indica lo stato su cui si trova la freccia. Se premuto invio viene selezionato
        /// la 'iStato'.
        /// 0 - Maschio.
        /// 1 - Femmina.
        /// </summary>
        public static int iStatoCharset = 0;

        #region variabili per la musica del gioco

        /// <summary>
        /// Musica del menu del gioco
        /// </summary>
        public static Cue cueMenu;

        /// <summary>
        /// Musica del Game Over del gioco
        /// </summary>
        public static Cue cueGameOver;

        /// <summary>
        /// Musica dei livelli del gioco
        /// </summary>
        public static Cue cueLevels;

        /// <summary>
        /// Numero delle musiche disponibili per i livelli
        /// </summary>
        private const int iLevelMusic = 3;

        // Nomi disponibili di musica per i livelli
        public static string[] sLevelMusic = new string[iLevelMusic]
            {
                "Menu02",
                "Mus021",
                "Mus024",
            };

        public static string vRandomMusic()
        {
            Random rRandom = new Random(unchecked((int)DateTime.Now.Ticks));
            int Rnd = 0;
            for (int i = -1; i <= 5; i++)
                Rnd = rRandom.Next(0, iLevelMusic);

            return sLevelMusic[Rnd];
        }

        #endregion

        #region variabili per la gestione del 'select charset'

        /// <summary>
        /// Texture dell'immagine MASCHIO
        /// </summary>
        public static Texture2D t2dMaleAvatar;

        /// <summary>
        /// Texture dell'immagine FEMMINA
        /// </summary>
        public static Texture2D t2dFemaleAvatar;

        #endregion

        #region variabili per la gestione del menù del gioco

        /// <summary>
        /// Texture contenente le immagini di dimensione 32x32
        /// </summary>
        public static Texture2D t2dTileSetOther;
        public static int iTileSetXCount = 3;
        public static int iTileSetYCount = 1;

        /// <summary>
        /// Texture contenente l'immagine di background del menù
        /// </summary>
        public static Texture2D t2dBgMenu;

        /// <summary>
        /// Texture contenente le scritte del menù (Nuovo gioco, High score, Guida, Crediti, Esci)
        /// </summary>
        public static Texture2D t2dTextMenu;

        /// <summary>
        /// Texture contenente l'immagine per la scelta del personaggio
        /// </summary>
        public static Texture2D t2dgamescreen_intro;

        /// <summary>
        /// Texture contenente l'immagine per la visualizzazione del nome del player (modalità on-line)
        /// </summary>
        public static Texture2D t2dPlayerOnLine;

        /// <summary>
        /// Texture contenente l'immagine per la visualizzazione della tabella nell'highscore(modalità on-line)
        /// </summary>
        public static Texture2D t2dHighScoreTAB;

        #endregion

        #region variabili per la gestione della guida e i crediti del gioco

        /// <summary>
        /// Texture dell'immagine contenente la GUIDA
        /// </summary>
        public static Texture2D t2dGuida;

        /// <summary>
        /// Texture dell'immagine contenente i CREDITI
        /// </summary>
        public static Texture2D t2dCrediti;

        #endregion

        #region variabili per la gestione delle mappe

        /// <summary>
        /// Grandezza standard di un'immagine ChipSet.
        /// </summary>
        public static int iDefaultSizeImage = 32;
        
        public static Maps valore_myMaps
        {
            get { return myMaps; }
        }
        /// <summary>
        /// Include la classe per il caricamento delle mappe
        /// </summary>
        public static Maps myMaps = new Maps();

        /// <summary>
        /// Oggetto "Texture2D" contenente l'immagine delle mappe del gioco
        /// </summary>
        public static Texture2D t2dMapsPicture;

        /// <summary>
        /// Indica l'immagine 'frame' da prendere nella texture
        /// </summary>
        public static Point pMapsFrame;

        #endregion

        #region gestione delle animazioni

        /// <summary>
        /// Gestione dell'animazione dell'acqua
        /// </summary>
        public static Animation myWaterAnimation = new Animation(24, 4, 0.25f);

        /// <summary>
        /// Gestione dell'animazione del fuoco
        /// </summary>
        public static Animation myFireAnimation = new Animation(40, 4, 0.25f);

        /// <summary>
        /// Gestione dell'animazione del mare
        /// </summary>
        public static Animation mySeaAnimation = new Animation(96, 3, 0.25f);

        #endregion

        #region gestione delle scritte nel gioco (Score, Livello, Crystal Potion e Vita)

        /// <summary>
        /// Oggetto "Texture2D" contenente i caratteri, per stampare il testo da visualizzare a video
        /// </summary>
        public static Texture2D t2dScritte;

        /// <summary>
        /// Texture contenente l'immagine per la stampa del testo
        /// </summary>
        public static Texture2D t2dTextSet;




        public static TextWriter twTesto = new TextWriter();


        #endregion

        #region gestione del personaggio principale

        /// <summary>
        /// Indica l'immagine 'frame' da prendere nella texture
        /// </summary>
        public static int iFacesetSize = 48;

        /// <summary>
        /// Oggetto "Texture2D" contenente la faccia dei player
        /// </summary>
        public static Texture2D t2dFacesetPlayers;

        /// <summary>
        /// Indica l'immagine 'frame' da prendere nella texture
        /// </summary>
        public static Point pFacesetFrame;

        /// <summary>
        /// Grandezza standard di un'immagine ChipSet.
        /// </summary>
        public class classSizePersonaggio
        {
            public int x = 24;
            public int y = 32;
        }
        public static classSizePersonaggio iDefaultSizePersonaggio = new classSizePersonaggio();

        /// <summary>
        /// Imposta se il gioco è in pausa o meno
        /// </summary>
        public static bool bGamePause = false;

        /// <summary>
        /// Include la classe per il caricamento del personaggio principale
        /// </summary>
        public static MainPersonaggio myMainPersonaggio = new MainPersonaggio();

        /// <summary>
        /// Indica se il personaggio ha subito una collisione, quindi perdita
        /// di una vita.
        /// </summary>
        public static bool bCollisione = false;

        /// <summary>
        /// Numero delle pozioni cristallizzanti che si hanno nello zaino e quindi pronte per l'utilizzo
        /// </summary>
        public static int iCrystalPotion = 0;

        /// <summary>
        /// Vita del personaggio.
        /// </summary>
        public static int iLife = 3;

        /// <summary>
        /// Punteggio parziale per livello.
        /// </summary>
        public static int iScore = 0;

        /// <summary>
        /// Punteggio totale del gioco.
        /// </summary>
        public static int iScoreTOT = 0;

        #endregion

        #region variabili per la gestione dei mostri

        /// <summary>
        /// Indica il numero dei mostri presenti nel livello.
        /// </summary>
        public static int iNumeroMostri = 0;

        /// <summary>
        /// Punteggio parziale dei mostri.
        /// </summary>
        public static int iScoreMostri = 0;

        /// <summary>
        /// Punteggio totale totalizzato dai mostri.
        /// </summary>
        public static int iScoreMostriTOT = 0;

        /// <summary>
        /// Classe per la gestione automatica dei mostri.
        /// </summary>
        public static Monster[] myMonster = new Monster[10];

        #endregion
    }
}