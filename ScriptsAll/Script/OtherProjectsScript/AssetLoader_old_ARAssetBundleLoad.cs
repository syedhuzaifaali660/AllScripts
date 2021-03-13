using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.Networking;

public class AssetLoader_old : MonoBehaviour
{
    public GameObject Image;
    void Start()
    {
        StartCoroutine(GetAssetBundle());
    }
    IEnumerator GetAssetBundle()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("https://firebasestorage.googleapis.com/v0/b/livenewspaper-b92f7.appspot.com/o/Test_SceneLoad%2Fsamplescene?alt=media&token=c0b039bd-c81f-4073-b42f-da87dfc88edb");
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            var tap = bundle.LoadAsset("Tap");
            var complete = bundle.LoadAsset("Complete");
            GameObject Tap = GameObject.Instantiate(tap) as GameObject;
            Tap.transform.parent = Image.transform;
            Tap.transform.localScale += new Vector3(1, 1, 1);
            GameObject Complete = GameObject.Instantiate(complete) as GameObject;
            Complete.transform.parent = Image.transform;
            Complete.transform.localScale += new Vector3(1, 1, 1);
        }
    }
}