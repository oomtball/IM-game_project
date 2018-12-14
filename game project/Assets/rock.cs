using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour {
    public GameObject player;
    public GameObject rockBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            /*
            Vector3 rockBallPosition = new Vector3(122, 124, 69.7f);
            rockBall.GetComponent<Rigidbody>().MovePosition(rockBallPosition);
            */
            rockBall.transform.position = new Vector3(122, 124, 69.7f);
            player.transform.position = new Vector3(60.3f, 173, 67);
        }
    }
}
