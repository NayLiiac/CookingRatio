using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class YoannPlayer : MonoBehaviour
{
    public int speed = 5;
    public GameObject tirroir;
    public GameObject crafter;
    public GameObject Tuto1;
    public GameObject Tuto2;
    public string heldIngredient = null;

    private bool inTirroirRange = false;
    private bool isTirroirOpen = false;
    private bool inCrafterRange = false;
    // Start is called before the first frame update
    void Start()
    {
        Tuto1.SetActive(true);
        Tuto2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTirroirOpen)
        {
            if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.Z)))
            {
                this.transform.position = this.transform.position + new Vector3(0, speed * Time.deltaTime, 0);
            }
            if ((Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.S)))
            {
                this.transform.position = this.transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
            }
            if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.Q)))
            {
                this.transform.position = this.transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
            }
            if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D)))
            {
                this.transform.position = this.transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inTirroirRange)
            {
                tirroir.GetComponent<TirroirBehaviour>().OpenUI();
                Tuto1.SetActive(false);
                isTirroirOpen = true;
            }
            
            if (inCrafterRange)
            {
                this.PlaceIngredient();
                Tuto2.SetActive(false);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            inTirroirRange = true;
        }

        if (collision.tag == "Crafter")
        {
            inCrafterRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Tirroir")
        {
            inTirroirRange = false;
        }
        if (collision.tag == "Crafter")
        {
            inCrafterRange = false;
        }
    }

    public void RecieveIngredient(string ingredient)
    {
        this.heldIngredient = ingredient;
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
    }
}
