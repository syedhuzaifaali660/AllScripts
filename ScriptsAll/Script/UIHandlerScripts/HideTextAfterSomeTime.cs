using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideTextAfterSomeTime : MonoBehaviour
{
    #region VARIABLES
    [Header("GAME OBJECTS")]
    public GameObject WallText;
    public GameObject ModelText;
    public GameObject Screen3;
    public GameObject Screen2;

    [Header("UI Elements")]
    public Button Screen3_AnimationButton;
    public Button BackButton;

    float InstructionSec = 3f;
    //float UISec = 5f;
    #endregion


    public void RestScreen2()
    {
        WallText.SetActive(true);
        ModelText.SetActive(false);
        Screen2.SetActive(false);
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(InstructionSec);

        WallText.SetActive(false);
        //Do Function here...
        ModelText.SetActive(true);
        Screen3.SetActive(true);
        Screen3_AnimationButton.interactable = false;
    }

    IEnumerator LateCall2()
    {

        yield return new WaitForSeconds(InstructionSec);

        //Do Function here...
        ModelText.SetActive(false);
    }




    // Update is called once per frame
    void Update()
    {
        
        if (WallText.activeInHierarchy)
        {
            BackButton.interactable = false;
            StartCoroutine(LateCall());
        }
        else if (ModelText.activeInHierarchy)
        {

            StartCoroutine(LateCall2());
        }
        else if (Screen3.activeInHierarchy)
        {
            Screen3_AnimationButton.interactable = true;
            RestScreen2();
            BackButton.interactable = true;
        }
    }
    
}
