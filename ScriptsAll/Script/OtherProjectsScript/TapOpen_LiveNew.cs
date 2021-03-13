using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOpen : MonoBehaviour {

    GameObject Complete;

	// Use this for initialization
	void Start () {

        Complete = GameObject.Find("ImageTarget").transform.Find("Complete(Clone)").gameObject;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "Tap(Clone)")
                {
                    Complete.SetActive(true);
                }
            }
        }

    }
}
