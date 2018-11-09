using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    public string goToTheScene;

    // Use this for initialization
    public void click()
    {
        SceneManager.LoadScene(goToTheScene);
    }
}
