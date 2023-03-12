using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.TerrainTools;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Crafter : MonoBehaviour
{
    // Public pour les tests
    // Ingredients ajoutés dans le Crafter
    public string ingredient_1 = null;
    public string ingredient_2 = null;

    public Image foodPicture;
    public GameObject critic;

    // Dico
    Dictionary<string, string> dicoFood = new Dictionary<string, string>();
    Dictionary<string, Sprite> dicoImage = new Dictionary<string , Sprite>();

    public Sprite[] imageTab = new Sprite[0];
    public Sprite defaultSprite;

    private AudioSource soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        this.initRecettes();
        this.initFoodImages();

        soundEffect = GetComponent<AudioSource>();
        foodPicture.gameObject.SetActive(false);
    }

    private void initRecettes()
    {
        // Init dictionnaire des plats
        // Bac 1
        dicoFood.Add("riztomate", "salade");
        dicoFood.Add("surimitomate", "salade");
        dicoFood.Add("farineoeuf", "crepes");
        dicoFood.Add("eaufarine", "pain");
        dicoFood.Add("pommesucre", "pommeaufour");
        // Bac 2
        dicoFood.Add("patatefromage", "raclette");
        dicoFood.Add("oeuffromage", "omelettefromage");
        dicoFood.Add("rizlait", "rizaulait");
        dicoFood.Add("patesjambon", "patesjambon");
        dicoFood.Add("patatechou", "poeleedepatates");
        dicoFood.Add("tomatejambon", "tomatesfarcies");
        dicoFood.Add("patatesteak", "steakfrites");
        dicoFood.Add("patessteak", "patesbolognaises");
        dicoFood.Add("steakoeuf", "tartare");
        dicoFood.Add("rizpoisson", "sushi");
        // Bac 3
        dicoFood.Add("eaubonbon", "maoambubbletea");
        dicoFood.Add("choufleur", "choufleur");
        dicoFood.Add("poissonchips", "fishandchips");
        dicoFood.Add("poissonchocolat", "lefisheauchocolat");
        dicoFood.Add("tabacsurimi", "surispliff");
        dicoFood.Add("feubonbon", "chamallowgrille");
        dicoFood.Add("laitcereal", "ptitdej");
        dicoFood.Add("feualcool", "cocktailmolotov");
        dicoFood.Add("orangechocolat", "gouter");
        dicoFood.Add("beurrechocolat", "painauchocolat");
        dicoFood.Add("sucrefeu", "caramel");
        dicoFood.Add("boisalcool", "tonneauderhum");
        dicoFood.Add("tissutabac", "cigarette");
        dicoFood.Add("tomatetissu", "torchontache");
        dicoFood.Add("saladefeu", "lanceroquettes");
        // Bac 4
        dicoFood.Add("flinguefromage", "gratindeflingue");
        dicoFood.Add("flingueeau", "soupedeflingue");
        dicoFood.Add("pommechausson", "chaussonauxpommes");
        dicoFood.Add("oiseausansailesfleur", "lefeur");
        dicoFood.Add("arsenicfarine", "puddingalarsenic");
        dicoFood.Add("canardlaque", "canardlaque");
        dicoFood.Add("tabacargent", "snoopdogg");
        dicoFood.Add("krakensalade", "saladedekraken");
        dicoFood.Add("jokerorange", "jusdorange");
        dicoFood.Add("consolejoker", "batman");
        dicoFood.Add("bonbonconsole", "kirby");
        dicoFood.Add("inimoisiarsenic", "unknown");
        dicoFood.Add("canardoiseausansailes", "poussin");
        dicoFood.Add("chipsconsole", "soireegaming");
        dicoFood.Add("krakenbeurre", "krakenaubeurre");
        dicoFood.Add("krakenfarine", "cracotte");
        dicoFood.Add("alcoolkraken", "lekraken");
        dicoFood.Add("inimoisiinimoisi", "boitedepandore");
    }
    
    private void initFoodImages()
    {
        //Bac 1
        dicoImage.Add("salade",         imageTab[0]);
        dicoImage.Add("crepes",         imageTab[1]);
        dicoImage.Add("pain",           imageTab[2]);
        dicoImage.Add("pommeaufour",    imageTab[3]);
        // Bac 2
        dicoImage.Add("raclette",           imageTab[4]);
        dicoImage.Add("omelettefromage",    imageTab[5]);
        dicoImage.Add("rizaulait",          imageTab[6]);
        dicoImage.Add("patesjambon",        imageTab[7]);
        dicoImage.Add("poeleedepatates",    imageTab[8]);
        dicoImage.Add("tomatesfarcies",     imageTab[9]);
        dicoImage.Add("steakfrites",        imageTab[10]);
        dicoImage.Add("patesbolognaises",   imageTab[11]);
        dicoImage.Add("tartare",            imageTab[12]);
        dicoImage.Add("sushi",              imageTab[13]);
        //Bac 3
        dicoImage.Add("maoambubbletea",     imageTab[14]);
        dicoImage.Add("choufleur",          imageTab[15]);
        dicoImage.Add("fishandchips",       imageTab[16]);
        dicoImage.Add("lefisheauchocolat",  imageTab[17]);
        dicoImage.Add("surispliff",         imageTab[18]);
        dicoImage.Add("chamallowgrille",    imageTab[19]);
        dicoImage.Add("ptitdej",            imageTab[20]);
        dicoImage.Add("cocktailmolotov",    imageTab[21]);
        dicoImage.Add("gouter",             imageTab[22]);
        dicoImage.Add("painauchocolat",     imageTab[23]);
        dicoImage.Add("caramel",            imageTab[24]);
        dicoImage.Add("tonneauderhum",      imageTab[25]);
        dicoImage.Add("cigarette",          imageTab[26]);
        dicoImage.Add("torchontache",       imageTab[27]);
        dicoImage.Add("lanceroquettes",     imageTab[28]);
        // Bac 4
        dicoImage.Add("gratindeflingue",    imageTab[29]);
        dicoImage.Add("soupedeflingue",     imageTab[30]);
        dicoImage.Add("chaussonauxpommes",  imageTab[31]);
        dicoImage.Add("lefeur",             imageTab[32]);
        dicoImage.Add("puddingalarsenic",   imageTab[33]);
        dicoImage.Add("canardlaque",        imageTab[34]);
        dicoImage.Add("snoopdogg",          imageTab[35]);
        dicoImage.Add("saladedekraken",     imageTab[36]);
        dicoImage.Add("jusdorange",         imageTab[37]);
        dicoImage.Add("batman",             imageTab[38]);
        dicoImage.Add("kirby",              imageTab[39]);
        dicoImage.Add("unknown",            imageTab[40]);
        dicoImage.Add("poussin",            imageTab[41]);
        dicoImage.Add("soireegaming",       imageTab[42]);
        dicoImage.Add("krakenaubeurre",     imageTab[43]);
        dicoImage.Add("cracotte",           imageTab[44]);
        dicoImage.Add("lekraken",           imageTab[45]);
        dicoImage.Add("boitedepandore",     imageTab[46]);
        
    }
    


    public void AddIngredient(string ingredient)
    {
        if (ingredient_1 == "")
        {
            ingredient_1 = ingredient;
        }
        else if (ingredient_2== "")
        {
            ingredient_2 = ingredient;
            Craft();
        }
    }

    // Construire une clé pour tester dans le dictionnaire
    public string BuildString(string ing1, string ing2) {
        return ing1 + ing2;
    }


    // Vérifier une correspondance avec le dictionnaire
    public string CheckDicoFood(string key) {
        string value = "";
        dicoFood.TryGetValue(key, out value);
        if (value == null) {
            value = "platdouteux";
        }
        return value;
    }

    public Sprite CheckDicoImage(string key)
    {
        Sprite value = defaultSprite;
        dicoImage.TryGetValue(key, out value);
        if (value == null)
        {
            Debug.Log("C'est nul");
            value = defaultSprite;
        }
        return value;
    }

    
    public void Craft() {
        string testKey = BuildString(ingredient_1, ingredient_2);
        string testKeyRevert = BuildString(ingredient_2, ingredient_1);

        string result = CheckDicoFood(testKey);
        if (result == "platdouteux") {

            result = CheckDicoFood(testKeyRevert);
            if (result == "platdouteux") {

                Debug.Log("Tu as réalisé de la merde");
                result = "platdouteux";
            }
        }

        ingredient_1 = "";
        ingredient_2 = "";
        Debug.Log("Tu as réalisé : " + result);
        StartCoroutine(DisplayFood(result));
    }


    IEnumerator DisplayFood(string food)
    {
        foodPicture.sprite = CheckDicoImage(food);
        foodPicture.gameObject.SetActive(true);
        foodPicture.GetComponent<Animator>().SetTrigger("Jumpscare");
        soundEffect.PlayDelayed((float)0.4);

        Debug.Log("Entre coroutine");
        yield return new WaitForSeconds((float)1);
        
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        Debug.Log("Got Input");

        foodPicture.gameObject.SetActive(false);
        critic.GetComponent<Critic>().plat = food;
        critic.GetComponent<Critic>().SearchPlat();

        yield return null;
    }
}
