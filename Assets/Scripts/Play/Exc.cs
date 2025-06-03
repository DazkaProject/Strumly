using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exc : MonoBehaviour
{
    public GuitarLads gl;
    public Ex1 ex1;
    public Ex2 ex2;

    public int MaxEx1 = 3;
    public int MaxEx2 = 48;

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
                gl.show(0, 0);
                break;
            case 2:
                gl.show(0, 1);
                break;
            case 3:
                gl.show(0, 2);
                break;
            case 4:
                gl.show(0, 3);
                break;
            case 5:
                gl.hide(0, 3);
                break;
            case 6:
                gl.hide(0, 2);
                break;
            case 7:
                gl.hide(0, 1);
                break;
            case 8:
                gl.hide(0, 0);
                break;
            case 9:
                gl.show(1, 0);
                break;
            case 10:
                gl.show(1, 1);
                break;
            case 11:
                gl.show(1, 2);
                break;
            case 12:
                gl.show(1, 3);
                break;
            case 13:
                gl.hide(1, 3);
                break;
            case 14:
                gl.hide(1, 2);
                break;
            case 15:
                gl.hide(1, 1);
                break;
            case 16:
                gl.hide(1, 0);
                break;
            case 17:
                gl.show(2, 0);
                break;
            case 18:
                gl.show(2, 1);
                break;
            case 19:
                gl.show(2, 2);
                break;
            case 20:
                gl.show(2, 3);
                break;
            case 21:
                gl.hide(2, 3);
                break;
            case 22:
                gl.hide(2, 2);
                break;
            case 23:
                gl.hide(2, 1);
                break;
            case 24:
                gl.hide(2, 0);
                break;
            case 25:
                gl.show(3, 0);
                break;
            case 26:
                gl.show(3, 1);
                break;
            case 27:
                gl.show(3, 2);
                break;
            case 28:
                gl.show(3, 3);
                break;
            case 29:
                gl.hide(3, 3);
                break;
            case 30:
                gl.hide(3, 2);
                break;
            case 31:
                gl.hide(3, 1);
                break;
            case 32:
                gl.hide(3, 0);
                break;
            case 33:
                gl.show(4, 0);
                break;
            case 34:
                gl.show(4, 1);
                break;
            case 35:
                gl.show(4, 2);
                break;
            case 36:
                gl.show(4, 3);
                break;
            case 37:
                gl.hide(4, 3);
                break;
            case 38:
                gl.hide(4, 2);
                break;
            case 39:
                gl.hide(4, 1);
                break;
            case 40:
                gl.hide(4, 0);
                break;
            case 41:
                gl.show(5, 0);
                break;
            case 42:
                gl.show(5, 1);
                break;
            case 43:
                gl.show(5, 2);
                break;
            case 44:
                gl.show(5, 3);
                break;
            case 45:
                gl.hide(5, 3);
                break;
            case 46:
                gl.hide(5, 2);
                break;
            case 47:
                gl.hide(5, 1);
                break;
            case 48:
                gl.hide(5, 0);
                break;
            default:
                gl.HideAll();
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
