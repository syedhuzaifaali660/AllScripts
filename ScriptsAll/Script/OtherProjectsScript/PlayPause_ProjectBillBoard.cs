using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour {

    public GameObject Play, Pause;
    public VideoPlayer VideoPlayer;

    public void play()
    {
        VideoPlayer.Play();
        Play.SetActive(false);
        Pause.SetActive(true);
    }

    public void pause()
    {
        VideoPlayer.Pause();
        Pause.SetActive(false);
        Play.SetActive(true);
    }
}
