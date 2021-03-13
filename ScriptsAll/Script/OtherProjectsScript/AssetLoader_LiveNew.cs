using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.Networking;

public class AssetLoader : MonoBehaviour
{
    public GameObject ImageTarget_1;
    void Start()
    {
        StartCoroutine(GetAssetBundle());
    }
    IEnumerator GetAssetBundle()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("https://firebasestorage.googleapis.com/v0/b/livenewspaper-b92f7.appspot.com/o/AssetBundles%2FVideoPlayerUtility%2Fvideoplayerutility1?alt=media&token=c3b657a9-95da-486f-bb31-38fe17879fef");
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            var VDP = bundle.LoadAsset("VideoPlayerUtility1");
            GameObject VideoPlayer = GameObject.Instantiate(VDP) as GameObject;
            VideoPlayer.transform.parent = ImageTarget_1.transform;
            VideoPlayer.transform.localScale += new Vector3(0.3f, 0.3f, 1);

        }
    }
}