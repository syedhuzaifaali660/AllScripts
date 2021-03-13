using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
    public GameObject LoadProgress;

	public void Active() {

        LoadProgress.SetActive(true);
	}
}
