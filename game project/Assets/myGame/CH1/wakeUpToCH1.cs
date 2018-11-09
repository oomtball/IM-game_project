using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wakeUpToCH1 : MonoBehaviour {

    public string goToTheScene;

    void changeScene(string goToScene)
    {
        SceneManager.LoadScene(goToTheScene);
        Destroy(this);
    }
}
