using System;
using System.Collections.Generic;
using System.Text;

public class Animation
{
    #region variabili per la gestione delle animazioni

    public int iTileAnimationFrame = 0;         // The current frame of animation we are on.
    public int iTileAnimationFrameCount = 0;    // The total number of frames in our animation
    public int iTileAnimationStartFrame = 0;  // The beginning frame of our animation
    public float fAnimationTime = 0.0f;         // How much time has elapsed since we last animated
    public float fAnimationDelay = 0.0f;        // How much time needs to elapse before we animate

    public float fTotalElapsedTime = 0;

    #endregion

    /// <summary>
    /// Costruttore della classe.
    /// </summary>
    public Animation()
    {

    }

    /// <summary>
    /// Costruttore della classe
    /// </summary>
    /// <param name="_iTileAnimationStartFrame">Frame da cui parte l'animazione</param>
    /// <param name="_iTileAnimationFrameCount">Lunghezza dell'animazione (frame iniziale e finale compresi)</param>
    /// <param name="_fAnimationDelay">Ritardo dell'animazione</param>
    public Animation(int _iTileAnimationStartFrame, int _iTileAnimationFrameCount, float _fAnimationDelay)
    {
        // Imposta il frame da cui parte l'animazione
        iTileAnimationStartFrame = _iTileAnimationStartFrame;
        // Imposta la lunghezza dell'animazione
        iTileAnimationFrameCount = _iTileAnimationFrameCount;
        // Imposta il ritardo dell'animazione
        fAnimationDelay = _fAnimationDelay;
    }

    /// <summary>
    /// Aggiorna il movimento automatico dell'animazione
    /// </summary>
    public void vUpdateAnimation(double TotalSeconds)
    {
        float elapsed = (float)TotalSeconds;
        fTotalElapsedTime += elapsed;
        fAnimationTime += elapsed;

        if (fAnimationTime >= fAnimationDelay)
        {
            iTileAnimationFrame++;
            if (iTileAnimationFrame >= iTileAnimationFrameCount)
            {
                iTileAnimationFrame = 0;
            }
            fAnimationTime = 0.0f;
        }
    }
}
