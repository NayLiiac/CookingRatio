using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipesCounter : MonoBehaviour
{
    public int scoreValue;
    public TextMeshProUGUI score;

    void Update()
    {

        score.text = scoreValue.ToString();
    }

}
