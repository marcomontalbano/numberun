using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using VariabiliGlobali;


public class MlaRun
{

    #region variabili

    /// <summary>
    /// Indica la potenza del mostro. I gradi vanno da 1 a 5 (cinque mostri diversi nel gioco).
    /// </summary>
    public int iPotenza = 0;

    /// <summary>
    /// Velocità dei movimenti dei mostri.
    /// </summary>
    public double iVelocity = 0;

    /// <summary>
    /// Indica se il mostro è stato selezionato
    /// </summary>
    public bool bSelezionato = false;

    /// <summary>
    /// Texture contenente l'immagine del mostro
    /// </summary>
    public Texture2D t2dMonsterAvatar;

    // Per i passi del personaggio
    public static bool bAvanti = true;

    // Player Avatar Information
    public int iPlayerAvatarXOffset = 10;
    public int iPlayerAvaterYOffset = 5;

    public int iPlayerAvatarXframe = 0;
    public int iPlayerAvatarYframe = 0;

    // Player Avatar Grandezza
    public int iPlayerAvatarWidth = 24;
    public int iPlayerAvatarHeight = 32;

    // Player Avatar Posizione
    //public int iPlayerAvatarX;
    //public int iPlayerAvatarY;

    #endregion


    public MlaRun(int _iPotenza)
    {

        // Imposta la potenza del mostro
        vImpostaPotenza(_iPotenza);

    }

    /// <summary>
    /// Imposta la potenza del mostro. I gradi vanno da 1 a 5 (cinque mostri diversi nel gioco).
    /// </summary>
    public void vImpostaPotenza(int _iPotenza)
    {
        iPotenza = _iPotenza;

        switch (iPotenza)
        {
            case 1:
                {
                    // Imposta la velocità del mostro
                    iVelocity = 0.22;

                    break;
                }
            case 2:
                {
                    // Imposta la velocità del mostro
                    iVelocity = 0.14;

                    break;
                }
        }
    }

