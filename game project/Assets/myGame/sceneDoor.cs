using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneDoor : MonoBehaviour {

    [Header("to the other scene")]
    public string goToTheScene;
    public int test = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && test == 0)
        {
            SceneManager.LoadScene(goToTheScene);
            test += 1;
        }
    }
}
