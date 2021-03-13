using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class TakeScreenshot : MonoBehaviour, IPointerDownHandler
{

    public UnityEvent OnlongClick;
    private bool PointerDown;
    public GameObject ButtonPanel;
    public AudioSource CameraShutter;

    public void OnPointerDown(PointerEventData eventData)
    {
        PointerDown = true;

    }

    public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");

    }

    private void Reset()
    {
        PointerDown = false;
        ShowPanel();
    }

    IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
        CameraShutter.Play();
        ScreenCapture.CaptureScreenshot(pathToSave);
		yield return new WaitForEndOfFrame();
        Reset();
    }

    private void Update()
    {
        if (PointerDown)
        {
            HidePanel();
            TakeAShot();
        }
    }

    private void HidePanel()
    {
        ButtonPanel.SetActive(false);
      
    }

    private void ShowPanel()
    {
        ButtonPanel.SetActive(true);
 
    }


}
