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


    // Start is called before the first frame update
    void Start()
    {
        
        Message.text = null;
    }

    public void MessageSent()
    {
        Debug.Log("message");

        Message.text = critic.criticReaction;
        StartCoroutine(MessageCritic());
    }
    IEnumerator MessageCritic()
    {
        yield return new WaitForSeconds(20);
        animator.SetBool("DepopMessage", true);
        yield return new WaitForSeconds(2);
        animator.SetBool("DepopMessage", false);
    }
}
