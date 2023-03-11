using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirroirBehaviour : MonoBehaviour
{
    public Canvas UITirroir;
    // Start is called before the first frame update
    void Start()
    {
        UITirroir.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenUI()
    {
        UITirroir.enabled = true;
    }

    public void CloseUI()
    {
        UITirroir.enabled = false;
    }

    
}
