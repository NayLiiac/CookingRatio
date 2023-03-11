using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.TerrainTools;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    // Public pour les tests
    // Ingredients ajout�s dans le Crafter
    public string ingredient_1 = null;
    public string ingredient_2 = null;

    // Dico
    Dictionary<string, string> dicoFood = new Dictionary<string, string>();

    // Variables de test
    string testVar = "";

    // Start is called before the first frame update
    void Start()
    {
        // Init dictionnaire des plats
        // Bac 1
        dicoFood.Add("riztomate",               "salade");
        dicoFood.Add("surimitomate",            "salade");
        dicoFood.Add("farineoeuf",              "crepes");
        dicoFood.Add("eaufarine",               "pain");
        dicoFood.Add("pommesucre",              "pommeaufour");
        // Bac 2
        dicoFood.Add("patatefromage",           "raclette");
        dicoFood.Add("oeuffromage",             "omelettefromage");
        dicoFood.Add("rizlait",                 "rizaulait");
        dicoFood.Add("patesjambon",             "patesjambon");
        dicoFood.Add("patatechou",              "poeleedepatates");
        dicoFood.Add("tomatejambon",            "tomatesfarcies");
        dicoFood.Add("patatesteak",             "steakfrites");
        dicoFood.Add("patessteak",              "patesbolognaises");
        dicoFood.Add("steakoeuf",               "tartare");
        dicoFood.Add("rizpoisson",              "sushi");
        // Bac 3
        dicoFood.Add("eaubonbon",               "maoambubbletea");
        dicoFood.Add("choufleur",               "choufleur");
        dicoFood.Add("poissonchips",            "fishandchips");
        dicoFood.Add("poissonchocolat",         "lefisheauchocolat");
        dicoFood.Add("tabacsurimi",             "surispliff");
        dicoFood.Add("feubonbon",               "chamallowgrille");
        dicoFood.Add("laitcereal",              "ptitdej");
        dicoFood.Add("feualcool",               "cocktailmolotov");
        dicoFood.Add("orangechocolat",          "gouter");
        dicoFood.Add("beurrechocolat",          "painauchocolat");
        dicoFood.Add("sucrefeu",                "caramel");
        dicoFood.Add("boisalcool",              "tonneauderhum");
        dicoFood.Add("tissutabac",              "cigarette");
        dicoFood.Add("tomatetissu",             "torchontache");
        dicoFood.Add("saladefeu",               "lanceroquettes");
        // Bac 4
        dicoFood.Add("flinguefromage",          "gratindeflingue");
        dicoFood.Add("flingueeau",              "soupedeflingue");
        dicoFood.Add("pommechausson",           "chaussonauxpommes");
        dicoFood.Add("oiseausansailes",         "lefeur");
        dicoFood.Add("arsenicfarine",           "puddingalarsenic");
        dicoFood.Add("canardlaque",             "canardlaque");
        dicoFood.Add("tabacargent",             "snoopdogg");
        dicoFood.Add("krakensalade",            "saladedekraken");
        dicoFood.Add("jokerorange",             "jusdorange");
        dicoFood.Add("consolejoker",            "batman");
        dicoFood.Add("bonbonconsole",           "kirby");
        dicoFood.Add("inimoisiarsenic",         "unknown");
        dicoFood.Add("canardoiseausansailes",   "poussin");
        dicoFood.Add("chipsconsole",            "soireegaming");
        dicoFood.Add("krakenbeurre",            "krakenaubeurre");
        dicoFood.Add("krakenfarine",            "cracotte");
        dicoFood.Add("alcoolkraken",            "lekraken");
        dicoFood.Add("inimoisiinimoisi",        "boitedepandore");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            testVar = Craft();
            Debug.Log(testVar);
        }
    }

    public void AddIngredient(string ingredient)
    {

    }

    // Construire une cl� pour tester dans le dictionnaire
    public string BuildString(string ing1, string ing2) {
        return ing1 + ing2;
    }

    // V�rifier une correspondance avec le dictionnaire
    public string CheckDico(string key) {
        string value = "";
        dicoFood.TryGetValue(key, out value);
        if (value == null) {
            value = "platdouteux";
        }
        return value;
    }

    public string Craft() {
        string testKey = BuildString(ingredient_1, ingredient_2);
        string testKeyRevert = BuildString(ingredient_2, ingredient_1);

        string result = CheckDico(testKey);
        if (result == "platdouteux") {
            string resultRevert = CheckDico(testKeyRevert);
            if (resultRevert == "platdouteux") {
                return "platdouteux";
            }
            return resultRevert;
            
        }
        return result;

    }
}
