using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipesCounter : MonoBehaviour
{
    public int scoreValue = 0;
    public TextMeshProUGUI score;

    void Start()
    {
        score.text = scoreValue.ToString();
    }
    
    public void AddRecipe()
    {
        scoreValue++;
        score.text = scoreValue.ToString();
    }
    
}
