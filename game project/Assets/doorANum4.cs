using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorANum4 : MonoBehaviour
{
    public static GameObject red;
    public static GameObject blue;
    public static GameObject green;
    public static GameObject yellow;
    public static bool hasColor = false;
    public static bool ans4IsRight = false;
    private void Start()
    {
        red = GameObject.Find("num4Red");
        blue = GameObject.Find("num4Blue");
        green = GameObject.Find("num4Green");
        yellow = GameObject.Find("num4Yellow");
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
                ans4IsRight = true;
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
