
#region Using Statements

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

using VariabiliGlobali;

#endregion

namespace NumbeRun
{
    /// <summary>
    /// Questa è la classe principale del gioco
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        /// <summary>
        /// Oggetto "Texture2D" per la cornice
        /// </summary>
        Texture2D t2dGameScreen;

        /// <summary>
        /// Percorso delle immagini
        /// </summary>
        public string sPathImageFile = "textures";

        public Game1()
        {
            // inizializzazione di due variabili principali
            VariabiliGlobali.Globals.graphics = new GraphicsDeviceManager(this);
            VariabiliGlobali.Globals.content = new ContentManager(Services);
        }


        /// <summary>
        /// Funzione per l'inizializzazione del gioco.
        /// Qui è possibile fare i settaggi principali del gioco, quali la risoluzione del video,
        /// il tilolo del gioco e tanti altri.
        /// Chiamando base.Initialize è la funzione che deve essere chiamata per ultima.
        /// </summary>
        protected override void Initialize()
        {
            // Titolo del gioco
            Window.Title = "NumbeRun";

            // Settaggio della risoluzione video del gioco
            VariabiliGlobali.Globals.graphics.PreferredBackBufferHeight = 480;
            VariabiliGlobali.Globals.graphics.PreferredBackBufferWidth = 640;
            VariabiliGlobali.Globals.graphics.ApplyChanges();
            // Inizializza il video in FullScreen
                VariabiliGlobali.Globals.graphics.ToggleFullScreen();

            #region inizializzazione delle variabili 'myMonster[]'

            // Inizializza i MOSTRI
            VariabiliGlobali.Globals.myMonster[0] = new Monster(000);
            VariabiliGlobali.Globals.myMonster[1] = new Monster(001);
            VariabiliGlobali.Globals.myMonster[2] = new Monster(002);
            VariabiliGlobali.Globals.myMonster[3] = new Monster(003);
            VariabiliGlobali.Globals.myMonster[4] = new Monster(004);
            VariabiliGlobali.Globals.myMonster[5] = new Monster(005);
            VariabiliGlobali.Globals.myMonster[6] = new Monster(006);
            VariabiliGlobali.Globals.myMonster[7] = new Monster(007);
            VariabiliGlobali.Globals.myMonster[8] = new Monster(008);
            VariabiliGlobali.Globals.myMonster[9] = new Monster(009);

            #endregion

            base.Initialize();
        }

        /// <summary>
        /// Load your graphics content.  If loadAllContent is true, you should
        /// load content from both ResourceManagementMode pools.  Otherwise, just
        /// load ResourceManagementMode.Manual content.
        /// </summary>
        /// <param name="loadAllContent">Which type of content to load.</param>
        protected override void LoadGraphicsContent(bool loadAllContent)
        {
            if (loadAllContent)
            {
                // Inizializza la variabile per il disegno degli sprites a video
                VariabiliGlobali.Globals.spriteBatch = new SpriteBatch(VariabiliGlobali.Globals.graphics.GraphicsDevice);

                // TODO: Controllo esistenza dei file immagini

                #region Texture2D

                // TODO: Load any ResourceManagementMode.Automatic content

                // ** MOD_GAME **
                // "Texture2D" -> ChipSet
                VariabiliGlobali.Globals.myMaps.t2dTileSet = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\fulltileset");
                // "Texture2D" -> Cornice del gioco
                t2dGameScreen = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\gamescreen");
                // "Texture2D" -> Scritte punteggi e livello
                VariabiliGlobali.Globals.t2dScritte = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\TextSet_Word");
                // "Texture2D" -> Personaggio del gioco (maschio)
                VariabiliGlobali.Globals.myMainPersonaggio.t2dPlayerAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\maschio");
                // "Texture2D" -> Faccie dei personaggi del gioco
                VariabiliGlobali.Globals.t2dFacesetPlayers = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\faceset");
                // "Texture2D" -> Faccie dei personaggi del gioco
                VariabiliGlobali.Globals.t2dMapsPicture = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\maps");
                // "Texture2D" -> Caratteri per stampare il testo
                VariabiliGlobali.Globals.t2dTextSet = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\TextSet");
                // "Texture2D" -> Carica la texture dei mostri
                VariabiliGlobali.Globals.myMonster[0].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[1].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[2].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[3].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[4].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[5].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[6].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[7].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[8].vLoadMonsterTexture();
                VariabiliGlobali.Globals.myMonster[9].vLoadMonsterTexture();

                // ** MENU **
                // "Texture2D" -> Immagini 32x32
                VariabiliGlobali.Globals.t2dTileSetOther = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\fulltileset_other");
                // "Texture2D" -> Immagine di background del menù
                VariabiliGlobali.Globals.t2dBgMenu = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\menu_background");
                // "Texture2D" -> Immagine per la scelta del personaggio
                VariabiliGlobali.Globals.t2dgamescreen_intro = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\gamescreen_intro");
                // "Texture2D" -> Scritte utilizzate nel menù (NUOVO GIOCO, HIGH SCORE, GUIDA, CREDITI, ESCI)
                VariabiliGlobali.Globals.t2dTextMenu = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\menu_text");
                // "Texture2D" -> Scritte utilizzate nella guida
                VariabiliGlobali.Globals.t2dGuida = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\guida");
                // "Texture2D" -> Scritte utilizzate nei crediti
                VariabiliGlobali.Globals.t2dCrediti = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\crediti");
                // "Texture2D" -> Immagine dell'Avatar MASCHIO
                VariabiliGlobali.Globals.t2dMaleAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\maschio");
                // "Texture2D" -> Immagine dell'Avatar FEMMINA
                VariabiliGlobali.Globals.t2dFemaleAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\femmina");
                // "Texture2D" -> Immagine del Player in caso di modalità on-line
                VariabiliGlobali.Globals.t2dPlayerOnLine = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\player_online");
                // "Texture2D" -> Immagine della tabella nell'highscore nella modalità on-line
                VariabiliGlobali.Globals.t2dHighScoreTAB = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\highscore_tab");

                #endregion


                #region caricamento delle Texture2D da file
                /*
                // ** MOD_GAME **
                // "Texture2D" -> ChipSet
                VariabiliGlobali.Globals.myMaps.t2dTileSet = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile +"\\fulltileset.png");
                // "Texture2D" -> Cornice del gioco
                t2dGameScreen = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\gamescreen.png");
                // "Texture2D" -> Scritte punteggi e livello
                VariabiliGlobali.Globals.t2dScritte = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\TextSet_Word.png");
                // "Texture2D" -> Personaggio del gioco (maschio)
                VariabiliGlobali.Globals.myMainPersonaggio.t2dPlayerAvatar = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\maschio.png");
                // "Texture2D" -> Faccie dei personaggi del gioco
                VariabiliGlobali.Globals.t2dFacesetPlayers = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\faceset.png");
                // "Texture2D" -> Faccie dei personaggi del gioco
                VariabiliGlobali.Globals.t2dMapsPicture = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\maps.png");
                // "Texture2D" -> Mostro1
                VariabiliGlobali.Globals.t2dMonsterAvatar1 = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\mostro1.png");
                // "Texture2D" -> Mostro2
                VariabiliGlobali.Globals.t2dMonsterAvatar2 = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\mostro2.png");
                // "Texture2D" -> Mostro3
                VariabiliGlobali.Globals.t2dMonsterAvatar3 = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\mostro3.png");
                // "Texture2D" -> Mostro4
                VariabiliGlobali.Globals.t2dMonsterAvatar4 = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\mostro4.png");
                // "Texture2D" -> Mostro5
                VariabiliGlobali.Globals.t2dMonsterAvatar5 = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\mostro5.png");
                // "Texture2D" -> Caratteri per stampare il testo
                VariabiliGlobali.Globals.t2dTextSet = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\TextSet.png");

                // ** MENU **
                // "Texture2D" -> Immagine di background del menù
                VariabiliGlobali.Globals.t2dBgMenu = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\menu_background.png");
                // "Texture2D" -> Immagine per la scelta del personaggio
                VariabiliGlobali.Globals.t2dgamescreen_intro = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\gamescreen_intro.png");
                // "Texture2D" -> Scritte utilizzate nel menù (NUOVO GIOCO, HIGH SCORE, GUIDA, CREDITI, ESCI)
                VariabiliGlobali.Globals.t2dTextMenu = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\menu_text.png");
                // "Texture2D" -> Scritte utilizzate nella guida
                VariabiliGlobali.Globals.t2dGuida = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\guida.png");
                // "Texture2D" -> Scritte utilizzate nei crediti
                VariabiliGlobali.Globals.t2dCrediti = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\crediti.png");
                // "Texture2D" -> Immagine dell'Avatar MASCHIO
                VariabiliGlobali.Globals.t2dMaleAvatar = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\maschio.png");
                // "Texture2D" -> Immagine dell'Avatar FEMMINA
                VariabiliGlobali.Globals.t2dFemaleAvatar = Texture2D.FromFile(VariabiliGlobali.Globals.graphics.GraphicsDevice, sPathImageFile + "\\femmina.png");
                */
                #endregion




            }
            // TODO: Load any ResourceManagementMode.Manual content
        }
        

