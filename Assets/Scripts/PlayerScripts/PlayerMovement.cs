using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = new Vector3(1,0,0);
            Player.transform.position += movement;
        }

        if(Input.GetKey(KeyCode.LeftArrow)) 
        { 
            movement = new Vector3(-1,0,0);
            Player.transform.position += movement;
        }

        if(Input.GetKey(KeyCode.DownArrow)) 
        {
            movement = new Vector3(0,-1,0) ;
            Player.transform.position += movement;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement = new Vector3(0,1,0);
            Player.transform.position += movement;
        }
    }
}
