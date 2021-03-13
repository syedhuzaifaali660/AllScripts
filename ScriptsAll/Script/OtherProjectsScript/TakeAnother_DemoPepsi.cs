using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeAnother : MonoBehaviour
{

    public GameObject Takeanother;
    public GameObject Model;
    public GameObject Gallery;
    public GameObject ClickAnyWhere;


    public void TakeAnotherShot()
    {

        Takeanother.SetActive(false);
        Model.SetActive(true);
        Gallery.SetActive(false);
        ClickAnyWhere.SetActive(true);

    }
}
