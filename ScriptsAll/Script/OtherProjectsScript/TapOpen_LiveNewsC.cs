using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOpen : MonoBehaviour {

    GameObject VideoPlayer;
    //GameObject Complete;

	// Use this for initialization
	void Start () {

        VideoPlayer = GameObject.Find("ImageTarget").transform.Find("VideoPlayer").gameObject;
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
                if (hit.transform.name == "Quad")
                {
                    VideoPlayer.SetActive(true);
                }
            }
        }

    }
}
