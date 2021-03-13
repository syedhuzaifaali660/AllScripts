using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    private VideoPlayer VideoPlayer;
    private int VideoClipIndex;
    public string[] Urls;
    public GameObject Thumbnails;
    public GameObject CylinderPanel;
    public GameObject PinButton;

    // Start is called before the first frame update
    void Awake()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    public void PlayVideoS1T1()
    {
        CylinderPanel.SetActive(true);
        Thumbnails.SetActive(false);
        PinButton.SetActive(true);
        if (VideoPlayer.isPlaying)
        {
            VideoPlayer.Stop();
            VideoPlayer = GetComponent<VideoPlayer>();
            VideoPlayer.url = Urls[0];
            VideoPlayer.Play();
        }
        else if (!VideoPlayer.isPlaying)
        {
            VideoPlayer = GetComponent<VideoPlayer>();
            VideoPlayer.url = Urls[0];
            VideoPlayer.Play();
        }

    }

    public void PlayVideoS1T2()
    {
        CylinderPanel.SetActive(true);
        Thumbnails.SetActive(false);
        PinButton.SetActive(true);
        if (VideoPlayer.isPlaying)
        {
            VideoPlayer.Stop();
            VideoPlayer = GetComponent<VideoPlayer>();
            VideoPlayer.url = Urls[1];
            VideoPlayer.Play();
        }
        else if (!VideoPlayer.isPlaying)
        {
            VideoPlayer = GetComponent<VideoPlayer>();
            VideoPlayer.url = Urls[1];
            VideoPlayer.Play();
        }
    }
}
