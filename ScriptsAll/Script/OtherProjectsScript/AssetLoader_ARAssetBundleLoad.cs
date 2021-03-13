using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;

public class AssetLoader : MonoBehaviour
{
    private string[] scenePaths;
    void Start()
    {
        StartCoroutine(GetAssetBundle());

    }

    IEnumerator GetAssetBundle()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("https://www.dropbox.com/s/la5pe2edt6m0x57/livenews?dl=1");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            scenePaths = bundle.GetAllScenePaths();
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 500, 250), "Change Scene"))
        {
            Debug.Log("Scene2 loading: " + scenePaths[0]);
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        }
    }
}