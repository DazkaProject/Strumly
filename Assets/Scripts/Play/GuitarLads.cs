using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GuitarLads : MonoBehaviour
{
    public List<GameObject> raw1;
    public List<GameObject> raw2;
    public List<GameObject> raw3;
    public List<GameObject> raw4;
    public List<GameObject> raw5;
    public List<GameObject> raw6;
    public List<GameObject> pima;

    void Start()
    {
        HideAll();
        pimaHideAll();
    }


    public void HideAll()
    {
        foreach (GameObject i in raw1)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in raw2)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in raw3)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in raw4)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in raw5)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in raw6)
        {
            i.SetActive(false);
        }
        
    }

    public void pimaHideAll()
    {
        foreach (GameObject i in pima)
        {
            i.SetActive(false);
        }
    }

    public void pimaShow(int i)
    {
        pima[i].SetActive(true);
    }

    public void pimaHide(int i)
    {
        pima[i].SetActive(false);
    }

    public void hide(int raw, int lad)
    {
        switch (raw)
        {
            case 0:
                raw1[lad].SetActive(false);
                break;
            case 1:
                raw2[lad].SetActive(false);
                break;
            case 2:
                raw3[lad].SetActive(false);
                break;
            case 3:
                raw4[lad].SetActive(false);
                break;
            case 4:
                raw5[lad].SetActive(false);
                break;
            case 5:
                raw6[lad].SetActive(false);
                break;
        }
    }

    public void show(int raw, int lad)
    {
        switch (raw)
        {
            case 0:
                raw1[lad].SetActive(true); 
                break;
            case 1:
                raw2[lad].SetActive(true);
                break;
            case 2:
                raw3[lad].SetActive(true);
                break;
            case 3:
                raw4[lad].SetActive(true);
                break;
            case 4:
                raw5[lad].SetActive(true);
                break;
            case 5:
                raw6[lad].SetActive(true);
                break;
        }
    }


    public void AcordEm()
    {
        HideAll();
        raw5[1].SetActive(true);
        raw4[1].SetActive(true);
    }


    public void AcordA()
    {
        HideAll();
        raw3[1].SetActive(true);
        raw2[1].SetActive(true);
        raw4[1].SetActive(true);
    }


    public void AcordE()
    {
        HideAll();
        raw3[0].SetActive(true);
        raw4[1].SetActive(true);
        raw5[1].SetActive(true);
    }

    public void AcordAm()
    {
        HideAll();
        raw2[0].SetActive(true);
        raw3[1].SetActive(true);
        raw4[1].SetActive(true);
    }

    public void AcordDm()
    {
        HideAll();
        raw1[0].SetActive(true);
        raw3[1].SetActive(true);
        raw2[2].SetActive(true);
    }

    public void AcordD()
    {
        HideAll();
        raw1[1].SetActive(true);
        raw3[1].SetActive(true);
        raw2[2].SetActive(true);
    }

    public void AcordC()
    {
        HideAll();
        raw2[0].SetActive(true);
        raw4[1].SetActive(true);
        raw5[2].SetActive(true);
    }

    public void AcordG()
    {
        HideAll();
        raw5[1].SetActive(true);
        raw6[2].SetActive(true);
        raw1[2].SetActive(true);
    }

    public void AcordB7()
    {
        HideAll();
        raw4[0].SetActive(true);
        raw5[1].SetActive(true);
        raw3[1].SetActive(true);
        raw1[1].SetActive(true);
    }
}
