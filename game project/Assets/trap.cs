using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            other.transform.position = new Vector3(60.3f, 173, 67);
        }
        
    }
}
