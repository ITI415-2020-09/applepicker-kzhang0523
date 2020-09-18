using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Need for uGUI to work

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
    }
}
