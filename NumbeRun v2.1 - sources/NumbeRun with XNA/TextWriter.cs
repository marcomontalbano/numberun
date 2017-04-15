
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

public class TextWriter
{
    /// <summary>
    /// Grandezza del carattere
    /// </summary>
    public int iSizeChar = 20;

    /// <summary>
    /// Spaziatura tra un carattere e l'altro
    /// </summary>
    public int iSpaziatura = 20;

    public int iPosizioneX = 100;
    public int iPosizioneY = 100;

    public char[,] cAssociazioni = new char[5, 30];

    /// <summary>
    /// Inizializza la matrice delle associazioni
    /// </summary>
    public void vInizializaAssociazioni()
    {
        // Inzializzazione di default
        for (int ii = 0; ii < 5; ii++)
            for (int jj = 0; jj < 30; jj++)
                cAssociazioni[ii, jj] = ' ';

        // Associazioni numeriche
        cAssociazioni[0, 0] = '0';
        cAssociazioni[0, 1] = '1';
        cAssociazioni[0, 2] = '2';
        cAssociazioni[0, 3] = '3';
        cAssociazioni[0, 4] = '4';
        cAssociazioni[0, 5] = '5';
        cAssociazioni[0, 6] = '6';
        cAssociazioni[0, 7] = '7';
        cAssociazioni[0, 8] = '8';
        cAssociazioni[0, 9] = '9';

        // Caratteri minuscoli
        cAssociazioni[1, 0] = 'a';
        cAssociazioni[1, 1] = 'b';
        cAssociazioni[1, 2] = 'c';
        cAssociazioni[1, 3] = 'd';
        cAssociazioni[1, 4] = 'e';
        cAssociazioni[1, 5] = 'f';
        cAssociazioni[1, 6] = 'g';
        cAssociazioni[1, 7] = 'h';
        cAssociazioni[1, 8] = 'i';
        cAssociazioni[1, 9] = 'j';
        cAssociazioni[1, 10] = 'k';
        cAssociazioni[1, 11] = 'l';
        cAssociazioni[1, 12] = 'm';
        cAssociazioni[1, 13] = 'n';
        cAssociazioni[1, 14] = 'o';
        cAssociazioni[1, 15] = 'p';
        cAssociazioni[1, 16] = 'q';
        cAssociazioni[1, 17] = 'r';
        cAssociazioni[1, 18] = 's';
        cAssociazioni[1, 19] = 't';
        cAssociazioni[1, 20] = 'u';
        cAssociazioni[1, 21] = 'v';
        cAssociazioni[1, 22] = 'w';
        cAssociazioni[1, 23] = 'x';
        cAssociazioni[1, 24] = 'y';
        cAssociazioni[1, 25] = 'z';

        // Caratteri MAIUSCOLI
        cAssociazioni[2, 0] = 'A';
        cAssociazioni[2, 1] = 'B';
        cAssociazioni[2, 2] = 'C';
        cAssociazioni[2, 3] = 'D';
        cAssociazioni[2, 4] = 'E';
        cAssociazioni[2, 5] = 'F';
        cAssociazioni[2, 6] = 'G';
        cAssociazioni[2, 7] = 'H';
        cAssociazioni[2, 8] = 'I';
        cAssociazioni[2, 9] = 'J';
        cAssociazioni[2, 10] = 'K';
        cAssociazioni[2, 11] = 'L';
        cAssociazioni[2, 12] = 'M';
        cAssociazioni[2, 13] = 'N';
        cAssociazioni[2, 14] = 'O';
        cAssociazioni[2, 15] = 'P';
        cAssociazioni[2, 16] = 'Q';
        cAssociazioni[2, 17] = 'R';
        cAssociazioni[2, 18] = 'S';
        cAssociazioni[2, 19] = 'T';
        cAssociazioni[2, 20] = 'U';
        cAssociazioni[2, 21] = 'V';
        cAssociazioni[2, 22] = 'W';
        cAssociazioni[2, 23] = 'X';
        cAssociazioni[2, 24] = 'Y';
        cAssociazioni[2, 25] = 'Z';

        // Simboli
        cAssociazioni[3, 0] = 'à';
        cAssociazioni[3, 1] = 'è';
        cAssociazioni[3, 2] = 'ì';
        cAssociazioni[3, 3] = 'ò';
        cAssociazioni[3, 4] = 'ù';
        cAssociazioni[3, 5] = ',';
        cAssociazioni[3, 6] = '.';
        cAssociazioni[3, 7] = '-';
        cAssociazioni[3, 8] = ';';
        cAssociazioni[3, 9] = ':';
        cAssociazioni[3, 10] = '_';
        cAssociazioni[3, 11] = '<';
        cAssociazioni[3, 12] = '>';
        cAssociazioni[3, 13] = ' ';
        cAssociazioni[3, 14] = '°';
        cAssociazioni[3, 15] = 'ç';
        cAssociazioni[3, 16] = '[';
        cAssociazioni[3, 17] = ']';
        cAssociazioni[3, 18] = '#';
        cAssociazioni[3, 19] = '\\';
        cAssociazioni[3, 20] = '|';
        cAssociazioni[3, 21] = '+';
        cAssociazioni[3, 22] = '*';
        cAssociazioni[3, 23] = '/';
        cAssociazioni[3, 24] = '!';
        cAssociazioni[3, 25] = '$';
        cAssociazioni[3, 26] = '%';
        cAssociazioni[3, 27] = '&';
        cAssociazioni[3, 28] = '(';
        cAssociazioni[3, 29] = ')';
    }

