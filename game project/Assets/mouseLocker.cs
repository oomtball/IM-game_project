using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLocker : MonoBehaviour {

    public bool locking = true;

	// Update is called once per frame
    void mouseLock(){
        if (locking)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }
}
