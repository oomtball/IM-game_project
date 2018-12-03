using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorANum2 : MonoBehaviour
{
    public static GameObject red;
    public static GameObject blue;
    public static GameObject green;
    public static GameObject yellow;
    public static bool hasColor = false;
    public static bool ans2IsRight = false;
    private void Start()
    {
        red = GameObject.Find("num2Red");
        blue = GameObject.Find("num2Blue");
        green = GameObject.Find("num2Green");
        yellow = GameObject.Find("num2Yellow");
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
                ans2IsRight = true;
                yellow.SetActive(true);
            }
        }
    }
}