    /// <summary>
    /// Creatore della classe
    /// </summary>
    public TextWriter()
    {
        vInizializaAssociazioni();
    }

    /// <summary>
    /// Creatore della classe
    /// </summary>
    /// <param name="_iPosizioneX">X dell'oggetto</param>
    /// <param name="_iPosizioneY">Y dell'oggetto</param>
    public TextWriter(int _iPosizioneX, int _iPosizioneY)
    {
        vInizializaAssociazioni();
        iPosizioneX = _iPosizioneX;
        iPosizioneY = _iPosizioneY;
    }

    public TextWriter(int _iPosizioneX, int _iPosizioneY, string sFraseDaScrivere)
    {
        vInizializaAssociazioni();
        iPosizioneX = _iPosizioneX;
        iPosizioneY = _iPosizioneY;
        vScrivi(sFraseDaScrivere);
    }
    
    public TextWriter(int _iPosizioneX, int _iPosizioneY, string sFraseDaScrivere, int _iSpaziatura)
    {
        vInizializaAssociazioni();
        iPosizioneX = _iPosizioneX;
        iPosizioneY = _iPosizioneY;
        iSpaziatura = _iSpaziatura;
        vScrivi(sFraseDaScrivere);
    }

    public void vScriviTesto(int _iPosizioneX, int _iPosizioneY, string sFraseDaScrivere, int _iSpaziatura)
    {
        vInizializaAssociazioni();
        iPosizioneX = _iPosizioneX;
        iPosizioneY = _iPosizioneY;
        iSpaziatura = _iSpaziatura;
        vScrivi(sFraseDaScrivere);
    }

    // VariabiliGlobali.Globals.t2dTextSet

    /// <summary>
    /// Scrive la frase a video in posizione iPosizioneX, iPosizioneY.
    /// </summary>
    /// <param name="sFraseDaScrivere">Frase che si vuole visualizzare</param>
    /// <param name="iTipo">Tipo di frase: 1->numero, 2->stringa</param>
    private void vScrivi(string sFraseDaScrivere)
    {
        //VariabiliGlobali.Globals.spriteBatch.Begin(SpriteBlendMode.AlphaBlend);

        int iYframe = 0;
        int iXframe = 0;

        int iSpaziaturaOLD = iSpaziatura;
        int iIncremento = 0;
        if (sFraseDaScrivere != null)
        {
            for (int i = 0; i < sFraseDaScrivere.Length; i++)
            {
                for (int ii = 0; ii < 5; ii++)
                {
                    for (int jj = 0; jj < 30; jj++)
                    {
                        if (cAssociazioni[ii, jj].Equals(sFraseDaScrivere[i]))
                        {
                            iYframe = ii;
                            iXframe = jj;

                        }
                    }
                }

                // Se la prima lettera è maiuscola, aumenta automaticamente la spaziatura
                bool bIncremento = false;
                if (iYframe == 2)
                {
                    bIncremento = true;
                }

                // Stampa del char
                VariabiliGlobali.Globals.spriteBatch.Draw(
                    VariabiliGlobali.Globals.t2dTextSet,
                    new Rectangle(iPosizioneX + (iSpaziatura * i) + iIncremento, iPosizioneY, iSizeChar, iSizeChar),
                    new Rectangle((iXframe * iSizeChar), (iYframe * iSizeChar), iSizeChar, iSizeChar),
                    Color.White
                    );


                if (bIncremento == true)
                    iIncremento += 2;
            }
        }


        //VariabiliGlobali.Globals.spriteBatch.End();
    }
}

