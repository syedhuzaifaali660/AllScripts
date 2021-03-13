using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIHandleManager : MonoBehaviour
{
    #region //Variables
    [Header("SCRIPTS REFERENCES")]
    public HideTextAfterSomeTime HidingObj;
    public UIAnimationManager AnimManager;
    public HideTextAfterSomeTime HideTextScript;
    public Hover hover;
   

    [Header("GAME OBJECTS")]
    //public GameObject Sofa;
    public GameObject Dimensions;
    public GameObject UI_Screen0;
    public GameObject UI_Screen1;
    public GameObject UI_Screen2;
    public GameObject UI_Screen3;
    public GameObject UI_OuterButtons;
    public GameObject UI_HowToUse;
    public GameObject UI_HowToUse_Scan;
    public GameObject UI_HowToUse_InProcess;
    public GameObject UI_HowToUse_Mobile;
    public GameObject BackButton;
    public GameObject TickButton;

    [Header("UI Elements")]
    public Sprite[] BuyNow_Sprites;
    public Image BuyNowImage;

    int DimensionsCount = 0;
    private float Timer = 0.35f;
    #endregion

    #region Ienumerator functions
    IEnumerator UI_TickB(){
        yield return new WaitForSeconds(0.3f);

        UI_BackButtonAppear();
        UI_OuterButtonAppear();
        HideTextScript.Screen3.SetActive(true);
        TickButton.SetActive(false);
    }
    #endregion

    #region UI CONTROLLING FUNCTIONS PUBLIC
    public void UI_ModelAppear()
    {
        UI_Screen1.SetActive(false);
        UI_Screen2.SetActive(true);
    }

    public void UI_OuterButtonAppear()
    {
        UI_OuterButtons.SetActive(true);
    }

    public void UI_OuterButtonDisappear()
    {
        UI_OuterButtons.SetActive(false);
    }

    public void UI_HowToUseAppear()
    {

        AnimManager.PlayHowToUseTimelineClip();

    }

    public void BuyNowImages(int buttonPressed)
    {
        //BuyNowImage.sprite = BuyNow_Sprites[0];
        switch (buttonPressed)
        {
            case 4:
                //print("Hello and good day!");
                BuyNowImage.sprite = BuyNow_Sprites[3];
                break;
            case 3:
                //print("Whadya want?");
                BuyNowImage.sprite = BuyNow_Sprites[2];
                break;
            case 2:
                //print("Grog SMASH!");
                BuyNowImage.sprite = BuyNow_Sprites[1];
                break;
            case 1:
                //print("Ulg, glib, Pblblblblb");
                BuyNowImage.sprite = BuyNow_Sprites[0];
                break;
            default:
                //print("Incorrect intelligence level.");
                break;
        }
    }

    public void UI_WallAppear()
    {
        UI_Screen0.SetActive(false);
        UI_Screen1.SetActive(true);
        BackButton.SetActive(true);
    }

    public void UI_GoBack()
    {
        if (UI_Screen1.activeInHierarchy)
        {
            UI_Screen0.SetActive(true);
            UI_Screen1.SetActive(false);
            UI_Screen3.SetActive(false);
            BackButton.SetActive(false);

        }
        else if (UI_Screen2.activeInHierarchy)
        {
            UI_WallAppear();
            HidingObj.RestScreen2();
            UI_Screen3.SetActive(false);


        }
        else if (UI_Screen3.activeInHierarchy)
        {
            UI_Screen1.SetActive(true);
            UI_Screen3.SetActive(false);
            UI_OuterButtonDisappear();

        }

    }

    void UI_BackButtonAppear()
    {
        BackButton.SetActive(true);
    }
    void UI_BackButtonDisappear()
    {
        BackButton.SetActive(false);
    }

    //public void SofaDisappear()
    //{
    //    Sofa.SetActive(false);
    //}
    //public void SofaAppear()
    //{
    //    Sofa.SetActive(true);
    //}

    public void UI_DimensionAppearDissAppear()
    {
        if (DimensionsCount == 0)
        {
            Dimensions.SetActive(true);
            AnimManager.DimensionsTimelineClip();
            DimensionsCount = 1;
        }
        else
        {
            Dimensions.SetActive(false);
            DimensionsCount = 0;
        }
    }

    public void UI_TickButtonAppear()
    {
        TickButton.SetActive(true);
        UI_OuterButtonDisappear();
        HideTextScript.Screen3.SetActive(false);
    }
    public void UI_TickButtonDisappear(){
        hover.HoverVariable = false;
        //hover.SettingSofaAnimatorToTrue();
        hover.MoveDown();

        //UI BUTTONS ACTIVATING AND DE-ACTIVATING
        StartCoroutine(UI_TickB());
    }

    #endregion


    #region EXTRA
    //int index = 0;
    //public void ChangeTexture()
    //{
    //    rend = GetComponent<Renderer>();
    //    index = index % textures.Length;
    //    Debug.Log(index);
    //    Debug.Log(textures.Length);
    //    rend.material.mainTexture = textures[index];
    //    index = index + 1;
    //    Debug.Log(index);
    //}
    #endregion
}

