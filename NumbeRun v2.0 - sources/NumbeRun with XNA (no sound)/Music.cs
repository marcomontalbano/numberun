
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

class Music
{

    private static AudioEngine engine;
    private static WaveBank wavebank;
    private static SoundBank soundbank;

    public static Cue Play(string name)
    {
        Cue returnValue = soundbank.GetCue(name);
        returnValue.Play();
        return returnValue;
    }

    public static Cue PlayLoop(string name, Cue cue)
    {
        if (cue == null)
        {
            Cue returnValue = soundbank.GetCue(name);
            returnValue.Play();
            return returnValue;
        } else
        if (cue.IsPlaying == false)
        {
            Stop(cue);
            cue.Dispose();
            Cue cueNew = soundbank.GetCue(name);
            cueNew.Play();
            return cueNew;
        } else
            return cue;
    }

    public static void Stop(Cue cue)
    {
        if (cue != null)
        {
            cue.Stop(AudioStopOptions.Immediate);
        }        
    }

    /// <summary>
    /// Starts up the sound code
    /// </summary>
    public static void Initialize()
    {
        engine = new AudioEngine("NumbeRun_music.xgs");
        wavebank = new WaveBank(engine, "Wave Bank.xwb");
        soundbank = new SoundBank(engine, "Sound Bank.xsb");
    }

    public static void Update()  //  Added
    {
        engine.Update();
    }

    public static bool GetIsDisposed()  //  Added
    {
        return engine.IsDisposed;
    }

    /// <summary>
    /// Shuts down the sound code tidily
    /// </summary>
    public static void Shutdown()
    {
        soundbank.Dispose();
        wavebank.Dispose();
        engine.Dispose();
    }

}

