using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public Text countdownText;
    public Text winLossText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = "Time: " + currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            //stops player from being able to control the player
            Destroy(this);
            //stops the player from moving right there
            this.gameObject.SetActive(false);
        }

        if(currentTime == 0)
        {
            winLossText.text = "You Ran Out of Time! :(";
        }
    }
}
