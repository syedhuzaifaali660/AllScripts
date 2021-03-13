using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearObj : MonoBehaviour {

    public GameObject VidPlayObjects;

    public float sec = 4f;
    void Update()
    {
        if (VidPlayObjects.activeInHierarchy)
            //VidPlayObjects.SetActive(false);

        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        VidPlayObjects.SetActive(false);
        //Do Function here...
    }

   
}
