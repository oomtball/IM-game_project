using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorANum1 : MonoBehaviour {
    public static GameObject red;
    public static GameObject blue;
    public static GameObject green;
    public static GameObject yellow;
    public static bool hasColor = false;
    public static bool ans1IsRight = false;
    private void Start()
    {
        red = GameObject.Find("num1Red");
        blue = GameObject.Find("num1Blue");
        green = GameObject.Find("num1Green");
        yellow = GameObject.Find("num1Yellow");
        /*
        red.SetActive(false);
        blue.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(false);
        */
    }
    private void OnMouseDown()
    {
        if (!hasColor)
        {
            if (gettingTubeRed.tubeRed)
            {
                hasColor = true;
                ans1IsRight = true;
                red.SetActive(true);
            }
            else if (gettingTubeBlue.tubeBlue)
            {
                hasColor = true;
                blue.SetActive(true);
            }
            if (gettingTubeGreen.tubeGreen)
            {
                hasColor = true;
                green.SetActive(true);
            }
            if (gettingTubeYellow.tubeYellow)
            {
                hasColor = true;
                yellow.SetActive(true);
            }
        }
    }
}
