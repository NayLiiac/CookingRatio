using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Poussin : MonoBehaviour
{
    public float speed;
    public Transform player;
    public Critic critic;
    public GameObject poussin;
    void Update()
    {
        Debug.Log("coucouuuu");
        if (critic.DicoPlats.Equals(" “Ce pigeon est tellement cru qu’il peut encore voler!” Gordon Ramsay"))
        {
            Debug.Log("poussiiin");

            poussin.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
        }
    }
}
