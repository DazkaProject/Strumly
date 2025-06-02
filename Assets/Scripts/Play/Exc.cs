using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exc : MonoBehaviour
{
    public GuitarLads gl;
    public Ex1 ex1;
    public Ex2 ex2;

    void Start()
    {
        ex1 += OnEx1;
        ex2 += OnEx2;
    }

   void OnEx1(object obj, ExEvent e)
   {
        switch (e.Tick)
        {
            case 1:
                gl.pimaHideAll();
                gl.pimaShow(0);
                gl.pimaShow(3);
                break;
            case 2:
                gl.pimaHide(0);
                gl.pimaHide(3);
                gl.pimaShow(4);
                break;
            case 3:
                gl.pimaHide(4);
                gl.pimaShow(5);
                break;
        }
   }

    void OnEx2(object obj, ExEvent e)
    {
        switch (e.Tick)
        {
            case 1:
                gl.show(0, 1);
                break;
            case 2:
                gl.show(0, 2);
                break;
            case 3:
                gl.show(0, 3);
                break;
            case 4:
                gl.show(0, 4);
                break;
            case 5:
                gl.hide(0, 4);
                break;
            case 6:
                gl.hide(0, 3);
                break;
            case 7:
                gl.hide(0, 2);
                break;
            case 8:
                gl.hide(0, 1);
                break;
            case 9:
                gl.show(1, 1);
                break;
            case 10:
                gl.show(1, 2);
                break;
            case 11:
                gl.show(1, 3);
                break;
            case 12:
                gl.show(1, 4);
                break;
            case 13:
                gl.hide(1, 4);
                break;
            case 14:
                gl.hide(1, 3);
                break;
            case 15:
                gl.hide(1, 2);
                break;
            case 16:
                gl.hide(1, 1);
                break;
        }
    }
}

public delegate void Ex1(object obj, ExEvent e);
public delegate void Ex2(object obj, ExEvent e);

public class ExEvent: EventArgs
{
    public int Tick { get; set; }
}
