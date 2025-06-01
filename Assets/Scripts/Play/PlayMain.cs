using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMain : MonoBehaviour
{
    
    public Metronome met;

    Animator animator;
    Param param;

    void Start()
    {
        animator = GetComponent<Animator>();
        param = GameObject.FindWithTag("Param").GetComponent<Param>();
        if (param != null)
        {
            Debug.Log("«найдено об'Їкт з тегом 'param'");
            switch (param.type)
            {
                case "lAcords":
                    //met.bpm = 60.0f;
                    animator.SetInteger("i", 1);
                    break;
                case "ex1":
                    animator.SetInteger("i", 2);
                    Debug.Log("¬иконано");
                    break;
                case "ex2":
                    animator.SetInteger("i", 1);
                    break;
                case "STab":
                    animator.SetInteger("i", 1);
                    break;
                case "SFight":
                    animator.SetInteger("i", 0);
                    break;
            }
            param = null;
            Destroy(GameObject.FindWithTag("Param"));
        }
        else
        {
            Debug.LogWarning("ќб'Їкт з тегом 'param' не знайдено!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