        /// <summary>
        /// Unload your graphics content.  If unloadAllContent is true, you should
        /// unload content from both ResourceManagementMode pools.  Otherwise, just
        /// unload ResourceManagementMode.Manual content.  Manual content will get
        /// Disposed by the GraphicsDevice during a Reset.
        /// </summary>
        /// <param name="unloadAllContent">Which type of content to unload.</param>
        protected override void UnloadGraphicsContent(bool unloadAllContent)
        {
            if (unloadAllContent == true)
            {
                VariabiliGlobali.Globals.content.Unload();
            }
        }
        
        /// <summary>
        /// TRUE se un tasto è stato premuto
        /// </summary>
        static bool bTastoPremuto1 = false;
        /// <summary>
        /// TRUE se un tasto è stato premuto
        /// </summary>
        static bool bTastoPremutoESC = false;
        /// <summary>
        /// TRUE se un tasto è stato premuto
        /// </summary>
        static bool bTastoPremutoCHARSET = false;
        /// <summary>
        /// TRUE se un tasto è stato premuto
        /// </summary>
        static bool bTastoPremutoENTER = false;
        /// <summary>
        /// Se un tasto è stato premuto è il contatore che indica quando muovere automaticamente la freccia
        /// </summary>
        static int iTastoPremuto = 0;

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            #region cose da eseguire sempre

            // Controlla lo stato della tastiera in questo istante, ovvero controlla se
            // sono stati premuti dei tasti; nel caso affermativo tiene in memoria il tasto
            // premuto nella vabiale globale 'ksKeyboardState'.
            VariabiliGlobali.Globals.ksKeyboardState = Keyboard.GetState();

