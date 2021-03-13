using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObj : MonoBehaviour {

    void Start()
    {
        string url = "C:/Users/waqar/OneDrive/Documents/Project/Assets Bundle Porject/AssetBundles/StandaloneWindows/cube";
        WWW www = new WWW(url);
        StartCoroutine(WaitForReq(www));
    }

    IEnumerator WaitForReq(WWW www)
    {
        yield return www;
        AssetBundle bundle = www.assetBundle;
        if (www.error == null)
        {
            GameObject obj = (GameObject)bundle.LoadAsset("Cube");
            Instantiate(obj); // **Change its position and rotation 
        }
        else
        {
            Debug.Log(www.error);
        }
    }
}
