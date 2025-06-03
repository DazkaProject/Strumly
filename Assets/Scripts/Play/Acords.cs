using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Acords : MonoBehaviour
{
    public List<Sprite> acords = new List<Sprite>();
    public Image image;
    public List<string> namesAc = new List<string>();
    public GuitarLads guitarLads;
    int tAcord = 0;

  
    void Update()
    {
        image.sprite = acords[tAcord];
        switch (namesAc[tAcord])
        {
            case "C":
                guitarLads.AcordC();
                break;
            case "D":
                guitarLads.AcordD();
                break;
            case "G":
                guitarLads.AcordG();
                break;
            case "E":
                guitarLads.AcordE();
                break;
            case "A":
                guitarLads.AcordA();
                break;
            case "Am":
                guitarLads.AcordAm();
                break;
            case "Em":
                guitarLads.AcordEm();
                break;
            case "Dm":
                guitarLads.AcordDm();
                break;
            case "B7":
                guitarLads.AcordB7();
                break;
            case "A7":
                guitarLads.AcordA7();
                break;
            case "G7":
                guitarLads.AcordG7();
                break;
            case "E7":
                guitarLads.AcordE7();
                break;
            case "D7":
                guitarLads.AcordD7();
                break;
            case "C7":
                guitarLads.AcordC7();
                break;
            case "Fm":
                guitarLads.AcordFm();
                break;
            case "F":
                guitarLads.AcordF();
                break;
            case "F7":
                guitarLads.AcordF7();
                break;
            case "Gm":
                guitarLads.AcordGm();
                break;
            case "B":
                guitarLads.AcordB();
                break;
            case "Bm":
                guitarLads.AcordBm();
                break;
            case "Cm":
                guitarLads.AcordCm();
                break;
            default:
                guitarLads.HideAll();
                break;
        }
    }

    public void Next()
    {
        if (tAcord < acords.Count-1)
        {
            tAcord++;
        }
    }

    public void Prev()
    {
        if (tAcord > 0)
        {
            tAcord--;
        }
    }
}
