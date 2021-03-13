using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;

public class LoaderProgress : MonoBehaviour
{
    public string url;
    public int downloaded = 0;
    AssetBundle bundle;
    public System.Object test;
    public Slider progressbar;
    public GameObject slider;
    public float progress;
    public GameObject NewsButton;

    WWW www;
    void Update()
    {
        progress = www.progress;
        progressbar.value = progress;
    }

    IEnumerator Start()
    {
        NewsButton.SetActive(false);
        slider.SetActive(true);
        ClearCacheExample();
        if (downloaded == 0)
        {
            using (www = WWW.LoadFromCacheOrDownload(url, 0))
            {
                yield return www;
                if (www.error != null)
                    throw new Exception("WWW download had an error:" + www.error);
                if (www.error == null)
                {
                    bundle = www.assetBundle;
                }
            }
            if(progress == 1)
           // if (Caching.ready == true)
            {
                downloaded = 1;
                string[] scenePath = bundle.GetAllScenePaths();
                Debug.Log(scenePath[0]);
                SceneManager.LoadScene(scenePath[0], LoadSceneMode.Single);
            }
        }
    }

    void ClearCacheExample()
    {
    //    Directory.CreateDirectory("Cache1");
    //    Directory.CreateDirectory("Cache2");
    //    Directory.CreateDirectory("Cache3");

    //    Caching.AddCache("Cache1");
    //    Caching.AddCache("Cache2");
    //    Caching.AddCache("Cache3");

     bool success = Caching.ClearCache();

       if (!success)
      {
           Debug.Log("Unable to clear cache");
       }
    }
}
