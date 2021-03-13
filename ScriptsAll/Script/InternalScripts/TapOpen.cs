﻿using UnityEngine;
using UnityEngine.UI;

public class TapOpen : MonoBehaviour
{

    //GameObject Cube;
    //public GameObject Cube2, Sofa;
    [Header("GAME OBJECTS")]
    public GameObject Sofa;
    public GameObject PlaneDetection;

    public Hover hover;


    public void PlaneDetectionOff()
    {
        PlaneDetection.SetActive(false);
    }
    public void PlaneDetectionOn()
    {
        PlaneDetection.SetActive(true);
    }

    //private void Awake()
    //{
    //    PlaneDetectionOff();
    //}



    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "SofaMesh")
                {
                    if (hover.HoverVariable == true)
                    {
                        Sofa.GetComponent<DragObjectOriginal>().enabled = true;
                        //PlaneDetectionOff();
                    }
                    else
                    {
                        Sofa.GetComponent<DragObjectOriginal>().enabled = false;
                        //PlaneDetectionOn();               
                    }
                }
                else
                {                 
                }
            }
        }
        //this script should be on the object that it is manipulating
    }


    //Use this for initialization

    // Update is called once per frame
    //void Start()
    //{


    //    //Cube = GameObject.Find("Tester").transform.Find("Cube").gameObject;
    //    //Cube2 = GameObject.Find("Tester").transform.Find("Cube2").gameObject;
    //    //Sofa = GameObject.Find("SofaHolder").transform.Find("Sofa").gameObject;


    //}
}