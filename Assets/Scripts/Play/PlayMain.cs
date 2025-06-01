using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMain : MonoBehaviour
{
    GameObject param;

    void Start()
    {
        param = GameObject.FindWithTag("Param");
        if (param != null)
        {
            Debug.Log("Знайдено об'єкт з тегом 'param': " + param.name);
            // Тут ви можете працювати з знайденим об'єктом
        }
        else
        {
            Debug.LogWarning("Об'єкт з тегом 'param' не знайдено!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
