using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {
    
    [Header("to the other scene")]
    //public string goToTheScene;
    public Vector3 yeah;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            //SceneManager.LoadScene(goToTheScene);
            player.transform.position = yeah;
        }
    }
}

