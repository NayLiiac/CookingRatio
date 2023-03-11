using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirroirBehaviour : MonoBehaviour
{
    public Canvas UI_Tirroir;
    // Start is called before the first frame update
    void Start()
    {
        UI_Tirroir.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenUI()
    {
        UI_Tirroir.enabled = true;
    }

    public void CloseUI()
    {
        UI_Tirroir.enabled = false;
    }
}
