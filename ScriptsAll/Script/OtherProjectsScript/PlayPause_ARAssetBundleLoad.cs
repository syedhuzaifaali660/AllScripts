using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour {

    public GameObject Play, Repeat;
    public GameObject SmallPlay, SmallPause;
    public VideoPlayer VideoPlayer;

    public void play()
    {
        VideoPlayer.Play();
        Play.SetActive(false);
        Repeat.SetActive(true);
        SmallPlay.SetActive(false);
        SmallPause.SetActive(true);
    }

    public void pause()
    {
        VideoPlayer.Pause();
        Play.SetActive(true);
        Repeat.SetActive(true);
        SmallPause.SetActive(false);
        SmallPlay.SetActive(true);
    }

    public void repeat()
    {
        VideoPlayer.Stop();
        VideoPlayer.Play();
    }
}
