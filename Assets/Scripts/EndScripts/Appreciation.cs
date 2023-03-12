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
            FeedBackSentence = "Appr�ciation du Critique : Tu pensais r�ellement qu'on allait pas te cramer en train de tricher ?";
        }
        else if (counter.NombreDouteux == 2 || counter.NombreDouteux <= 20)
        {
            FeedBackSentence = "Appr�ciation du Critique : C'�tait des erreurs ou tu as tent� des plats originaux ?";
        }
        else if (counter.NombreDouteux == 21 || counter.NombreDouteux <= 100)
        {
            FeedBackSentence = "Appr�ciation du Critique : Tu devrais songer � mettre la cl� sous la porte";
        }
        else if (counter.NombreDouteux >= 101)
        {
            FeedBackSentence = "Appr�ciation du Critique : �a ira mieux demain";
        }
        if (counter.NombreDouteux == 69)
        {
            FeedBackSentence = "Nice.";
        }

        feedback.text = FeedBackSentence;
    }
}
