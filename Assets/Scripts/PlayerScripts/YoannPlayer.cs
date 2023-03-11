using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class YoannPlayer : MonoBehaviour
{
    public int speed = 5;
    public GameObject tirroir;
    public GameObject crafter;
    public string heldIngredient = null;

    private bool inTirroirRange = false;
    private bool isTirroirOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTirroirOpen)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.position = this.transform.position + new Vector3(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.position = this.transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.position = this.transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.position = this.transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }

        if (inTirroirRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                tirroir.GetComponent<TirroirBehaviour>().OpenUI();
                isTirroirOpen = true;
            }
        }
        if (Input.GetKey(KeyCode.T))
        {
            this.PlaceIngredient();

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            inTirroirRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            inTirroirRange = false;
        }
    }

    public void RecieveIngredient(string ingredient)
    {
        this.heldIngredient = ingredient;
        Debug.Log(heldIngredient);
        tirroir.GetComponent<TirroirBehaviour>().CloseUI();
        isTirroirOpen = false;
    }

    public void PlaceIngredient()
    {
        if (heldIngredient != null)
        {
            crafter.GetComponent<Crafter>().AddIngredient(heldIngredient);
            heldIngredient = null;
        }
        else
        {
            Debug.Log("ERROR : Player : PlaceIngredient : heldIngredient is null");
        }
    }
}
