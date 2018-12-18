using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class ch1Plot : MonoBehaviour {
    // Use this for initialization
    public Transform player;
    public static Flowchart flowchartManager;
    public static Flowchart talkFlowchart;
    public GameObject cube;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    private bool afterPart2 = false;
    private bool cubeActive1 = false;
    private bool cubeActive2 = false;
    private bool cubeActive3 = false;
    private bool cubeActive4 = false;
    private bool eat = false;
    public static bool talkAfter5Books = false;
    private void Awake()
    {
        flowchartManager = GameObject.FindGameObjectWithTag("flowchartController").GetComponent<Flowchart>();
        talkFlowchart = GameObject.FindGameObjectWithTag("talkFlowchart").GetComponent<Flowchart>();
    }
    public static bool boyAPart1
    {
        get { return flowchartManager.GetBooleanVariable("boyATalk"); }
    }
    public static bool boyBPart1
    {
        get { return flowchartManager.GetBooleanVariable("boyBTalk"); }
    }
    public static bool girlAPart1
    {
        get { return flowchartManager.GetBooleanVariable("girlATalk"); }
    }
    public static bool girlBPart1
    {
        get { return flowchartManager.GetBooleanVariable("girlBTalk"); }
    }
    public static bool girlCPart1
    {
        get { return flowchartManager.GetBooleanVariable("girlCTalk"); }
    }
    public static bool boyAPart2
    {
        get { return talkFlowchart.GetBooleanVariable("boyAPart2"); }
    }
    public static bool boyBPart2
    {
        get { return talkFlowchart.GetBooleanVariable("boyBPart2"); }
    }
    public static bool girlAPart2
    {
        get { return talkFlowchart.GetBooleanVariable("girlAPart2"); }
    }
    public static bool girlBPart2
    {
        get { return talkFlowchart.GetBooleanVariable("girlBPart2"); }
    }
    public static bool girlCPart2
    {
        get { return talkFlowchart.GetBooleanVariable("girlCPart2"); }
    }
    public static bool boyAPart3
    {
        get { return talkFlowchart.GetBooleanVariable("boyAPart3"); }
    }
    public static bool girlBPart3
    {
        get { return talkFlowchart.GetBooleanVariable("girlBPart3"); }
    }
    public static bool girlCPart3
    {
        get { return talkFlowchart.GetBooleanVariable("girlCPart3"); }
    }
    public static bool goOutside
    {
        get { return talkFlowchart.GetBooleanVariable("goOutside"); }
    }
    public static bool goToBoyA
    {
        get { return talkFlowchart.GetBooleanVariable("goToBoyA"); }
    }
    public static bool goToGirlB
    {
        get { return talkFlowchart.GetBooleanVariable("goToGirlB"); }
    }
    public static bool goToBoyB
    {
        get { return talkFlowchart.GetBooleanVariable("goToBoyB"); }
    }
    public static bool part3End
    {
        get { return talkFlowchart.GetBooleanVariable("part3End"); }
    }
    public static bool book1Read
    {
        get { return talkFlowchart.GetBooleanVariable("book1Read"); }
    }
    public static bool book2Read
    {
        get { return talkFlowchart.GetBooleanVariable("book2Read"); }
    }
    public static bool book3Read
    {
        get { return talkFlowchart.GetBooleanVariable("book3Read"); }
    }
    public static bool book4Read
    {
        get { return talkFlowchart.GetBooleanVariable("book4Read"); }
    }
    public static bool book5Read
    {
        get { return talkFlowchart.GetBooleanVariable("book5Read"); }
    }
    public static bool goToED1
    {
        get { return talkFlowchart.GetBooleanVariable("goToED1"); }
    }
    private void Update()
    {
        if (boyAPart1 && boyBPart1 && girlAPart1
            && girlBPart1 && girlCPart1 && !boyATalking.afterKitchen)
        {
            talkFlowchart.ExecuteBlock("endPart1");
            boyATalking.afterKitchen = true;
            boyBTalking.afterKitchen = true;
            girlATalking.afterKitchen = true;
            girlBTalking.afterKitchen = true;
            girlCTalking.afterKitchen = true;
        }
        if (boyAPart2 && boyBPart2 && girlAPart2
            && girlBPart2 && girlCPart2 && !afterPart2)
        {
            talkFlowchart.ExecuteBlock("endPart2");
            boyATalking.afterPart2 = true;
            boyBTalking.afterPart2 = true;
            girlATalking.afterPart2 = true;
            girlBTalking.afterPart2 = true;
            girlCTalking.afterPart2 = true;
            afterPart2 = true;
        }
        if (boyATalking.afterKitchen && !cubeActive1)
        {
            cube.SetActive(true);
            cubeActive1 = true;
        }
        if (goOutside && !cubeActive2)
        {
            cube2.SetActive(true);
            cubeActive2 = true;
        }
        if (goToBoyA){
            SceneManager.LoadScene("boyA");
        }
        if (goToBoyB)
        {
            SceneManager.LoadScene("boyB");
        }
        if (goToGirlB)
        {
            SceneManager.LoadScene("girlB");
        }
        if (boyAPart3 && girlBPart3 && girlCPart3 && !eat){
            talkFlowchart.ExecuteBlock("part3Eat");
            eat = true;
        }
        if (part3End && !cubeActive3)
        {
            cube3.SetActive(true);
            cubeActive3 = true;
        }
        if (kitchenCube.end1Start && !cubeActive4)
        {
            cube4.SetActive(true);
            cubeActive4 = true;
        }
        if (book1Read && book2Read && book3Read && book4Read && book5Read && !talkAfter5Books){
            talkFlowchart.ExecuteBlock("talkAfter5Books");
            talkAfter5Books = true;
        }
        if (goToED1){
            SceneManager.LoadScene("ED1Dark");
        }
    }
}
