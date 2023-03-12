using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Critic : MonoBehaviour
{
    public Dictionary<string, string> DicoPlats = new Dictionary<string, string>();
    public List<string> recipeUnlocked = new List<string>();

    public string plat;

    public CriticMessage message;
    public RecipesCounter recipecounter;
    public PlatDouteuxCounter platdouteuxcounter;

    public string criticReaction;


    void Start()
    {
        DicoPlats.Add("gratindeflingue",        "Surprenant !"); //
        DicoPlats.Add("soupedeflingue",         "American Soup Be Like "); //
        DicoPlats.Add("maoambubbletea",         "Ok Tier"); //
        DicoPlats.Add("chaussonauxpommes",      "Mmmh, original "); //
        DicoPlats.Add("choufleur",              "Tu es un sacré blagueur"); //
        DicoPlats.Add("fishandchips",           "Tu es un sacré blagueur"); //
        DicoPlats.Add("lefisheauchocolat",      "Yummy !"); //
        DicoPlats.Add("lefeur",                 "Quoi ?"); //
        DicoPlats.Add("puddingalarsenic",       "Moui"); //
        DicoPlats.Add("canardlaque",            "Shiny"); //
        DicoPlats.Add("surispliff",             "Fumer du Surimi c’est possible !"); //
        DicoPlats.Add("salade",                 "OK Tier"); //
        DicoPlats.Add("raclette",               "Bien !"); //
        DicoPlats.Add("omelettefromage",        "Pas fou"); //
        DicoPlats.Add("crepes",                 "Excellent !"); //
        DicoPlats.Add("pain",                   "Classique"); //
        DicoPlats.Add("rizaulait",              "Immonde !"); //
        DicoPlats.Add("snoopdogg",              "Smoke Weed Everyday"); //
        DicoPlats.Add("saladedekraken",         "Fantastique !"); //
        DicoPlats.Add("pommeaufour",            "Classique"); //
        DicoPlats.Add("jusdorange",             "Joker éveille le goût !"); //
        DicoPlats.Add("chamallowgrille",        "Cela me rappelle ma jeunesse !"); //
        DicoPlats.Add("ptitdej",                "Ce n’est plus l’heure"); //
        DicoPlats.Add("patesjambon",            "Ration de survie pour étudiant"); //
        DicoPlats.Add("poeleedepatates",        "Ohhhh ! Cool !"); //
        DicoPlats.Add("cocktailmolotov",        "*died*"); //
        DicoPlats.Add("gouter",                 "Où est la poubelle ?"); //
        DicoPlats.Add("tomatesfarcies",         "Tu me prend pour un dindon"); //
        DicoPlats.Add("steakfrites",            "Excellent !"); //
        DicoPlats.Add("batman",                 "I’m Vengeance !"); //
        DicoPlats.Add("kirby",                  "Gloup !"); //
        DicoPlats.Add("unknown",                "Serait-ce de l'Art moderne ?");//
        DicoPlats.Add("poussin",                "“Ce pigeon est tellement cru qu’il peut encore voler!” Gordon Ramsay"); //
        DicoPlats.Add("soireegaming",           "Gaming and Chill"); //
        DicoPlats.Add("painauchocolat",         "Chocola-Non, trop facile");//
        DicoPlats.Add("patesbolognaises",       "Bien !"); //
        DicoPlats.Add("caramel",                "Je peux pas j’ai dentiste"); //
        DicoPlats.Add("krakenaubeurre",         "Sauce ?"); //
        DicoPlats.Add("cracotte",               "Ça Krak’nCott"); //
        DicoPlats.Add("lekraken",               "Regarde ma descente"); //
        DicoPlats.Add("boitedepandore",         "Génial, une nouvelle boîte à bijoux !"); //
        DicoPlats.Add("tonneauderhum",          "Jack Sparrow moment"); // 
        DicoPlats.Add("cigarette",              "“Fumer tue vivre aussi alors autant se ruiner” - Damso"); //
        DicoPlats.Add("torchontache",           "C’est quoi ça ? Un torchon ? Va laver ça !"); // 
        DicoPlats.Add("lanceroquettes",         "Cela me rappelle mon service militaire"); //
        DicoPlats.Add("tartare",                "C'est l'histoire d'un têtard qui croyait qu'il était tôt mais en fait il était tard."); //
        DicoPlats.Add("sushi",                  "C’est nippon ni mauvais"); // 
        DicoPlats.Add("platdouteux",            "OOOH mais qu’est-ce que c’est que ce truc là ?"); //

    }

    public void SearchPlat()
    {
        if (DicoPlats[plat].Equals("OOOH mais qu’est-ce que c’est que ce truc là ?"))
        {
            platdouteuxcounter.AddDouteux();
            Debug.Log("blablabla");
        }
        foreach (string note in DicoPlats.Values)
        {
            if (DicoPlats.ContainsKey(plat)) // SI ça contient le plat
            {

                // On a trouvé le plat
                if (!recipeUnlocked.Contains(plat))
                {

                    recipecounter.AddRecipe();
                    recipeUnlocked.Add(plat);
                    criticReaction = DicoPlats[plat];

                }
                if (recipeUnlocked.Contains(plat))
                {
                    criticReaction = DicoPlats[plat];
                    break;
                }
            }
        }
        
        message.MessageSent(); // Renvoie la critique

    }

   
}