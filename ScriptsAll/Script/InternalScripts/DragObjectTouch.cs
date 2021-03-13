﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjectTouch : MonoBehaviour
{
    GameObject gObj;
    Plane objPlane;
    Vector3 mO;

    private Ray GenerateMouseRay()
    {
        Vector3 mousePosFar = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.farClipPlane);

        Vector3 mousePosNear = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.nearClipPlane);

        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

        Ray mr = new Ray(mousePosN, mousePosF - mousePosN);
        return mr;
    }

    
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            Ray mouseRay = GenerateMouseRay();
            RaycastHit hit;

            if(Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit))
            {

                gObj = hit.transform.gameObject;
                objPlane = new Plane(Camera.main.transform.forward * -1, gObj.transform.position);

                Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                float rayDistance;
                objPlane.Raycast(mRay, out rayDistance);
                mO = gObj.transform.position - mRay.GetPoint(rayDistance);

            }
        }

        else if (Input.GetMouseButton(0) && gObj || Input.touchCount > 0 && gObj)
        {
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(mRay, out rayDistance))
            {
                gObj.transform.position = mRay.GetPoint(rayDistance) + mO;
            }
        }

        else if (Input.GetMouseButton(0) && gObj || Input.touchCount > 0 && gObj)
        {
            gObj = null;
        }


    }
}
