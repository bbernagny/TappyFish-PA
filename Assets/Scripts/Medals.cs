using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medals : MonoBehaviour
{
    public Sprite bronzeMedal, silverMedal, goldMedal;
    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        int gameScore = GameManager.gameScore;

        if(gameScore > 2 && gameScore <= 3)
        {
            img.sprite = bronzeMedal;
        }
        else if (gameScore > 3 && gameScore <= 4)
        {
            img.sprite = silverMedal;
        }
        else if (gameScore > 4)
        {
            img.sprite = goldMedal;
        }
    }
}
