using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTrapControl : MonoBehaviour {

	void Update () {
        if (!sixButton.right || !zeroButton.right || !sevenButton.right || !threeButton.right){
            sixButton.countZero();
            zeroButton.countZero();
            sevenButton.countZero();
            threeButton.countZero();
        }
	}
}
