using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonToggle : MonoBehaviour
{
    public GameObject CanvasMain, ARCanvas, VideoCanvas;
    public VideoPlayer VideoPlayer;

    public Button Toggle;
    public GameObject Slider;
    public Sprite On, Off;
    private int Counter = 0;

    public GameObject Image;
    public Slider Scaler;

    public void ChangeButton()
    {
        Counter++;
        if (Counter % 2 == 1)
        {
            Toggle.image.overrideSprite = On;
            Slider.SetActive(true);
        }
        else
        {
            Toggle.image.overrideSprite = Off;
            Slider.SetActive(false);
        }
    }

    public void SlideAdjust(float NewValue)
    {
        Vector2 Scale = Image.transform.localScale;
        Scale.x = NewValue;
        Scale.y = NewValue;
        Image.transform.localScale = Scale;
    }

    public void VideoButton()
    {
        VideoCanvas.SetActive(true);
        VideoPlayer.Play();
    }

    public void TryOnButton()
    {
        CanvasMain.SetActive(true);
        ARCanvas.SetActive(false);
    }

    public void WebSiteButton()
    {
        Application.OpenURL("https://www.alkaramstudio.com/1-piece-cambric-shirt-20733");
    }

    public void CloseVideoPanel()
    {
        VideoCanvas.SetActive(false);
    }

    public void BackButton()
    {
        CanvasMain.SetActive(false);
    }
}
