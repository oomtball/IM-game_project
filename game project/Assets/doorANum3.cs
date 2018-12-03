using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorANum3 : MonoBehaviour
{
    public static GameObject red;
    public static GameObject blue;
    public static GameObject green;
    public static GameObject yellow;
    public static bool hasColor = false;
    public static bool ans3IsRight = false;
    private void Start()
    {
        red = GameObject.Find("num3Red");
        blue = GameObject.Find("num3Blue");
        green = GameObject.Find("num3Green");
        yellow = GameObject.Find("num3Yellow");
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
                red.SetActive(true);
            }
            else if (gettingTubeBlue.tubeBlue)
            {
                hasColor = true;
                ans3IsRight = true;
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