            // Allows the default game to exit on Xbox 360 and Windows
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // F1 per il FullScreen.
            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.F1))
                VariabiliGlobali.Globals.graphics.ToggleFullScreen();


            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Escape))
                bTastoPremutoESC = false;

            if ((bTastoPremutoESC == false) && (VariabiliGlobali.Globals.bGiocoAttivo == true))
            {
                // Controlla se il tasto ESC (Escape) è stato premuto.
                if ((VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape)))
                {
                    bTastoPremutoESC = true;
                    if (VariabiliGlobali.Globals.iStato == VariabiliGlobali.Globals.GameState.StatePlaying)
                    {

                        VariabiliGlobali.Globals.bGamePause = true;
                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;
                    }
                    else
                        if (VariabiliGlobali.Globals.iStato == VariabiliGlobali.Globals.GameState.StateMainMenu)
                        {
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StatePlaying;
                        }
                }
            }
            
            #endregion

            switch (VariabiliGlobali.Globals.iStato)
            {
                #region "menu" - menù del gioco

                case VariabiliGlobali.Globals.GameState.StateMainMenu:
                    {
                        // ** MENU' **

                        // Spostamento della freccia un passo alla volta
                        if ((bTastoPremuto1 == false) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Up)))
                        {
                            iTastoPremuto = 0;
                            bTastoPremuto1 = true;
                            VariabiliGlobali.Globals.iStatoTemporaneo--;
                            if (VariabiliGlobali.Globals.iStatoTemporaneo < 0)
                                VariabiliGlobali.Globals.iStatoTemporaneo = 4;
                        }
                        else
                        if ((bTastoPremuto1 == false) && VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Down))
                        {
                            iTastoPremuto = 0;
                            bTastoPremuto1 = true;
                            VariabiliGlobali.Globals.iStatoTemporaneo++;
                            if (VariabiliGlobali.Globals.iStatoTemporaneo > 4)
                                VariabiliGlobali.Globals.iStatoTemporaneo = 0;
                        }

                        if (bTastoPremuto1 == true)
                        {
                            iTastoPremuto++;

                            // Controlla se molla i tasti
                            if ((VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Up)) &&
                                (VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Down)))
                            {
                                bTastoPremuto1 = false;
                            }

                            if (iTastoPremuto == 15)
                            {
                                if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Up))
                                {
                                    bTastoPremuto1 = true;
                                    VariabiliGlobali.Globals.iStatoTemporaneo--;
                                    if (VariabiliGlobali.Globals.iStatoTemporaneo < 0)
                                        VariabiliGlobali.Globals.iStatoTemporaneo = 4;
                                }
                                else
                                    if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Down))
                                    {
                                        bTastoPremuto1 = true;
                                        VariabiliGlobali.Globals.iStatoTemporaneo++;
                                        if (VariabiliGlobali.Globals.iStatoTemporaneo > 4)
                                            VariabiliGlobali.Globals.iStatoTemporaneo = 0;
                                    }

                                iTastoPremuto = 0;
                            }
                        }

                        // Pressione del tasto ENTER
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Enter))
                        {
                            bTastoPremutoENTER = true;
                            switch (VariabiliGlobali.Globals.iStatoTemporaneo)
                            {
                                // NUOVO GIOCO
                                case 0:
                                    {
                                        // Ripristino gioco iniziale
                                        VariabiliGlobali.Globals.iCrystalPotion = 0;
                                        VariabiliGlobali.Globals.iLife = 3;
                                        VariabiliGlobali.Globals.iNumeroLivello = 1;
                                        VariabiliGlobali.Globals.iScore = 0;
                                        VariabiliGlobali.Globals.iScoreMostri = 0;
                                        VariabiliGlobali.Globals.iScoreMostriTOT = 0;
                                        VariabiliGlobali.Globals.iScoreTOT = 0;
                                        VariabiliGlobali.Globals.myLevels.vCaricaLivello();

                                        VariabiliGlobali.Globals.bGamePause = false;
                                        VariabiliGlobali.Globals.bGiocoAttivo = false;

                                        VariabiliGlobali.Globals.iStatoCharset = 0;

                                        // Inizio del gioco
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateSelectCharset;
                                        break;
                                    }
                                // HIGH SCORE
                                case 1:
                                    {
                                        if (VariabiliGlobali.Globals.bModOnLine == true)
                                        {
                                            // MODALITA' ON-LINE -> carica punteggio

                                            // Lettura dei dati dal DB
                                            if (VariabiliGlobali.Globals.myDBinformation.myDB.bConnettiDB(VariabiliGlobali.Globals.sDataBaseIP, VariabiliGlobali.Globals.myDBinformation.myDatabase, VariabiliGlobali.Globals.myDBinformation.myUser_ID, VariabiliGlobali.Globals.myDBinformation.myPassword))
                                            {
                                                VariabiliGlobali.Globals.iNumeroCampi = 0;
                                                // seleziona utenti
                                                string sql =
                                                    "SELECT mytable.users, mytable.score, numberun_score.livello FROM (SELECT users, max(score) AS score FROM numberun_score GROUP BY users) AS mytable, numberun_score WHERE (numberun_score.users = mytable.users AND numberun_score.score = mytable.score) ORDER BY (mytable.score) DESC LIMIT 8;";
                                                
                                                // esegue la query e inserisce nella variabile 'privilegio', il privilegio
                                                // dell'utente che si vuole loggare.
                                                int iPosizione = 0;
                                                if (VariabiliGlobali.Globals.myDBinformation.myDB.bEseguiQuery(sql))
                                                {
                                                    while (VariabiliGlobali.Globals.myDBinformation.myDB.idrReader.Read())
                                                    {
                                                        VariabiliGlobali.Globals.sHS_Nome[iPosizione] = ((string)VariabiliGlobali.Globals.myDBinformation.myDB.idrReader[0]);
                                                        VariabiliGlobali.Globals.iHS_Punteggio[iPosizione] = ((int)VariabiliGlobali.Globals.myDBinformation.myDB.idrReader[1]);
                                                        VariabiliGlobali.Globals.sHS_Livello[iPosizione] = ((string)VariabiliGlobali.Globals.myDBinformation.myDB.idrReader[2]);
                                                        iPosizione++;
                                                        VariabiliGlobali.Globals.iNumeroCampi++;
                                                    }
                                                }

                                                // Disconnette il DB
                                                VariabiliGlobali.Globals.myDBinformation.myDB.vSconnettiDB();
                                            }

                                            
                                            
                                        }

                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateHighScore;
                                       
                                        break;
                                    }
                                // GUIDA
                                case 2:
                                    {
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateGuida;
                                        break;
                                    }
                                // CREDITI
                                case 3:
                                    {
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateCrediti;
                                        break;
                                    }
                                // ESCI
                                case 4:
                                    {
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateEsci;
                                        break;
                                    }
                            }
                        }

                        break;
                    }

                #endregion

                #region "select_charset" - seleziona il personaggio da utilizzare

                case VariabiliGlobali.Globals.GameState.StateSelectCharset:
                    {
                        // ** SELECT CHARSET **

                        // Spostamento della freccia un passo alla volta
                        if ((bTastoPremutoCHARSET == false) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Left)))
                        {
                            iTastoPremuto = 0;
                            bTastoPremutoCHARSET = true;
                            VariabiliGlobali.Globals.iStatoCharset--;
                            if (VariabiliGlobali.Globals.iStatoCharset < 0)
                                VariabiliGlobali.Globals.iStatoCharset = 1;
                        }
                        else
                        if ((bTastoPremutoCHARSET == false) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Right)))
                        {
                            iTastoPremuto = 0;
                            bTastoPremutoCHARSET = true;
                            VariabiliGlobali.Globals.iStatoCharset++;
                            if (VariabiliGlobali.Globals.iStatoCharset > 1)
                                VariabiliGlobali.Globals.iStatoCharset = 0;
                        }

                        if (bTastoPremutoCHARSET == true)
                        {
                            iTastoPremuto++;

                            // Controlla se molla i tasti
                            if ((VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Left)) &&
                                (VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Right)))
                            {
                                bTastoPremutoCHARSET = false;
                            }

                            if (iTastoPremuto == 15)
                            {
                                if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Left))
                                {
                                    bTastoPremutoCHARSET = true;
                                    VariabiliGlobali.Globals.iStatoCharset--;
                                    if (VariabiliGlobali.Globals.iStatoCharset < 0)
                                        VariabiliGlobali.Globals.iStatoCharset = 1;
                                }
                                else
                                    if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Right))
                                    {
                                        bTastoPremutoCHARSET = true;
                                        VariabiliGlobali.Globals.iStatoCharset++;
                                        if (VariabiliGlobali.Globals.iStatoCharset > 1)
                                            VariabiliGlobali.Globals.iStatoCharset = 0;
                                    }

                                iTastoPremuto = 0;
                            }
                        }

                        // Pressione del tasto ENTER
                        if ((bTastoPremutoENTER == false) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Enter)))
                        {
                            switch (VariabiliGlobali.Globals.iStatoCharset)
                            {
                                case 0:
                                    {
                                        // "Texture2D" -> Personaggio del gioco (maschio)
                                        VariabiliGlobali.Globals.myMainPersonaggio.t2dPlayerAvatar = VariabiliGlobali.Globals.t2dMaleAvatar;
                                        VariabiliGlobali.Globals.pFacesetFrame.X = 0;
                                        VariabiliGlobali.Globals.pFacesetFrame.Y = 0;

                                        // Inizio del gioco
                                        VariabiliGlobali.Globals.bGiocoAttivo = true;

                                        // Inizio del gioco
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StatePlaying;

                                        break;
                                    }
                                case 1:
                                    {
                                        // "Texture2D" -> Personaggio del gioco (femmina)
                                        VariabiliGlobali.Globals.myMainPersonaggio.t2dPlayerAvatar = VariabiliGlobali.Globals.t2dFemaleAvatar;
                                        VariabiliGlobali.Globals.pFacesetFrame.X = 48;
                                        VariabiliGlobali.Globals.pFacesetFrame.Y = 0;

                                        // Inizio del gioco
                                        VariabiliGlobali.Globals.bGiocoAttivo = true;

                                        // Inizio del gioco
                                        VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StatePlaying;
                                        break;
                                    }
                            }
                        }

                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.Enter))
                            bTastoPremutoENTER = false;
                       

                        // Controlla se il tasto ESC (Escape) è stato premuto.
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape))
                        {
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;    // Ritorno al menù.
                        }

                        break;
                    }

                #endregion

                #region "mod_game" - gioco

                case VariabiliGlobali.Globals.GameState.StatePlaying:
                    {
                        // ** GIOCO **

                        // Controlla la pausa del gioco
                        if ((bTastoPremuto1 == false) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.P)))
                        {
                            bTastoPremuto1 = true;
                            if (VariabiliGlobali.Globals.bGamePause == false)
                                VariabiliGlobali.Globals.bGamePause = true;
                            else VariabiliGlobali.Globals.bGamePause = false;
                        }
                        if ((bTastoPremuto1 == true) && (VariabiliGlobali.Globals.ksKeyboardState.IsKeyUp(Keys.P)))
                        {
                            bTastoPremuto1 = false;
                        }

                        if (VariabiliGlobali.Globals.bGamePause == false)
                        {

                            // Stato di collisione effettuata con conseguente perdita di vita
                            if (VariabiliGlobali.Globals.bCollisione == true)
                            {
                                VariabiliGlobali.Globals.bCollisione = false;
                                VariabiliGlobali.Globals.iLife -= 1;
                                VariabiliGlobali.Globals.myLevels.vCaricaLivello();
                            }

                            // Caso di perdita totale delle vite
                            if (VariabiliGlobali.Globals.iLife < 0)
                            {
                                // Inizio del gioco
                                VariabiliGlobali.Globals.bGiocoAttivo = false;

                                // Azzeramento variabili
                                VariabiliGlobali.Globals.iCrystalPotion = 0;

                                // Ritorno al menù
                                VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateGameOver;
                            }

                            // Gestione animazione
                            VariabiliGlobali.Globals.myWaterAnimation.vUpdateAnimation(gameTime.ElapsedGameTime.TotalSeconds);
                            VariabiliGlobali.Globals.myFireAnimation.vUpdateAnimation(gameTime.ElapsedGameTime.TotalSeconds);
                            VariabiliGlobali.Globals.mySeaAnimation.vUpdateAnimation(gameTime.ElapsedGameTime.TotalSeconds);
                            
                            // Chiamata alla funzione che gestisce pienamente il movimento del personaggio,
                            // ovvero il suo spostamento, le eventuali collisione, la direzione dello sguardo.
                            VariabiliGlobali.Globals.myMainPersonaggio.vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);

                            // Movimento dei mostri
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 1)
                                VariabiliGlobali.Globals.myMonster[0].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 2)
                                VariabiliGlobali.Globals.myMonster[1].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 3)
                                VariabiliGlobali.Globals.myMonster[2].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 4)
                                VariabiliGlobali.Globals.myMonster[3].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 5)
                                VariabiliGlobali.Globals.myMonster[4].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 6)
                                VariabiliGlobali.Globals.myMonster[5].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 7)
                                VariabiliGlobali.Globals.myMonster[6].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 8)
                                VariabiliGlobali.Globals.myMonster[7].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 9)
                                VariabiliGlobali.Globals.myMonster[8].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                            if (VariabiliGlobali.Globals.myLevels.iNumeroMostriNellaMappa >= 10)
                                VariabiliGlobali.Globals.myMonster[9].vMuoviPersonaggio(gameTime.ElapsedGameTime.TotalSeconds);
                        }

                        break;
                    }

                #endregion

                #region "high_score" - high score

                case VariabiliGlobali.Globals.GameState.StateHighScore:
                    {
                        // ** HIGH SCORE **

                        // Controlla se il tasto ESC (Escape) è stato premuto.
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape))
                        {
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;    // Ritorno al menù.
                        }
                        break;
                    }

                #endregion

                #region "guida" - guida

                case VariabiliGlobali.Globals.GameState.StateGuida:
                    {
                        // ** GUIDA **

                        // Controlla se il tasto ESC (Escape) è stato premuto.
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape))
                        {
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;    // Ritorno al menù.
                        }
                        break;
                    }

                #endregion

                #region "crediti" - crediti

                case VariabiliGlobali.Globals.GameState.StateCrediti:
                    {
                        // ** CREDITI **

                        // Controlla se il tasto ESC (Escape) è stato premuto.
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape))
                        {
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;    // Ritorno al menù.
                        }
                        break;
                    }

                #endregion  

                #region "game_over" - game over

                case VariabiliGlobali.Globals.GameState.StateGameOver:
                    {
                        // ** GAME OVER **

                        // Salvataggio su DB dei risultati ottenuti
                        if (VariabiliGlobali.Globals.bModOnLine == true)
                        {
                            if (VariabiliGlobali.Globals.bSEM_PunteggioSalvato == false)
                            {
                                if (VariabiliGlobali.Globals.myDBinformation.myDB.bConnettiDB(VariabiliGlobali.Globals.sDataBaseIP, VariabiliGlobali.Globals.myDBinformation.myDatabase, VariabiliGlobali.Globals.myDBinformation.myUser_ID, VariabiliGlobali.Globals.myDBinformation.myPassword))
                                {
                                    string sql = "";

                                    // Rileva dal database qual'è l'ora e la data locale (del DB).
                                    string sStringa = "";
                                    sql = "SELECT CURRENT_TIMESTAMP;";
                                    if (VariabiliGlobali.Globals.myDBinformation.myDB.bEseguiQuery(sql))
                                    {
                                        while (VariabiliGlobali.Globals.myDBinformation.myDB.idrReader.Read())
                                        {
                                            sStringa = (Convert.ToString(VariabiliGlobali.Globals.myDBinformation.myDB.idrReader[0]));   // mette nella variabile privilegio quello dell'utente
                                        }
                                    }

                                    //"2007-07-15 00:57:12.89+02"
                                    string sData = sStringa.Substring(0, 10);
                                    string sOra = sStringa.Substring(11, sStringa.Length - 11);                                    

                                    /*
                                    sData.Replace('-', '/');
                                    sOra.Replace(':', '.');
                                    */
                                    
                                    /*
                                    // Rileva data e ora locali
                                    string sData = DateTime.Now.ToString("d");
                                    string sOra = DateTime.Now.ToString("T");
                                    */

                                    // Salva NUMBERUN_SCORE
                                    if (sOra.Length == 7)
                                        sql = "INSERT INTO numberun_score(users, score, livello, data, ora) VALUES('" + VariabiliGlobali.Globals.sNomeUtente + "'," + Convert.ToString(VariabiliGlobali.Globals.iScoreTOT) + ",'" + Convert.ToString(VariabiliGlobali.Globals.iNumeroLivello) + "','" + sData + "','0" + sOra + "');";
                                    else
                                        sql = "INSERT INTO numberun_score(users, score, livello, data, ora) VALUES('" + VariabiliGlobali.Globals.sNomeUtente + "'," + Convert.ToString(VariabiliGlobali.Globals.iScoreTOT) + ",'" + Convert.ToString(VariabiliGlobali.Globals.iNumeroLivello) + "','" + sData + "','" + sOra + "');";
                                    // esegue la query
                                    if (VariabiliGlobali.Globals.myDBinformation.myDB.bEseguiQuery(sql))
                                    {

                                    }


                                }

                                VariabiliGlobali.Globals.bSEM_PunteggioSalvato = true;
                            }
                        
                        }


                        // Controlla se il tasto ESC (Escape) è stato premuto.
                        if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Escape))
                        {
                            // Azzera le impostazioni di salvataggio
                            VariabiliGlobali.Globals.bSEM_PunteggioSalvato = false;

                            // Manda al menù del gioco
                            VariabiliGlobali.Globals.iStato = VariabiliGlobali.Globals.GameState.StateMainMenu;    // Ritorno al menù.
                        
                        }
                        break;
                    }

                #endregion

                #region "esci" - esci

                case VariabiliGlobali.Globals.GameState.StateEsci:
                    {
                        // ** ESCI **
                        
                        this.Dispose();

                        this.Exit();
                        break;
                    }

                #endregion
            }
        }

        // Variabili per il movimento del fiocco di neve nel menù del gioco
        static int iAnimazioneFiocco1 = 0;
        static int iXpositionFiocco1 = 200;
        static int iYpositionFiocco1 = 50;
        static int iAnimazioneFiocco2 = 10;
        static int iXpositionFiocco2 = 380;
        static int iYpositionFiocco2 = 30;
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            VariabiliGlobali.Globals.graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            switch (VariabiliGlobali.Globals.iStato)
            {
                #region "menu" - menù del gioco

                case VariabiliGlobali.Globals.GameState.StateMainMenu:
                    {
                        // ** MENU' **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background del menù
                        VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.t2dBgMenu, new Rectangle(0, 0, 640, 480), Color.White);

                        // Stampa la scritta 'NumbeRun'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dScritte,
                            new Rectangle(120, 25, 440, 60),
                            new Rectangle(0, 73, 440, 60),
                            Color.White
                            );

                        // Stampa il primo fiocco di neve
                        int iTileToDraw = 000;
                        iAnimazioneFiocco1++;
                        if (iAnimazioneFiocco1 == 60)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iXpositionFiocco1 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iYpositionFiocco1 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco1 = 0;
                        }
                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco1, iYpositionFiocco1, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il secondo fiocco di neve
                        iTileToDraw = 000;
                        iAnimazioneFiocco2++;
                        if (iAnimazioneFiocco2 == 65)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iXpositionFiocco2 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iYpositionFiocco2 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco2 = 0;
                        }
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco2, iYpositionFiocco2, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa la freccia di posizionamento
                        iTileToDraw = 001;

                        int iXposizioneFreccia = 0;
                        int iYposizioneFreccia = 0;
                        switch (VariabiliGlobali.Globals.iStatoTemporaneo)
                        {
                            case 0:
                                {
                                    iXposizioneFreccia = 160;
                                    iYposizioneFreccia = 130;
                                    break;
                                }
                            case 1:
                                {
                                    iXposizioneFreccia = 170;
                                    iYposizioneFreccia = 190;
                                    break;
                                }
                            case 2:
                                {
                                    iXposizioneFreccia = 225;
                                    iYposizioneFreccia = 250;
                                    break;
                                }
                            case 3:
                                {
                                    iXposizioneFreccia = 205;
                                    iYposizioneFreccia = 310;
                                    break;
                                }
                            case 4:
                                {
                                    iXposizioneFreccia = 235;
                                    iYposizioneFreccia = 370;
                                    break;
                                }
                        }
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXposizioneFreccia, 20 + iYposizioneFreccia, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa la scritta 'NUOVO GIOCO'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(195, 130, 260, 40),
                            new Rectangle(0, 0, 260, 40),
                            Color.White
                            );

                        // Stampa la scritta 'HIGH SCORE'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(195, 190, 260, 40),
                            new Rectangle(0, 40, 260, 40),
                            Color.White
                            );

                        // Stampa la scritta 'GUIDA'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(195, 250, 260, 40),
                            new Rectangle(0, 80, 260, 40),
                            Color.White
                            );

                        // Stampa la scritta 'CREDITI'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(195, 310, 260, 40),
                            new Rectangle(0, 120, 260, 40),
                            Color.White
                            );

                        // Stampa la scritta 'ESCI'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(195, 370, 260, 40),
                            new Rectangle(0, 160, 260, 40),
                            Color.White
                            );

                        // Stampa il nome del giocatore, se loggato
                        if (VariabiliGlobali.Globals.bModOnLine == true)
                        {
                            // Stampa dell'immagine che conterrà il nome del player
                            VariabiliGlobali.Globals.spriteBatch.Draw(
                                VariabiliGlobali.Globals.t2dPlayerOnLine,
                                new Rectangle(0, 480-94, 339, 94),
                                new Rectangle(0, 0, 339, 94),
                                Color.White
                                );
                            
                            VariabiliGlobali.Globals.twTesto.vScriviTesto(22, 450, VariabiliGlobali.Globals.sNomeUtente, 15);
                        }

                        VariabiliGlobali.Globals.spriteBatch.End();
                        break;
                    }

                #endregion

                #region "select_charset" - seleziona il personaggio da utilizzare

                case VariabiliGlobali.Globals.GameState.StateSelectCharset:
                    {
                        // ** SELECT CHARSET **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dgamescreen_intro,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        // Stampa il MASCHIO
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dMaleAvatar,
                            new Rectangle(120, 410, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarWidth, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarHeight),
                            new Rectangle(24, 64, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarWidth, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarHeight),
                            Color.White);



                        // Stampa la femmina
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dFemaleAvatar,
                            new Rectangle(240, 410, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarWidth, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarHeight),
                            new Rectangle(24, 64, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarWidth, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarHeight),
                            Color.White);

                        // Stampa la freccia di posizionamento
                        int iTileToDraw = 001;

                        int iXposizioneFreccia = 0;
                        int iYposizioneFreccia = 0;
                        switch (VariabiliGlobali.Globals.iStatoCharset)
                        {
                            case 0:
                                {
                                    iXposizioneFreccia = 80;
                                    iYposizioneFreccia = 415;
                                    break;
                                }
                            case 1:
                                {
                                    iXposizioneFreccia = 200;
                                    iYposizioneFreccia = 415;
                                    break;
                                }
                        }

                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXposizioneFreccia, 20 + iYposizioneFreccia, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);


                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "mod_game" - gioco

                case VariabiliGlobali.Globals.GameState.StatePlaying:
                    {
                        /// <summary>
                        /// Indica l'oggetto da stampare
                        /// </summary>
                        int iTileToDraw;

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.None);

                        // Stampa la mappa, più il controllo di eventuali animazioni
                        for (int y = 0; y < VariabiliGlobali.Globals.myMaps.iMapDisplayHeight; y++)
                        {
                            for (int x = 0; x < VariabiliGlobali.Globals.myMaps.iMapDisplayWidth; x++)
                            {
                                // Stampa della mappa "iMap"
                                iTileToDraw = VariabiliGlobali.Globals.myMaps.iMap[y + VariabiliGlobali.Globals.myMaps.iMapY, x + VariabiliGlobali.Globals.myMaps.iMapX];
                                
                                // ** ANIMAZIONI **
                                // Se l'oggetto da stampare è l'animazione
                                if (iTileToDraw == VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationStartFrame)
                                {
                                    iTileToDraw += VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationFrame;
                                }
                                if (iTileToDraw == VariabiliGlobali.Globals.myFireAnimation.iTileAnimationStartFrame)
                                {
                                    iTileToDraw += VariabiliGlobali.Globals.myFireAnimation.iTileAnimationFrame;
                                }
                                if (iTileToDraw == VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationStartFrame)
                                {
                                    iTileToDraw += VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationFrame;
                                }

                                Rectangle recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                    (iTileToDraw / VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                    VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                                VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMaps.t2dTileSet,
                                                 new Rectangle(((x * VariabiliGlobali.Globals.myMaps.iTileWidth) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetX) - VariabiliGlobali.Globals.myMaps.iMapXOffset,
                                                 ((y * VariabiliGlobali.Globals.myMaps.iTileHeight) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetY) - VariabiliGlobali.Globals.myMaps.iMapYOffset,
                                                 VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                                                 recSource,
                                                 Color.White);

                            }

                        }
                        VariabiliGlobali.Globals.spriteBatch.End();

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                       
                        // Stampa le mappe 'Trans' e 'Objects' e 'Trans2', più gestione del controllo di eventuali animazioni
                        for (int y = 0; y < VariabiliGlobali.Globals.myMaps.iMapDisplayHeight; y++)
                        {
                            for (int x = 0; x < VariabiliGlobali.Globals.myMaps.iMapDisplayWidth; x++)
                            {
                                Rectangle recDest = new Rectangle(((x * VariabiliGlobali.Globals.myMaps.iTileWidth) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetX) - VariabiliGlobali.Globals.myMaps.iMapXOffset,
                                                     ((y * VariabiliGlobali.Globals.myMaps.iTileHeight) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetY) - VariabiliGlobali.Globals.myMaps.iMapYOffset,
                                                     VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);

                                // Stampa della mappa "iMapTrans"
                                iTileToDraw = VariabiliGlobali.Globals.myMaps.iMapTrans[y + VariabiliGlobali.Globals.myMaps.iMapY, x + VariabiliGlobali.Globals.myMaps.iMapX];
                                if (iTileToDraw > 11)
                                {

                                    // ** ANIMAZIONI **
                                    // Se l'oggetto da stampare è l'animazione
                                    if (iTileToDraw == VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationFrame;
                                    }
                                    if (iTileToDraw == VariabiliGlobali.Globals.myFireAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.myFireAnimation.iTileAnimationFrame;
                                    }
                                    if (iTileToDraw == VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationFrame;
                                    }

                                    Rectangle recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                                    VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMaps.t2dTileSet, recDest, recSource, Color.White);
                                }

                                // Stampa della mappa "iMapObjects"
                                iTileToDraw = VariabiliGlobali.Globals.myMaps.iMapObjects[y + VariabiliGlobali.Globals.myMaps.iMapY, x + VariabiliGlobali.Globals.myMaps.iMapX];
                                if (iTileToDraw > 11)
                                {

                                    // ** ANIMAZIONI **
                                    // Se l'oggetto da stampare è l'animazione
                                    if (iTileToDraw == VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationFrame;
                                    }
                                    if (iTileToDraw == VariabiliGlobali.Globals.myFireAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.myFireAnimation.iTileAnimationFrame;
                                    }
                                    if (iTileToDraw == VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationStartFrame)
                                    {
                                        iTileToDraw += VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationFrame;
                                    }

                                    Rectangle recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                                    VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMaps.t2dTileSet, recDest, recSource, Color.White);
                                }

                            }
                        }

                                // Stampa il personaggio principale
                                VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMainPersonaggio.t2dPlayerAvatar, new Rectangle(((VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarXOffset * VariabiliGlobali.Globals.myMaps.iTileWidth) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetX),
                                                     ((VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvaterYOffset * VariabiliGlobali.Globals.myMaps.iTileHeight) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetY),
                                                     VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight), new Rectangle(VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarXframe, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarYframe, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarWidth, VariabiliGlobali.Globals.myMainPersonaggio.iPlayerAvatarHeight), Color.White);



                                // Stampa le mappe 'Trans' e 'Objects' e 'Trans2', più gestione del controllo di eventuali animazioni
                                for (int y = 0; y < VariabiliGlobali.Globals.myMaps.iMapDisplayHeight; y++)
                                {
                                    for (int x = 0; x < VariabiliGlobali.Globals.myMaps.iMapDisplayWidth; x++)
                                    {
                                        Rectangle recDest = new Rectangle(((x * VariabiliGlobali.Globals.myMaps.iTileWidth) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetX) - VariabiliGlobali.Globals.myMaps.iMapXOffset,
                                                     ((y * VariabiliGlobali.Globals.myMaps.iTileHeight) + VariabiliGlobali.Globals.myMaps.iMapDisplayOffsetY) - VariabiliGlobali.Globals.myMaps.iMapYOffset,
                                                     VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);

                                        // Stampa della mappa "iMapTrans"
                                        iTileToDraw = VariabiliGlobali.Globals.myMaps.iMapObjects[y + VariabiliGlobali.Globals.myMaps.iMapY, x + VariabiliGlobali.Globals.myMaps.iMapX];


                                        // Controlla se deve stampare la posizione del mostro1
                                        if (iTileToDraw == 002)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[0].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[0].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[0].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro2
                                        if (iTileToDraw == 003)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[1].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[1].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[1].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro3
                                        if (iTileToDraw == 004)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[2].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[2].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[2].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro4
                                        if (iTileToDraw == 005)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[3].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[3].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[3].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro5
                                        if (iTileToDraw == 006)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[4].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[4].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[4].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro6
                                        if (iTileToDraw == 007)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[5].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[5].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[5].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro7
                                        if (iTileToDraw == 008)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[6].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[6].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[6].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro8
                                        if (iTileToDraw == 009)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[7].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[7].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[7].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro9
                                        if (iTileToDraw == 010)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[8].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[8].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[8].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }

                                        // Controlla se deve stampare la posizione del mostro10
                                        if (iTileToDraw == 011)
                                        {
                                            Rectangle recSource = new Rectangle(VariabiliGlobali.Globals.myMonster[9].iReturnMonsterAvatarFrame('X'), VariabiliGlobali.Globals.myMonster[9].iReturnMonsterAvatarFrame('Y'), VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarWidth, VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMonster[9].t2dLoadMonsterTexture(), recDest, recSource, Color.White);
                                        }


                                        // Stampa della mappa "iMapTrans2"
                                        iTileToDraw = VariabiliGlobali.Globals.myMaps.iMapTrans2[y + VariabiliGlobali.Globals.myMaps.iMapY, x + VariabiliGlobali.Globals.myMaps.iMapX];
                                        if (iTileToDraw > 11)
                                        {

                                            // ** ANIMAZIONI **
                                            // Se l'oggetto da stampare è l'animazione
                                            if (iTileToDraw == VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationStartFrame)
                                            {
                                                iTileToDraw += VariabiliGlobali.Globals.myWaterAnimation.iTileAnimationFrame;
                                            }
                                            if (iTileToDraw == VariabiliGlobali.Globals.myFireAnimation.iTileAnimationStartFrame)
                                            {
                                                iTileToDraw += VariabiliGlobali.Globals.myFireAnimation.iTileAnimationFrame;
                                            }
                                            if (iTileToDraw == VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationStartFrame)
                                            {
                                                iTileToDraw += VariabiliGlobali.Globals.mySeaAnimation.iTileAnimationFrame;
                                            }

                                            Rectangle recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                                (iTileToDraw / VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                                VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                                            VariabiliGlobali.Globals.spriteBatch.Draw(VariabiliGlobali.Globals.myMaps.t2dTileSet, recDest, recSource, Color.White);
                                        }
                                    }
                                }

                        // Stampa la cornice del gioco
                        VariabiliGlobali.Globals.spriteBatch.Draw(t2dGameScreen, new Rectangle(0, 0, 640, 480), Color.White);

                        // Stampa la scritta 'Player Score:'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(310, 365, VariabiliGlobali.Globals.iScore.ToString(), 15);
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(VariabiliGlobali.Globals.twTesto.iPosizioneX - 155, VariabiliGlobali.Globals.twTesto.iPosizioneY, "Player Score:", 10);

                        // Stampa la scritta 'Monster Score:'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(310, 440, VariabiliGlobali.Globals.iScoreMostri.ToString(), 15);
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(VariabiliGlobali.Globals.twTesto.iPosizioneX - 155, VariabiliGlobali.Globals.twTesto.iPosizioneY, "Monster Score:", 10);

                        // Stampa la scritta 'Level:'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(585, 365, VariabiliGlobali.Globals.iNumeroLivello.ToString(), 15);
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(VariabiliGlobali.Globals.twTesto.iPosizioneX - 90, VariabiliGlobali.Globals.twTesto.iPosizioneY, "Livello:", 10);

                        // Stampa la quantità di 'Crystal Potion'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(585, 405, VariabiliGlobali.Globals.iCrystalPotion.ToString(), 15);
                        iTileToDraw = 015;
                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.myMaps.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.myMaps.t2dTileSet,
                            new Rectangle(VariabiliGlobali.Globals.twTesto.iPosizioneX - 35, VariabiliGlobali.Globals.twTesto.iPosizioneY - 10, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa la quantità di 'Life'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(585, 445, VariabiliGlobali.Globals.iLife.ToString(), 15);
                        iTileToDraw = 002;
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(VariabiliGlobali.Globals.twTesto.iPosizioneX - 35, VariabiliGlobali.Globals.twTesto.iPosizioneY - 10, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa la faccia del personaggio
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                                VariabiliGlobali.Globals.t2dFacesetPlayers,
                                new Rectangle(45, 380, 60, 60),
                                new Rectangle(VariabiliGlobali.Globals.pFacesetFrame.X, VariabiliGlobali.Globals.pFacesetFrame.Y, VariabiliGlobali.Globals.iFacesetSize, VariabiliGlobali.Globals.iFacesetSize),
                                Color.White);
                        
                        // Stampa la picture del livello corrente
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                                VariabiliGlobali.Globals.t2dMapsPicture,
                                new Rectangle(551, 318, 78, 20),
                                new Rectangle(0, 40*(VariabiliGlobali.Globals.iNumeroLivello-1), 156, 40),
                                Color.White);

                        // Stampa la scritta di "PAUSA" in caso 'bGamePause' = true
                        if (VariabiliGlobali.Globals.bGamePause == true)
                        {
                            VariabiliGlobali.Globals.spriteBatch.Draw(
                                VariabiliGlobali.Globals.t2dTextMenu,
                                new Rectangle(250, 180, 200, 40),
                                new Rectangle(260, 120, 200, 40),
                                Color.White);
                        }

                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "high_score" - high score

                case VariabiliGlobali.Globals.GameState.StateHighScore:
                    {
                        // ** HIGH SCORE **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background dell'High Score
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dBgMenu,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        // Stampa la tabella, se loggato
                        if (VariabiliGlobali.Globals.bModOnLine == true)
                        {
                            // Stampa la tabella in caso di modalità on-line
                            VariabiliGlobali.Globals.spriteBatch.Draw(
                                VariabiliGlobali.Globals.t2dHighScoreTAB,
                                new Rectangle(0, 0, 640, 480),
                                new Rectangle(0, 0, 640, 480),
                                Color.White
                                );
                        }

                        // Stampa la scritta 'NumbeRun'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dScritte,
                            new Rectangle(120, 25, 440, 60),
                            new Rectangle(0, 73, 440, 60),
                            Color.White
                            );

                        // Stampa il titoletto 'HIGH SCORE'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(18, 85, 200, 40),
                            new Rectangle(260, 0, 200, 40),
                            Color.White);

                        // Stampa il primo fiocco di neve
                        int iTileToDraw = 000;
                        iAnimazioneFiocco1++;
                        if (iAnimazioneFiocco1 == 60)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iXpositionFiocco1 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iYpositionFiocco1 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco1 = 0;
                        }
                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco1, iYpositionFiocco1, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il secondo fiocco di neve
                        iTileToDraw = 000;
                        iAnimazioneFiocco2++;
                        if (iAnimazioneFiocco2 == 65)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iXpositionFiocco2 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iYpositionFiocco2 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco2 = 0;
                        }
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco2, iYpositionFiocco2, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                            if (VariabiliGlobali.Globals.bModOnLine == false)
                            {
                                // Stampa della scritta 'modalità off-line'
                                VariabiliGlobali.Globals.spriteBatch.Draw(
                                    VariabiliGlobali.Globals.t2dScritte,
                                    new Rectangle(100, 190, 475, 100),
                                    new Rectangle(0, 290, 475, 100),
                                    Color.White);

                            }
                            else
                            {
                                // MODALITA' ON-LINE -> mostra punteggio
                                // Stampa della griglia
                                int iRiga = 145;
                                int iColonnaPrima = 47;
                                int iColonnaSeconda = 278;
                                int iColonnaTerza = 470;
                                VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaPrima, iRiga, "NOME", 15);
                                VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaSeconda, iRiga, "PUNTEGGIO", 15);
                                VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaTerza, iRiga, "LIVELLO", 15);
                                // Lettura dei dati dal DB
                                for (int ii = 0; ii < VariabiliGlobali.Globals.iNumeroCampi; ii++)
                                {
                                    iRiga += 30;
                                    VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaPrima, iRiga, VariabiliGlobali.Globals.sHS_Nome[ii], 15);
                                    VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaSeconda, iRiga, Convert.ToString(VariabiliGlobali.Globals.iHS_Punteggio[ii]), 15);
                                    VariabiliGlobali.Globals.twTesto.vScriviTesto(iColonnaTerza, iRiga, Convert.ToString(VariabiliGlobali.Globals.sHS_Livello[ii]), 15);
                                    
                                }
                        }


                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "guida" - guida

                case VariabiliGlobali.Globals.GameState.StateGuida:
                    {
                        // ** GUIDA **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background della Guida
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dBgMenu,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        // Stampa la scritta 'NumbeRun'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dScritte,
                            new Rectangle(120, 25, 440, 60),
                            new Rectangle(0, 73, 440, 60),
                            Color.White
                            );

                        // Stampa il titoletto 'GUIDA'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(18, 85, 200, 40),
                            new Rectangle(260, 40, 200, 40),
                            Color.White);

                        // Stampa il primo fiocco di neve
                        int iTileToDraw = 000;
                        iAnimazioneFiocco1++;
                        if (iAnimazioneFiocco1 == 60)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iXpositionFiocco1 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iYpositionFiocco1 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco1 = 0;
                        }
                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco1, iYpositionFiocco1, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il secondo fiocco di neve
                        iTileToDraw = 000;
                        iAnimazioneFiocco2++;
                        if (iAnimazioneFiocco2 == 65)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iXpositionFiocco2 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iYpositionFiocco2 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco2 = 0;
                        }
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco2, iYpositionFiocco2, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il testo della Guida
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dGuida,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "crediti" - crediti

                case VariabiliGlobali.Globals.GameState.StateCrediti:
                    {
                        // ** CREDITI **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background dell'High Score
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dBgMenu,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        // Stampa la scritta 'NumbeRun'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dScritte,
                            new Rectangle(120, 25, 440, 60),
                            new Rectangle(0, 73, 440, 60),
                            Color.White
                            );

                        // Stampa il titoletto 'CREDITI'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTextMenu,
                            new Rectangle(18, 85, 200, 40),
                            new Rectangle(260, 80, 200, 40),
                            Color.White);

                        // Stampa il primo fiocco di neve
                        int iTileToDraw = 000;
                        iAnimazioneFiocco1++;
                        if (iAnimazioneFiocco1 == 60)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iXpositionFiocco1 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(0, 10); i++)
                                iYpositionFiocco1 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco1 = 0;
                        }
                        Rectangle _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco1, iYpositionFiocco1, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il secondo fiocco di neve
                        iTileToDraw = 000;
                        iAnimazioneFiocco2++;
                        if (iAnimazioneFiocco2 == 65)
                        {
                            Random rRandom = new Random();
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iXpositionFiocco2 = rRandom.Next(120, 120 + 440);
                            for (int i = -1; i <= rRandom.Next(5, 15); i++)
                                iYpositionFiocco2 = rRandom.Next(25, 25 + 60);
                            iAnimazioneFiocco2 = 0;
                        }
                        _recSource = new Rectangle((iTileToDraw % VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileWidth,
                                                                        (iTileToDraw / VariabiliGlobali.Globals.iTileSetXCount) * VariabiliGlobali.Globals.myMaps.iTileHeight,
                                                                        VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight);
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dTileSetOther,
                            new Rectangle(iXpositionFiocco2, iYpositionFiocco2, VariabiliGlobali.Globals.myMaps.iTileWidth, VariabiliGlobali.Globals.myMaps.iTileHeight),
                            _recSource,
                            Color.White);

                        // Stampa il testo dei Crediti
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dCrediti,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "game_over" - game over

                case VariabiliGlobali.Globals.GameState.StateGameOver:
                    {
                        // ** GAME OVER **

                        VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

                        // Stampa il background
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dBgMenu,
                            new Rectangle(0, 0, 640, 480),
                            Color.White);

                        // Stampa della scritta 'Game Over'
                        VariabiliGlobali.Globals.spriteBatch.Draw(
                            VariabiliGlobali.Globals.t2dScritte,
                            new Rectangle(53, 150, 555, 153),
                            new Rectangle(0, 135, 555, 153),
                            Color.White);

                        // Stampa la scritta 'Player Score:'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(280, 390, VariabiliGlobali.Globals.iScoreTOT.ToString(), 15);
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(VariabiliGlobali.Globals.twTesto.iPosizioneX - 155, VariabiliGlobali.Globals.twTesto.iPosizioneY, "Player Score:", 10);

                        // Stampa la scritta 'Monster Score:'
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(280, 420, VariabiliGlobali.Globals.iScoreMostriTOT.ToString(), 15);
                        VariabiliGlobali.Globals.twTesto.vScriviTesto(VariabiliGlobali.Globals.twTesto.iPosizioneX - 155, VariabiliGlobali.Globals.twTesto.iPosizioneY, "Monster Score:", 10);
                       
                        VariabiliGlobali.Globals.spriteBatch.End();

                        break;
                    }

                #endregion

                #region "esci" - esci

                case VariabiliGlobali.Globals.GameState.StateEsci:
                    {
                        // ** ESCI **

                        this.Dispose();

                        this.Exit();

                        break;
                    }

                #endregion
            }
            base.Draw(gameTime);
        }
    }
}