using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

using VariabiliGlobali;


public class Monster
{
    #region variabili

    // Elenco dei mostri
    public MlaRun MlaRun_;
    public MlaRun TrollRun_;
    public CybeRun CybeRun_;
    public PhantRun PhantRun_;
    public DevilRun DevilRun_;

    /// <summary>
    /// Indica il numero del mostro, visualizzato sulla matrice.
    /// </summary>
    public int iNumeroMostro = 0;

    // Player Avatar Grandezza
    public int iPlayerAvatarWidth = 24;
    public int iPlayerAvatarHeight = 32;

    // Player Avatar Information
    public int iPlayerAvatarXOffset = 10;
    public int iPlayerAvaterYOffset = 5;

    // Player Avatar Posizione
    public int iPlayerAvatarX;
    public int iPlayerAvatarY;

    #endregion

    public Monster()
    {

    }

    public Monster(int iNumMonster)
    {

        MlaRun_ = new MlaRun(1);
        TrollRun_ = new MlaRun(2);
        CybeRun_ = new CybeRun();
        PhantRun_ = new PhantRun();
        DevilRun_ = new DevilRun();

        iNumeroMostro = iNumMonster;
    }

    public void vMuoviPersonaggio(double gameTimeSeconds)
    {
        if (this.MlaRun_.bSelezionato == true)
        {
            this.MlaRun_.vMuoviPersonaggio(gameTimeSeconds, iNumeroMostro, iPlayerAvatarX, iPlayerAvatarY, iPlayerAvatarXOffset, iPlayerAvaterYOffset);
        } else
        if (this.TrollRun_.bSelezionato == true)
        {
            this.TrollRun_.vMuoviPersonaggio(gameTimeSeconds, iNumeroMostro, iPlayerAvatarX, iPlayerAvatarY, iPlayerAvatarXOffset, iPlayerAvaterYOffset);
        } else
        if (this.CybeRun_.bSelezionato == true)
        {
            this.CybeRun_.vMuoviPersonaggio(gameTimeSeconds, iNumeroMostro, iPlayerAvatarX, iPlayerAvatarY, iPlayerAvatarXOffset, iPlayerAvaterYOffset);
        } else
        if (this.PhantRun_.bSelezionato == true)
        {
            this.PhantRun_.vMuoviPersonaggio(gameTimeSeconds, iNumeroMostro, iPlayerAvatarX, iPlayerAvatarY, iPlayerAvatarXOffset, iPlayerAvaterYOffset);
        } else
        if (this.DevilRun_.bSelezionato == true)
        {
            this.DevilRun_.vMuoviPersonaggio(gameTimeSeconds, iNumeroMostro, iPlayerAvatarX, iPlayerAvatarY, iPlayerAvatarXOffset, iPlayerAvaterYOffset);
        }
    }

    /// <summary>
    /// Controlla il grado di potenza del mostro e gli attribuisce la texture adatta
    /// </summary>
    /// <param name="iNumMostro">Numero del mostro di cui si vuole controllarne la potenza</param>
    /// <returns>Texture del mostro, in proporzione alla sua potenza</returns>
    public Texture2D t2dLoadMonsterTexture()
    {
        if (this.MlaRun_.bSelezionato == true)
        {
            return MlaRun_.t2dMonsterAvatar;
        }
        else
            if (this.TrollRun_.bSelezionato == true)
            {
                return TrollRun_.t2dMonsterAvatar;
            }
            else
                if (this.CybeRun_.bSelezionato == true)
                {
                    return CybeRun_.t2dMonsterAvatar;
                }
                else
                    if (this.PhantRun_.bSelezionato == true)
                    {
                        return PhantRun_.t2dMonsterAvatar;
                    }
                    else
                        if (this.DevilRun_.bSelezionato == true)
                        {
                            return DevilRun_.t2dMonsterAvatar;
                        }
                        else
                            return null;
    }

    public void vLoadMonsterTexture()
    {
        // "Texture2D" -> Mostro1
        this.MlaRun_.t2dMonsterAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\mostro1");
        // "Texture2D" -> Mostro2
        this.TrollRun_.t2dMonsterAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\mostro2");
        // "Texture2D" -> Mostro3
        this.CybeRun_.t2dMonsterAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\mostro3");
        // "Texture2D" -> Mostro4
        this.PhantRun_.t2dMonsterAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\mostro4");
        // "Texture2D" -> Mostro5
        this.DevilRun_.t2dMonsterAvatar = VariabiliGlobali.Globals.content.Load<Texture2D>(@"textures\mostro5");
    }

    /// <summary>
    /// Funziona che ritorna l'X e Y del frame, del mostro selezionato
    /// </summary>
    /// <param name="cAsse">X  /  Y  (asse)</param>
    /// <returns>Frame del mostro selezionato</returns>
    public int iReturnMonsterAvatarFrame(char cAsse)
    {
        if (cAsse == 'X')
        {
            if (this.MlaRun_.bSelezionato == true)
            {
                return this.MlaRun_.iPlayerAvatarXframe;
            }
            if (this.TrollRun_.bSelezionato == true)
            {
                return this.TrollRun_.iPlayerAvatarXframe;
            }
            if (this.CybeRun_.bSelezionato == true)
            {
                return this.CybeRun_.iPlayerAvatarXframe;
            }
            if (this.PhantRun_.bSelezionato == true)
            {
                return this.PhantRun_.iPlayerAvatarXframe;
            }
            if (this.DevilRun_.bSelezionato == true)
            {
                return this.DevilRun_.iPlayerAvatarXframe;
            }
        }
        if (cAsse == 'Y')
        {
            if (this.MlaRun_.bSelezionato == true)
            {
                return this.MlaRun_.iPlayerAvatarYframe;
            }
            if (this.TrollRun_.bSelezionato == true)
            {
                return this.TrollRun_.iPlayerAvatarYframe;
            }
            if (this.CybeRun_.bSelezionato == true)
            {
                return this.CybeRun_.iPlayerAvatarYframe;
            }
            if (this.PhantRun_.bSelezionato == true)
            {
                return this.PhantRun_.iPlayerAvatarYframe;
            }
            if (this.DevilRun_.bSelezionato == true)
            {
                return this.DevilRun_.iPlayerAvatarYframe;
            }
        }
        return 0;
    }
}

