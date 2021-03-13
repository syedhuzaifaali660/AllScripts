using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class SelfieUI_Button : MonoBehaviour
{

    public GameObject SelfieUI;
    public GameObject BOB_UI;
    public GameObject CylinderPanel;
    public GameObject MainObjects;
    public GameObject Thumbnails;
    public GameObject PinButton;
    public GameObject VideoPlayerPanel;

    public VideoPlayer PinUIVideoplayer;
    public RawImage rawImage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void OpenUI()
    {
        SelfieUI.SetActive(true);
        MainObjects.SetActive(false);
    }

    public void BOB_OpenUI()
    {
        MainObjects.SetActive(false);
        BOB_UI.SetActive(true);
    }

    public void ShowThumb_S1()
    {
        Thumbnails.SetActive(true);
        PinButton.SetActive(false);
    }

    public void BackButton()
    {
        BOB_UI.SetActive(false);
        MainObjects.SetActive(true);
        CylinderPanel.SetActive(false);
    }

    public void PinToScreen()
    {
        BOB_UI.SetActive(false);
        VideoPlayerPanel.SetActive(true);
        if (PinUIVideoplayer.isPlaying)
        {
            PinUIVideoplayer.Pause();
            rawImage.texture = PinUIVideoplayer.texture;
            VideoPlayerPanel.SetActive(true);
            PinUIVideoplayer.Play();
        }
    }

    public void PinBackButton()
    {
      VideoPlayerPanel.SetActive(false);
      BOB_UI.SetActive(true);
    }
}