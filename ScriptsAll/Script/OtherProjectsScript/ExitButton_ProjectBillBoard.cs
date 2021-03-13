using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
    public GameObject CanvasVideo;

public void ExitCanvas()
    {
        CanvasVideo.SetActive(false);
    }
}
