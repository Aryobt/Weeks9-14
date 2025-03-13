using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public UnityEvent OnTimerHasFinished;//activating an event on unity for this script
    public float timerLength = 3;//setting a timer for the text
    public float t;//making a public float called t

    public RectTransform banana;
    public void MouseJustEnteredImage()
    {
        Debug.Log("The mouse just entered the image!");//shows in the console that the mouse entered the image
        banana.localScale = Vector3.one * 1.2f;//setting the scale of the banana to make it bigger
    }

    public void MouseJustLeftImage()
    {
        Debug.Log("The mouse just left the image!");
        banana.localScale = Vector3.one;
    }
    void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            OnTimerHasFinished.Invoke();//Invoke is gonna call all the function 
            t = 0;
        }
    }
}