    /// <summary>
    /// Controlla le direzioni per cui può e non può passare il personaggio.
    /// </summary>
    /// <param name="Direzioni">Proprietà 'direzioni' dell'oggetto.</param>
    /// <param name="iIndiceDiRitorno">Lato che si vuole controllare.</param>
    /// <returns>TRUE se il lato che si vuole controllare è percorribile dal personaggio.</returns>
    public bool bControllaDirezioni(char Direzioni, int iIndiceDiRitorno)
    {
        // converte il carattere che indica la proprietà di passaggio sull'oggetto in intero interpretabile.
        int iDirezioni = Convert.ToInt32(Direzioni) - 97;

        // genera vettore booleano con 4 posizioni a true (i quattro movimenti possibili)
        bool[] bDirezioni = { true, true, true, true };

        // controllo della proprietà di passaggio sull'oggetto
        switch (iDirezioni)
        {
            // UP
            case (1):
                {
                    bDirezioni[0] = false;
                    break;
                }
            // DOWN
            case (2):
                {
                    bDirezioni[1] = false;
                    break;
                }
            // DOWN + UP
            case (3):
                {
                    bDirezioni[1] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // RIGHT
            case (4):
                {
                    bDirezioni[2] = false;
                    break;
                }
            // RIGHT + UP
            case (5):
                {
                    bDirezioni[2] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // RIGHT + DOWN
            case (6):
                {
                    bDirezioni[2] = false;
                    bDirezioni[1] = false;
                    break;
                }
            // RIGHT + DOWN + UP
            case (7):
                {
                    bDirezioni[2] = false;
                    bDirezioni[1] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // LEFT
            case (8):
                {
                    bDirezioni[3] = false;
                    break;
                }
            // LEFT + UP
            case (9):
                {
                    bDirezioni[3] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // LEFT + DOWN
            case (10):
                {
                    bDirezioni[3] = false;
                    bDirezioni[1] = false;
                    break;
                }
            // LEFT + DOWN + UP
            case (11):
                {
                    bDirezioni[3] = false;
                    bDirezioni[1] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // LEFT + RIGHT
            case (12):
                {
                    bDirezioni[3] = false;
                    bDirezioni[2] = false;
                    break;
                }
            // LEFT + RIGHT + UP
            case (13):
                {
                    bDirezioni[3] = false;
                    bDirezioni[2] = false;
                    bDirezioni[0] = false;
                    break;
                }
            // LEFT + RIGHT + DOWN
            case (14):
                {
                    bDirezioni[3] = false;
                    bDirezioni[2] = false;
                    bDirezioni[1] = false;
                    break;
                }
            // LEFT + RIGHT + DOWN + UP
            case (15):
                {
                    bDirezioni[3] = false;
                    bDirezioni[2] = false;
                    bDirezioni[1] = false;
                    bDirezioni[0] = false;
                    break;
                }
        }
        return bDirezioni[iIndiceDiRitorno];
    }

    /// <summary>
    /// Gestisce la collisione del personaggio
    /// </summary>
    private bool vGestisciCollisione(int Ylast, int Xlast, int iDir)
    {
        bool bMovimentoConsentito = false;

        // **NB**   i numeri addizionati ai Y-X last, fanno in modo ke il punto di riferimento del
        //          personaggio non sia sopra la testa (in alto a sinistra), ma ke sia circa un
        //          quadrato a metà busto.

        // Collisione contro gli oggetti
        bMovimentoConsentito = bControllaDirezioni(VariabiliGlobali.Globals.myMaps.cMapWalkable[Ylast, Xlast], iDir);

        // Controlla la matrice della mappa
        int iCollisioneDaControllare_M = VariabiliGlobali.Globals.myMaps.iMap[Ylast, Xlast];
        // Controlla la matrice degli oggetti
        int iCollisioneDaControllare = VariabiliGlobali.Globals.myMaps.iMapTrans[Ylast, Xlast];
        // Controlla la matrice dei personaggi
        int iCollisioneDaControllare_P = VariabiliGlobali.Globals.myMaps.iMapObjects[Ylast, Xlast];

        // Caso di collisione contro altri mostri
        if ((iCollisioneDaControllare_P == 002) || (iCollisioneDaControllare_P == 003) ||
            (iCollisioneDaControllare_P == 004) || (iCollisioneDaControllare_P == 005) ||
            (iCollisioneDaControllare_P == 006) || (iCollisioneDaControllare_P == 007) ||
            (iCollisioneDaControllare_P == 008) || (iCollisioneDaControllare_P == 009) ||
            (iCollisioneDaControllare_P == 010) || (iCollisioneDaControllare_P == 011))
        {
            bMovimentoConsentito = false;
        }

        // Caso di collisione cotro 1.ostacoli, 2.crystal potion, 3.porta
        if (
            (iCollisioneDaControllare == 020) ||    // Teschio1
            (iCollisioneDaControllare == 021) ||    // Teschio2
            (iCollisioneDaControllare == 045) ||    // Spuntoni
            (iCollisioneDaControllare == 024) ||    // Ostacoli
            (iCollisioneDaControllare_M == 096) ||    // Ostacoli
            (iCollisioneDaControllare == 015) ||    // Crystal Potion
            (iCollisioneDaControllare == 040) ||    // Fuoco
            (iCollisioneDaControllare == 016)       // Porta
            )
        {
            bMovimentoConsentito = false;
        }

        // Caso di collisione contro tesori
        if (iCollisioneDaControllare == 014)
        {
            VariabiliGlobali.Globals.myMaps.iMapTrans[Ylast, Xlast] = 0;
            VariabiliGlobali.Globals.iScoreMostri += 10;
            VariabiliGlobali.Globals.iScoreMostriTOT += 10;
            bMovimentoConsentito = true;
        }

        // Caso collisione contro personaggio
        Xlast -= 10;
        Ylast -= 5;
        if ((Xlast == VariabiliGlobali.Globals.myMaps.iMapX) && (Ylast == VariabiliGlobali.Globals.myMaps.iMapY))
        {
            Music.Play("-1Life");
            VariabiliGlobali.Globals.bCollisione = true;
        }

        return bMovimentoConsentito;
    }

    //Update the Personaggio Walking
    private double mPersonaggioHeadBobElapsed = 0; //Track the amount of time between the Personaggio walking frames
    private double mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
    private void UpdatePersonaggioWalking(double elapsed)
    {
        //If the wizard is currently walking then switch between his frames. The Personaggio's head
        //bobs around as he shuffle along. To make sure this happens in a slower manner, an elapsed
        //time is used to determine whether it's time to switch to the new frame or not
        mPersonaggioHeadBobElapsed += elapsed;

        //If enough time has passed, then switch to the next frame of the walking Personaggio
        if (mPersonaggioHeadBobElapsed >= mPersonaggioHeadBobElapsedCONFRONTO)
        {
            //Reset the elapsed time
            mPersonaggioHeadBobElapsed = 0;

            if (bAvanti == true)
            {
                //Switch between the two frames by setting the X position of the Texture start. 
                if (iPlayerAvatarXframe == iPlayerAvatarWidth * 2)
                {
                    // Mette il personaggio nella posizione ferma (con i piedi paralleli)
                    iPlayerAvatarXframe = iPlayerAvatarWidth;
                    bAvanti = false;
                }
                else
                {
                    // Passo 2°
                    iPlayerAvatarXframe = iPlayerAvatarWidth * 2;
                }//End if (mSprites.Sprites["Personaggio"].TexturePositionX == 0)
            }
            else
            {
                //Switch between the two frames by setting the X position of the Texture start. 
                if (iPlayerAvatarXframe == 0)
                {
                    // Mette il personaggio nella posizione ferma (con i piedi paralleli)
                    iPlayerAvatarXframe = iPlayerAvatarWidth;
                    bAvanti = true;
                }
                else
                {
                    // Passo 1°
                    iPlayerAvatarXframe = 0;
                }//End if (mSprites.Sprites["Personaggio"].TexturePositionX == 0)
            }
        }//if (mPersonaggioHeadBobElapsed > 0.2)
    }

    double elapsed = 0;
    /// <summary>
    /// Gestisce lo scroll dello scenario sotto i piedi del personaggio
    /// </summary>
    public void vMuoviPersonaggio(double gameTimeSeconds, int iNumeroMostro, int iPlayerAvatarX, int iPlayerAvatarY, int iPlayerAvatarXOffset, int iPlayerAvatarYOffset)
    {
        VariabiliGlobali.Globals.ksKeyboardState = Keyboard.GetState();

        //RANDOM CASUALE
        //Random rRandom = new Random(Convert.ToInt32(DateTime.Now.Millisecond));
        Random rRandom = new Random(unchecked((int)DateTime.Now.Ticks));
        int mov = 0;
        for(int i = -1; i <= iNumeroMostro; i++ )
            mov = rRandom.Next(1, 5);

        elapsed += gameTimeSeconds;

        // If we AREN'T in the process of completing a smooth-scroll move...
        //if (VariabiliGlobali.Globals.myMaps.iMoveCount <= 0)
        if (elapsed > iVelocity)
        {
            elapsed = 0;
            //Decide which action needs updated based on the current state of the Personaggio
            if ((mov == 1) ||
                (mov == 2) ||
                (mov == 3) ||
                (mov == 4)
                )
            {
                //The Personaggio is currently walking
                UpdatePersonaggioWalking(gameTimeSeconds);
            }
            else
            {
                // Mette il personaggio nella posizione ferma (con i piedi paralleli)
                iPlayerAvatarXframe = 0;
            }

            // Check to see if an arrow key is pressed.  If so, set the
            // iMoveDirection to indicate the direction we will be moving in,
            // and the iMoveCount to how many times we need to execute.

            // UP
            if (mov == 1)
            {
                // Controllo dell'eventuale collisione
                if (vGestisciCollisione((iPlayerAvatarY + iPlayerAvatarYOffset) - 1, (iPlayerAvatarX + iPlayerAvatarXOffset), 0) == true)
                {
                    if (iPlayerAvatarY > 0)
                    {
                        // Cancello immagine precedente
                        VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = 000;

                        // Stampo immagine in postazione nuova
                        iPlayerAvatarY -= 1;
                        VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = iNumeroMostro + 002;

                        // Imposta la velocità di movimento delle gambe del personaggio
                        mPersonaggioHeadBobElapsedCONFRONTO = 0;
                    }
                    else
                    {
                        // Imposta la velocità di movimento delle gambe del personaggio
                        mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                    }
                }
                else
                {
                    // Imposta la velocità di movimento delle gambe del personaggio
                    mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                }

                // Imposta il frame Y da visualizzare
                iPlayerAvatarYframe = iPlayerAvatarHeight * 0;
            }
            else
                // DOWN
                if (mov == 2)
                {
                    // Controllo dell'eventuale collisione
                    if (vGestisciCollisione((iPlayerAvatarY + iPlayerAvatarYOffset) + 1, (iPlayerAvatarX + iPlayerAvatarXOffset), 1) == true)
                    {
                        if (iPlayerAvatarY < (VariabiliGlobali.Globals.myMaps.MapHeight - VariabiliGlobali.Globals.myMaps.iMapDisplayHeight))
                        {
                            // Cancello immagine precedente
                            VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = 000;

                            // Stampo immagine in postazione nuova
                            iPlayerAvatarY += 1;
                            VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = iNumeroMostro + 002;

                            // Imposta la velocità di movimento delle gambe del personaggio
                            mPersonaggioHeadBobElapsedCONFRONTO = 0;
                        }
                        else
                        {
                            // Imposta la velocità di movimento delle gambe del personaggio
                            mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                        }
                    }
                    else
                    {
                        // Imposta la velocità di movimento delle gambe del personaggio
                        mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                    }


                    // Imposta il frame Y da visualizzare
                    iPlayerAvatarYframe = iPlayerAvatarHeight * 2 + 1;
                }
                else
                    // SX
                    if (mov == 3)
                    {
                        // Controllo dell'eventuale collisione
                        if (vGestisciCollisione((iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset) - 1, 3) == true)
                        {
                            if (iPlayerAvatarX > 0)
                            {
                                // Cancello immagine precedente
                                VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = 000;

                                // Stampo immagine in postazione nuova
                                iPlayerAvatarX -= 1;
                                VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = iNumeroMostro + 002;

                                // Imposta la velocità di movimento delle gambe del personaggio
                                mPersonaggioHeadBobElapsedCONFRONTO = 0;
                            }
                            else
                            {
                                // Imposta la velocità di movimento delle gambe del personaggio
                                mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                            }
                        }
                        else
                        {
                            // Imposta la velocità di movimento delle gambe del personaggio
                            mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                        }

                        // Imposta il frame Y da visualizzare
                        iPlayerAvatarYframe = iPlayerAvatarHeight * 3 + 1;
                    }
                    else
                        // DX
                        if (mov == 4)
                        {
                            // Controllo dell'eventuale collisione
                            if (vGestisciCollisione((iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset) + 1, 2) == true)
                            {
                                if (iPlayerAvatarX < (VariabiliGlobali.Globals.myMaps.MapWidth - VariabiliGlobali.Globals.myMaps.iMapDisplayWidth))
                                {
                                    // Cancello immagine precedente
                                    VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = 000;

                                    // Stampo immagine in postazione nuova
                                    iPlayerAvatarX += 1;
                                    VariabiliGlobali.Globals.myMaps.iMapObjects[(iPlayerAvatarY + iPlayerAvatarYOffset), (iPlayerAvatarX + iPlayerAvatarXOffset)] = iNumeroMostro + 002;

                                    // Imposta la velocità di movimento delle gambe del personaggio
                                    mPersonaggioHeadBobElapsedCONFRONTO = 0;
                                }
                                else
                                {
                                    // Imposta la velocità di movimento delle gambe del personaggio
                                    mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                                }
                            }
                            else
                            {
                                // Imposta la velocità di movimento delle gambe del personaggio
                                mPersonaggioHeadBobElapsedCONFRONTO = 0.2;
                            }

                            // Imposta il frame Y da visualizzare
                            iPlayerAvatarYframe = iPlayerAvatarHeight * 1 + 1;
                        }
        }

        VariabiliGlobali.Globals.myMonster[iNumeroMostro].iPlayerAvatarX = iPlayerAvatarX;
        VariabiliGlobali.Globals.myMonster[iNumeroMostro].iPlayerAvatarY = iPlayerAvatarY;
    }
}

