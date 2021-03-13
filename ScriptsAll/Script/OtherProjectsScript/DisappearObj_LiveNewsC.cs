using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DisappearObj : MonoBehaviour {

    public GameObject VidPlayObjects;
    public VideoPlayer VideoPlayer;

    public float sec = 4f;
    void Update()
    {
        if (VideoPlayer.isPlaying)
            //VidPlayObjects.SetActive(false);

        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        VidPlayObjects.SetActive(false);
        //Do Function here...
    }

    //IEnumerator Start()
    //{
    //    if (VidPlayObjects == true)
    //    {

    //        yield return new WaitForSeconds(4);

    //        //Turn My game object that is set to false(off) to True(on).
    //        GameObject.Find("VideoPlayerUtility").SetActive(true);

    //        //Turn the Game Oject back off after 1 sec.
    //        yield return new WaitForSeconds(1);

    //        //Game object will turn off
    //        GameObject.Find("VideoPlayerUtility").SetActive(false);
    //    }
    //}
}
