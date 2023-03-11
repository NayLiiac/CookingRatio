using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoannPlayer : MonoBehaviour
{
    public int speed = 5;
    public GameObject tirroir;

    private bool InTirroirRange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position = this.transform.position + new Vector3 (0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position = this.transform.position + new Vector3 (0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position = this.transform.position + new Vector3 (-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position = this.transform.position + new Vector3 (speed * Time.deltaTime, 0, 0);
        }

        if (InTirroirRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                tirroir.GetComponent<TirroirBehaviour>().OpenUI();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                tirroir.GetComponent<TirroirBehaviour>().CloseUI();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            InTirroirRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            InTirroirRange = false;
        }
    }

    

}
