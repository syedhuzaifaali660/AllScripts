using System;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class VuforiaPlacingObjectOnce : MonoBehaviour
{
    public GameObject AnchorStage;
    private GameObject _anchorGameObject;
    private GameObject _previousAnchor;
    private PositionalDeviceTracker _deviceTracker;
    public Transform A;
    int count = 1;

    private void AnchorGameObjectSetHitTestPosition(HitTestResult reuslt)

    {

        _anchorGameObject.transform.position = reuslt.Position;

        _anchorGameObject.transform.rotation = reuslt.Rotation;

    }

    public void NewAnchorHitTest(HitTestResult result)
    {

        var listenerBehaviour = GetComponent<AnchorInputListenerBehaviour>();

        var anchor = _deviceTracker.CreatePlaneAnchor(Guid.NewGuid().ToString(), result);
        _anchorGameObject = new GameObject();
        AnchorGameObjectSetHitTestPosition(result);

        if (anchor != null)
        {

            listenerBehaviour.enabled = true;
            Debug.Log("running");

            newPosition = _anchorGameObject.transform;


            newPosition = AnchorStage.transform;

            //AnchorStage.transform.parent = _anchorGameObject.transform;

            //AnchorStage.transform.localPosition = Vector3.zero;

            //AnchorStage.transform.localRotation = Quaternion.identity;

            //AnchorStage.SetActive(true);

        }
        if (_previousAnchor != null)
        {
            Destroy(_previousAnchor);
        }
        _previousAnchor = _anchorGameObject;
    }

    public void OnInteractiveHitTest(HitTestResult result)
    {
        var listenerBehaviour = GetComponent<AnchorInputListenerBehaviour>();
        if (listenerBehaviour != null)
        {
            listenerBehaviour.enabled = false;
            
        }
    }


    public Text m_MyText;
    private Transform newPosition;

    void Start()
    {
        //Text sets your text to say this message
        m_MyText.text = "NOT HIT";
    }
    public void HitAuto(HitTestResult result)
    {
        m_MyText.text = "HIT !!!!";
    }


    public void countIncrement()
    {
        count = count + 1;
        Debug.Log("VuforiaPlacingScript Function countIncrement"+count);
    }

}
