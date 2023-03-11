using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CriticMessage : MonoBehaviour
{
    public TextMeshProUGUI Message;
    public Critic critic;

    // Start is called before the first frame update
    void Start()
    {
        
        Message.text = null;
    }

    public void MessageSent()
    {

        Message.text = critic.criticReaction;

    }
}
