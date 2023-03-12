using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlatDouteuxCounter : MonoBehaviour
{
    public int NombreDouteux = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void AddDouteux()
    {
        NombreDouteux++;
    }

}