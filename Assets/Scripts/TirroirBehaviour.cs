using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirroirBehaviour : MonoBehaviour
{
    public Canvas UITirroir;
    // Start is called before the first frame update
    void Start()
    {
        //UITirroir.enabled = false;
        UITirroir.gameObject.SetActive(false);
    }

    public void OpenUI()
    {
        UITirroir.gameObject.SetActive(true);
    }

    public void CloseUI()
    {
        //UITirroir.enabled = false;
        UITirroir.gameObject.SetActive(false);
    }


    
}
