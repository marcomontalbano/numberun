using System;
using System.Collections.Generic;
using System.Text;

public class Collisioni
{
    /// <summary>
    /// dimensione ChipSet - X
    /// </summary>
    public const int iTileSetXCount = 12;
    /// <summary>
    /// dimensione ChipSet - X
    /// </summary>
    public int TileSetXCount
    {
        get
        {
            return iTileSetXCount;
        }
    }

    /// <summary>
    /// dimensione ChipSet - Y
    /// </summary>
    public const int iTileSetYCount = 6;
    /// <summary>
    /// dimensione ChipSet - Y
    /// </summary>
    public int TileSetYCount
    {
        get
        {
            return iTileSetYCount;
        }
    }

    public Collisioni()
    {

    }

    /// <summary>
    /// Matrice per la fusione della collisione di due oggetti, uno sopra l'altro, su due layer diversi
    /// </summary>
    public char[,] cUnioneCollisione = new char[16, 16]
        { 
            {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p'},
            {'b','b','d','d','f','f','h','h','j','j','l','l','n','n','p','p'},
            {'c','d','c','d','g','h','g','h','k','l','k','l','o','p','o','p'},
            {'d','d','d','d','h','h','h','h','l','l','l','l','p','p','p','p'},
            {'e','f','g','h','e','f','g','h','m','n','o','p','m','n','o','p'},
            {'f','f','h','h','f','f','h','h','n','n','p','p','n','n','p','p'},
            {'g','h','g','h','g','h','g','h','o','p','o','p','o','p','o','p'},
            {'h','h','h','h','h','h','h','h','p','p','p','p','p','p','p','p'},
            {'i','j','k','l','m','n','o','p','i','j','k','l','m','n','o','p'},
            {'j','j','l','l','n','n','p','p','j','j','l','l','n','n','p','p'},
            {'k','l','k','l','o','p','o','p','k','l','k','l','o','p','o','p'},
            {'l','l','l','l','p','p','p','p','l','l','l','l','p','p','p','p'},
            {'m','n','o','p','m','n','o','p','m','n','o','p','m','n','o','p'},
            {'n','n','p','p','n','n','p','p','n','n','p','p','n','n','p','p'},
            {'o','p','o','p','o','p','o','p','o','p','o','p','o','p','o','p'},
            {'p','p','p','p','p','p','p','p','p','p','p','p','p','p','p','p'},
        };

    /// <summary>
    /// Matrice delle collisioni del ChipSet
    /// </summary>
    public int[,] iCollisioneOggetti = new int[iTileSetYCount, iTileSetXCount]
        { 
            {000,015,000,000,000,000,000,000,000,000,000,000},
            {015,000,000,000,000,000,015,000,000,000,000,000},
            {000,000,000,000,015,015,015,015,015,015,000,000},
            {000,000,000,000,015,015,015,015,000,000,000,000},
            {000,000,015,015,015,000,000,000,000,000,000,000},
            {015,015,015,015,000,000,000,000,000,000,000,000},
        };

    /// <summary>
    /// Controlla la collisione di un determinato oggetto.
    /// </summary>
    /// <param name="iNumeroOggetto">Oggetto di cui controllare la collisione</param>
    /// <returns>Numero di collisione (vedi tabella)</returns>
    public int iCollisioneOggetto(int iNumeroOggetto)
    {
        int iIndice = 0;
        int i = 0; // Y
        int j = 0; // X
        while (iIndice < iNumeroOggetto)
        {

            j++;
            if (j == TileSetXCount)
            {
                j = 0;
                i++;
            }
            iIndice++;

        }

        return iCollisioneOggetti[i, j];

    }

    public char cFusioneCollisioneOggetti(int iNumeroOggetto1, int iNumeroOggetto2)
    {
        int iCollisione1 = iCollisioneOggetto(iNumeroOggetto1);
        int iCollisione2 = iCollisioneOggetto(iNumeroOggetto2);

        return cUnioneCollisione[iCollisione1, iCollisione2];
    }
}

/*
*
*	direzioni per cui non puoi muoverti nell'oggetto:
*
*	00 = valicabile					a = valicabile
*	01 = UP							b = UP
*	02 = DOWN						c = DOWN
*	03 = DOWN + UP					d = DOWN + UP
*	04 = RIGHT						e = RIGHT
*	05 = RIGHT + UP					f = RIGHT + UP
*	06 = RIGHT + DOWN				g = RIGHT + DOWN
*	07 = RIGHT + DOWN + UP			h = RIGHT + DOWN + UP
*	08 = LEFT						i = LEFT
*	09 = LEFT + UP					j = LEFT + UP
*	10 = LEFT + DOWN				k = LEFT + DOWN
*	11 = LEFT + DOWN + UP			l = LEFT + DOWN + UP
*	12 = LEFT + RIGHT				m = LEFT + RIGHT
*	13 = LEFT + RIGHT + UP			n = LEFT + RIGHT + UP
*	14 = LEFT + RIGHT + DOWN		o = LEFT + RIGHT + DOWN
*	15 = LEFT + RIGHT + DOWN + UP	p = LEFT + RIGHT + DOWN + UP
*	
*/
