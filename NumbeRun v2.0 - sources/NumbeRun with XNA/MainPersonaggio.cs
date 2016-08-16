using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using VariabiliGlobali;


public class MainPersonaggio
{
    #region variabili

    /// <summary>
    /// Texture contenente del personaggio principale (quello da controllare)
    /// </summary>
    public Texture2D t2dPlayerAvatar;

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

    #endregion


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
    private bool vGestisciCollisione(int Xlast, int Ylast, int iDir)
    {
        bool MovimentoConsentito = false;

        // **NB**   i numeri addizionati ai Y-X last, fanno in modo ke il punto di riferimento del
        //          personaggio non sia sopra la testa (in alto a sinistra), ma ke sia circa un
        //          quadrato a metà busto.

        MovimentoConsentito = bControllaDirezioni(VariabiliGlobali.Globals.myMaps.cMapWalkable[Xlast, Ylast], iDir);

        return MovimentoConsentito;
    }

    /// <summary>
    /// Gestisce la collisione del personaggio con eventuali tesori
    /// </summary>
    private void vCollisioneTesori(int Xlast, int Ylast)
    {
        if (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 014)
        {
            Music.Play("Tesori");
            VariabiliGlobali.Globals.iScore += 10;
            VariabiliGlobali.Globals.iScoreTOT += 10;
            VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] = 000;
        }
    }

    /// <summary>
    /// Gestisce la collisione del personaggio con eventuali tesori
    /// </summary>
    private void vCollisioneOstacoli(int Xlast, int Ylast)
    {
        if (
            (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 020) ||
            (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 021) ||
            (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 024) ||
            (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 040) ||
            (VariabiliGlobali.Globals.myMaps.iMap[Xlast, Ylast] == 096) ||
            (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 045)
            )
        {
            if ((VariabiliGlobali.Globals.iCrystalPotion > 0) && (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 024))
            {
                Music.Play("UseCrystalPotion");
                VariabiliGlobali.Globals.iCrystalPotion -= 1;
                VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] = 000;
            }
            else
            {
                Music.Play("-1Life");
                VariabiliGlobali.Globals.bCollisione = true;
            }
        }
    }

    /// <summary>
    /// Gestisce la collisione del personaggio con i mostri
    /// </summary>
    private void vCollisioneMostri(int Xlast, int Ylast)
    {
        // Controlla la matrice dei personaggi
        int iCollisioneDaControllare_P = VariabiliGlobali.Globals.myMaps.iMapObjects[Xlast, Ylast];

        // Caso di collisione contro altri mostri
        if ((iCollisioneDaControllare_P == 002) || (iCollisioneDaControllare_P == 003) ||
            (iCollisioneDaControllare_P == 004) || (iCollisioneDaControllare_P == 005) ||
            (iCollisioneDaControllare_P == 006) || (iCollisioneDaControllare_P == 007) ||
            (iCollisioneDaControllare_P == 008) || (iCollisioneDaControllare_P == 009) ||
            (iCollisioneDaControllare_P == 010) || (iCollisioneDaControllare_P == 011))
        {
            Music.Play("-1Life");
            VariabiliGlobali.Globals.bCollisione = true;
        }
    }
    

    /// <summary>
    /// Gestisce la collisione del personaggio con le Crystal Potion
    /// </summary>
    private void vCollisioneCrystalPotion(int Xlast, int Ylast)
    {
        if (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 015)
        {
            Music.Play("CrystalPotion");
            VariabiliGlobali.Globals.iCrystalPotion += 1;
            VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] = 000;
        }
    }

    /// <summary>
    /// Gestisce la collisione del personaggio con la Porta
    /// </summary>
    private void vCollisionePorta(int Xlast, int Ylast)
    {
        if (VariabiliGlobali.Globals.myMaps.iMapTrans[Xlast, Ylast] == 016)
        {
            if (VariabiliGlobali.Globals.iScore > VariabiliGlobali.Globals.iScoreMostri)
            {
                Music.Play("Entra");

                // Caricamento del livello successivo
                VariabiliGlobali.Globals.iCrystalPotion = 0;
                VariabiliGlobali.Globals.iNumeroLivello++;
                VariabiliGlobali.Globals.iScore = 0;
                VariabiliGlobali.Globals.iScoreMostri = 0;
                VariabiliGlobali.Globals.bGamePause = false;
                VariabiliGlobali.Globals.myLevels.vCaricaLivello();

                // Stoppa la musica dei livelli del gioco
                Music.Stop(VariabiliGlobali.Globals.cueLevels);

            }
            else
            {
                // Trappola scattata
                Music.Play("-1Life");
                VariabiliGlobali.Globals.bCollisione = true;
            }
        }
    }

    //Update the Personaggio Walking
    private double mPersonaggioHeadBobElapsed = 0; //Track the amount of time between the Personaggio walking frames
    private double mPersonaggioHeadBobElapsedCONFRONTO = 0;
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

    /// <summary>
    /// Gestisce lo scroll dello scenario sotto i piedi del personaggio
    /// </summary>
    public void vMuoviPersonaggio(double gameTimeSeconds)
    {
        VariabiliGlobali.Globals.ksKeyboardState = Keyboard.GetState();

        // If we AREN'T in the process of completing a smooth-scroll move...
        if (VariabiliGlobali.Globals.myMaps.iMoveCount <= 0)
        {
            //Decide which action needs updated based on the current state of the Personaggio
            if ((VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Up) == true) ||
                (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Down) == true) ||
                (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Right) == true) ||
                (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Left) == true)
                )
            {
                //The Personaggio is currently walking
                UpdatePersonaggioWalking(gameTimeSeconds);
            }
            else
            {
                // Mette il personaggio nella posizione ferma (con i piedi paralleli)
               iPlayerAvatarXframe = 24;
            }

            // Check to see if an arrow key is pressed.  If so, set the
            // iMoveDirection to indicate the direction we will be moving in,
            // and the iMoveCount to how many times we need to execute.
            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Up))
            {
                // Controllo dell'eventuale collisione
                if (vGestisciCollisione((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) - 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset), 0))
                {
                    // Controllo di collisione con tesoro
                    vCollisioneTesori((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) - 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

                    // Controllo di collisione con una Crystal Potion
                    vCollisioneCrystalPotion((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) - 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

                    if (VariabiliGlobali.Globals.myMaps.iMapY > 0)
                    {
                        VariabiliGlobali.Globals.myMaps.iMoveDirection = 0;
                        VariabiliGlobali.Globals.myMaps.iMoveCount = VariabiliGlobali.Globals.myMaps.iTileHeight + VariabiliGlobali.Globals.myMaps.iMapYScrollRate;

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
            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Down))
            {
                // Controllo dell'eventuale collisione
                if (vGestisciCollisione((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) + 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset), 1))
                {
                    // Controllo di collisione con tesoro
                    vCollisioneTesori((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) + 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

                    // Controllo di collisione con una Crystal Potion
                    vCollisioneCrystalPotion((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset) + 1, (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

                    if (VariabiliGlobali.Globals.myMaps.iMapY < (VariabiliGlobali.Globals.myMaps.MapHeight - VariabiliGlobali.Globals.myMaps.iMapDisplayHeight))
                    {
                        VariabiliGlobali.Globals.myMaps.iMoveDirection = 1;
                        VariabiliGlobali.Globals.myMaps.iMoveCount = VariabiliGlobali.Globals.myMaps.iTileHeight + VariabiliGlobali.Globals.myMaps.iMapYScrollRate;

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
            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Left))
            {
                // Controllo dell'eventuale collisione
                if (vGestisciCollisione((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) - 1, 3))
                {
                    // Controllo di collisione con tesoro
                    vCollisioneTesori((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) - 1);

                    // Controllo di collisione con una Crystal Potion
                    vCollisioneCrystalPotion((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) - 1);

                    if (VariabiliGlobali.Globals.myMaps.iMapX > 0)
                    {
                        VariabiliGlobali.Globals.myMaps.iMoveDirection = 2;
                        VariabiliGlobali.Globals.myMaps.iMoveCount = VariabiliGlobali.Globals.myMaps.iTileHeight + VariabiliGlobali.Globals.myMaps.iMapXScrollRate;

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
            if (VariabiliGlobali.Globals.ksKeyboardState.IsKeyDown(Keys.Right))
            {
                // Controllo dell'eventuale collisione
                if (vGestisciCollisione((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) + 1, 2))
                {
                    // Controllo di collisione con tesoro
                    vCollisioneTesori((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) + 1);

                    // Controllo di collisione con una Crystal Potion
                    vCollisioneCrystalPotion((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset) + 1);

                    if (VariabiliGlobali.Globals.myMaps.iMapX < (VariabiliGlobali.Globals.myMaps.MapWidth - VariabiliGlobali.Globals.myMaps.iMapDisplayWidth))
                    {
                        VariabiliGlobali.Globals.myMaps.iMoveDirection = 3;
                        VariabiliGlobali.Globals.myMaps.iMoveCount = VariabiliGlobali.Globals.myMaps.iTileHeight + VariabiliGlobali.Globals.myMaps.iMapXScrollRate;

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

            // Controllo di collisione con la porta
            vCollisionePorta((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

            // Controllo di collisione con i mostri
            vCollisioneMostri((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

            // Controllo di collisione con un ostacolo
            vCollisioneOstacoli((VariabiliGlobali.Globals.myMaps.iMapY + iPlayerAvaterYOffset), (VariabiliGlobali.Globals.myMaps.iMapX + iPlayerAvatarXOffset));

        }
        else
        {
            // If we ARE in the middle of a smooth-scroll move, update the 
            // Offsets and decrement the move count.
            if (VariabiliGlobali.Globals.myMaps.iMoveDirection == 0)
            {
                VariabiliGlobali.Globals.myMaps.iMapYOffset -= VariabiliGlobali.Globals.myMaps.iMapYScrollRate;
                VariabiliGlobali.Globals.myMaps.iMoveCount -= VariabiliGlobali.Globals.myMaps.iMapYScrollRate;
            }
            if (VariabiliGlobali.Globals.myMaps.iMoveDirection == 1)
            {
                VariabiliGlobali.Globals.myMaps.iMapYOffset += VariabiliGlobali.Globals.myMaps.iMapYScrollRate;
                VariabiliGlobali.Globals.myMaps.iMoveCount -= VariabiliGlobali.Globals.myMaps.iMapYScrollRate;
            }
            if (VariabiliGlobali.Globals.myMaps.iMoveDirection == 2)
            {
                VariabiliGlobali.Globals.myMaps.iMapXOffset -= VariabiliGlobali.Globals.myMaps.iMapXScrollRate;
                VariabiliGlobali.Globals.myMaps.iMoveCount -= VariabiliGlobali.Globals.myMaps.iMapXScrollRate;
            }
            if (VariabiliGlobali.Globals.myMaps.iMoveDirection == 3)
            {
                VariabiliGlobali.Globals.myMaps.iMapXOffset += VariabiliGlobali.Globals.myMaps.iMapXScrollRate;
                VariabiliGlobali.Globals.myMaps.iMoveCount -= VariabiliGlobali.Globals.myMaps.iMapXScrollRate;
            }

            // If we move off of a tile, change our map location to the next tile
            if (VariabiliGlobali.Globals.myMaps.iMapXOffset < 0) { VariabiliGlobali.Globals.myMaps.iMapXOffset = VariabiliGlobali.Globals.myMaps.iTileWidth; VariabiliGlobali.Globals.myMaps.iMapX--; }
            if (VariabiliGlobali.Globals.myMaps.iMapXOffset > VariabiliGlobali.Globals.myMaps.iTileWidth) { VariabiliGlobali.Globals.myMaps.iMapXOffset = 0; VariabiliGlobali.Globals.myMaps.iMapX++; }
            if (VariabiliGlobali.Globals.myMaps.iMapYOffset < 0) { VariabiliGlobali.Globals.myMaps.iMapYOffset = VariabiliGlobali.Globals.myMaps.iTileHeight; VariabiliGlobali.Globals.myMaps.iMapY--; }
            if (VariabiliGlobali.Globals.myMaps.iMapYOffset > VariabiliGlobali.Globals.myMaps.iTileWidth) { VariabiliGlobali.Globals.myMaps.iMapYOffset = 0; VariabiliGlobali.Globals.myMaps.iMapY++; }


            // If we move off of the side of the map, "snap" back (player won't see a move at all)
            if (VariabiliGlobali.Globals.myMaps.iMapX < 0) { VariabiliGlobali.Globals.myMaps.iMapX = 0; VariabiliGlobali.Globals.myMaps.iMapXOffset = 0; VariabiliGlobali.Globals.myMaps.iMoveCount = 0; }
            if (VariabiliGlobali.Globals.myMaps.iMapX > VariabiliGlobali.Globals.myMaps.MapWidth - VariabiliGlobali.Globals.myMaps.iMapDisplayWidth)
            {
                VariabiliGlobali.Globals.myMaps.iMapX = VariabiliGlobali.Globals.myMaps.MapWidth - VariabiliGlobali.Globals.myMaps.iMapDisplayWidth;
                VariabiliGlobali.Globals.myMaps.iMapXOffset = 0; VariabiliGlobali.Globals.myMaps.iMoveCount = 0;
            }
            if (VariabiliGlobali.Globals.myMaps.iMapY < 0) { VariabiliGlobali.Globals.myMaps.iMapY = 0; VariabiliGlobali.Globals.myMaps.iMapYOffset = 0; VariabiliGlobali.Globals.myMaps.iMoveCount = 0; }
            if (VariabiliGlobali.Globals.myMaps.iMapY > VariabiliGlobali.Globals.myMaps.MapHeight - VariabiliGlobali.Globals.myMaps.iMapDisplayHeight)
            {
                VariabiliGlobali.Globals.myMaps.iMapY = VariabiliGlobali.Globals.myMaps.MapHeight - VariabiliGlobali.Globals.myMaps.iMapDisplayHeight;
                VariabiliGlobali.Globals.myMaps.iMapYOffset = 0; VariabiliGlobali.Globals.myMaps.iMoveCount = 0;
            }


        }
    }
}

