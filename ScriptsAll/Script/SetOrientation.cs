using UnityEngine;
using UnityEngine.UI;


public class SetOrientation : MonoBehaviour
{
    public UIHandleManager UI_Handler;
    //public Text text;

    void Update()
    {
        if (UI_Handler.UI_Screen0.activeInHierarchy || UI_Handler.UI_Screen1.activeInHierarchy || UI_Handler.UI_Screen2.activeInHierarchy)
        {
            Screen.orientation = ScreenOrientation.Portrait;
            //text.text = "Potrait";
        }
        else
        {
            Screen.orientation = ScreenOrientation.AutoRotation;
            //text.text = "AutoRotate On";

        }

        //elseif (UI_Handler.UI_Screen3.activeInHierarchy)


    }

    //public void Print()
    //{
    //    Debug.Log("activeSelf is : " + UI_Handler.UI_Screen0.activeSelf);
    //    Debug.Log("activeInHierarchy is : " + UI_Handler.UI_Screen0.activeInHierarchy);

    //}

}
