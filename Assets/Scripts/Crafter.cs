using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    // Public pour les tests
    // Ingredients ajoutés dans le Crafter
    public string Ingredient_1 = null;
    public string Ingredient_2 = null;

    // Dico
    Dictionary<string, string> dicoFood = new Dictionary<string, string>();
    

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
        dicoFood.Add("patatefromage",           "raclette");
        dicoFood.Add("patesjambon",             "patesjambon");
        dicoFood.Add("patatechou",              "poelleedepatates");
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
        dicoFood.Add("flinguesalade",           "saladedeflingue");
        dicoFood.Add("pommechausson",           "chaussonauxpommes");
        dicoFood.Add("oiseausansailes",         "lefeur");
        dicoFood.Add("arsenicfarine",           "puddingalarsenic");
        dicoFood.Add("argentpoisson",           "saumonaloseille");
        dicoFood.Add("canardlaque",             "canardlaque");
        dicoFood.Add("tabacargent",             "snoopdogg");
        dicoFood.Add("krakensalade",            "saladedekraken");
        dicoFood.Add("chaussonjambon",          "chaussonaujambon");
        dicoFood.Add("jokerorange",             "jusdorange");
        dicoFood.Add("feuflingue",              "armeafeu");
        dicoFood.Add("consolejoker",            "batman");
        dicoFood.Add("bonbonconsole",           "kirby");
        dicoFood.Add("inimoisiarsenic",         "unknown");
        dicoFood.Add("canardoiseausansailes",   "poussin");
        dicoFood.Add("chipsconsole",            "soireegaming");
        dicoFood.Add("krakenbeurre",            "krakenaubeurre");
        dicoFood.Add("krakenfarine",            "cracotte");
        dicoFood.Add("alcoolkraken",            "lekraken");
        dicoFood.Add("laqueargent",             "piscinedargent");
        dicoFood.Add("inimoisicereal",          "ptitdejdouteux");
        dicoFood.Add("inimoisiinimoisi",        "boitedepandore");
        dicoFood.Add("krakenbois",              "bateaupirate");


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Construire une clé pour tester dans le dictionnaire
    public string BuildString(string ing1, string ing2) {
        return ing1 + ing2;
    }

    // Vérifier une correspondance avec le dictionnaire
    public string CheckDico(string key) {
        string value = "platdouteux";
        dicoFood.TryGetValue(key, out value);

        return value;
    }

    public string Craft() {


        return "platdouteux";
    }
}
