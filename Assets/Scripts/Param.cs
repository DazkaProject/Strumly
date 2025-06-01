using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Param : MonoBehaviour
{
    public string type = string.Empty;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
