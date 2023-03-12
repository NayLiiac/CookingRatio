using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Appreciation : MonoBehaviour
{
    public TextMeshProUGUI feedback;
    public string FeedBackSentence;

    public PlatDouteuxCounter counter;

    void Update()
    {
        EndGameFeedBack();
        
    }
    public void EndGameFeedBack()
    {
        if (counter.NombreDouteux <= 1)
        {
            FeedBackSentence = "Appréciation du Critique : Tu pensais réellement qu'on allait pas te cramer en train de tricher ?";
        }
        else if (counter.NombreDouteux == 2 || counter.NombreDouteux <= 20)
        {
            FeedBackSentence = "Appréciation du Critique : C'était des erreurs ou tu as tenté des plats originaux ?";
        }
        else if (counter.NombreDouteux == 21 || counter.NombreDouteux <= 100)
        {
            FeedBackSentence = "Appréciation du Critique : Tu devrais songer à mettre la clé sous la porte";
        }
        else if (counter.NombreDouteux >= 101)
        {
            FeedBackSentence = "Appréciation du Critique : Ça ira mieux demain";
        }
        if (counter.NombreDouteux == 69)
        {
            FeedBackSentence = "Nice.";
        }

        feedback.text = FeedBackSentence;
    }
}
