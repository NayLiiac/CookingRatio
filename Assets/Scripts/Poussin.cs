using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Poussin : MonoBehaviour
{
    public float speed;
    public Transform player;
    public GameObject poussin;
    public bool isfollow = false;
    void Update()
    {
        if (isfollow)
        {
            poussin.transform.position = Vector3.MoveTowards(poussin.transform.position, player.position, Time.deltaTime * speed);

            //Quaternion rot = Quaternion.LookRotation(player.position - transform.position, new Vector3 (0,0,-1));
            //poussin.transform.Rotate(0, 0, rot.eulerAngles.z*Time.deltaTime);
            Vector2 direction = player.position - poussin.transform.position;
            poussin.transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);  //https://www.youtube.com/watch?v=mJi0NwSsJig 
        }
    }
    public void Eclosion()
    {
        poussin.SetActive(true);
        isfollow = true;
    }
}
