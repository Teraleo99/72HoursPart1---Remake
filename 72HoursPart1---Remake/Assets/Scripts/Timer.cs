using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Using statement for unity UI code

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    float currentTime = 0f;
    float startingTime = 10f;

    public Text TimerText;

    void Start()
    {
        currentTime = startingTime;

    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimerText.text = currentTime.ToString("0"); 

        if(currentTime <= 0)
        {
            currentTime = 0;
            GameOver();
        }
        
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
