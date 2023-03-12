using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Poussin : MonoBehaviour
{
    public float speed;
    public Transform player;
    public Critic critic;
    public Crafter crafter;
    public GameObject poussin;
    public bool eclosion = false;
    void Update()
    {
        if (critic.DicoPlats.Equals("poussin"))
        {
            poussin.SetActive(true);
            eclosion = true;
            Debug.Log("poussiiin");
        }
        if (eclosion)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
            Debug.Log("piou piou");
        }
    }
   
}
