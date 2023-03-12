using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CriticMessage : MonoBehaviour
{
    public TextMeshProUGUI Message;
    public Critic critic;
    Animator animator;
    public bool depopMessage = false;

    void Start()
    {

        Message.text = null;
    }

    public void MessageSent()
    {
        Message.text = critic.criticReaction;
        StartCoroutine(MessageCritic());

    }
   
    IEnumerator MessageCritic()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("depop");
        Message.text = "";
    }
    
}
