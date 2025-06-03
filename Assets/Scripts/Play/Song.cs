using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Song : MonoBehaviour
{
    public float bpm = 60.0f;
    public int Tackt = 4;
    public bool isTab = false;
    public int[] ttPage;
    public List<int> TabLad;
    public List<int> TabRaw;
    public List<Sprite> TabSprites;
    public List<string> acords;
    public Sprite biy;
    // setet by cod
    public Metronome metronome;
    public GuitarLads gl;
    public Image TabsIm;
    public Image BiyIm;
    public TMP_Text Acord;
    public TMP_Text NextAcord;

    int thisTakt = 0;
    int index = 0;
    int TABindex = 0;

    public void Go()
    {
        metronome.song = this;
        metronome.bpm = bpm;
        metronome.beatsPerMeasure = Tackt;
        if (isTab)
        {
            gl.show(TabRaw[index], TabLad[index]);
            TabsIm.sprite = TabSprites[TABindex];
        }
        else
        {
            BiyIm.sprite = biy;
            Acord.text = acords[index];
            NextAcord.text = acords[index + 1];
        }
    }

    public void nextT()
    {
        thisTakt++;
        if (thisTakt == ttPage[TABindex])
        {
            NextTabPage();
            thisTakt = 0;
        }
    }

    public void GoNextAcord()
    {
        if(index == acords.Count-1)
        {
            index = -1;
        }
        index++;
        Acord.text = acords[index];
        NextAcord.text = acords[index + 1];
    }

    public void GoTab()
    {
        if (index < TabRaw.Count - 1)
        {
            gl.hide(TabRaw[index], TabLad[index]);
            index++;
            gl.show(TabRaw[index], TabLad[index]);
        }  
    }

    void NextTabPage()
    {

        if(TABindex < TabSprites.Count - 1)
        {
            TABindex++;
            TabsIm.sprite = TabSprites[TABindex];
        }
        else
        {
            metronome.enabled = false;
        }
        
    }
}
