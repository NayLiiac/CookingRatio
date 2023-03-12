using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecipesCounter : MonoBehaviour
{
    public int scoreValue = 0;
    public TextMeshProUGUI score;
    int scoreMax = 48;

    void Start()
    {
        score.text = scoreValue.ToString() + " / " + scoreMax;
    }
    
    public void AddRecipe()
    {
        scoreValue++;
        score.text = scoreValue.ToString() + " / " + scoreMax;

        if (scoreValue == scoreMax)
        {
            SceneManager.LoadScene("End");
        }
    }
    
}
