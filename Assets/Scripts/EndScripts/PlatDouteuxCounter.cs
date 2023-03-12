using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlatDouteuxCounter : MonoBehaviour
{
    public TextMeshProUGUI NombrePlatsDouteux;
    public int NombreDouteux = 0;
    // Start is called before the first frame update
    void Start()
    {
        NombrePlatsDouteux.text = NombreDouteux.ToString();
    }

    public void AddDouteux()
    {
        NombreDouteux++;
        NombrePlatsDouteux.text = NombreDouteux.ToString();
    }
}
