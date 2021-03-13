using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
public static class ButtonExtention
{
    public static void AddEventListener<T>(this Button button, T Param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate {
            OnClick(Param);
        });
    }
}
public class AssetsbundleScene : MonoBehaviour {

    // Use this for initialization
    public string[] urls;
    [Header("UI Stuff")]
    public Transform rootContainer;
    public Button prefab;
    public Text label;

   static List<AssetBundle> assetBundle= new List<AssetBundle>();
    static List<string> Sene_Name = new List<string>();
    IEnumerator Start () {

       
        if (assetBundle.Count ==0)
        {
            int i = 0;
            while(i < urls.Length)
            {
                using (WWW www = new WWW(urls[i]))
                {
                    yield return www;
                    if (!string.IsNullOrEmpty(www.error))
                    {
                        Debug.LogError(www.error);
                        yield break;
                    }
                    assetBundle.Add(www.assetBundle);
                    Sene_Name.AddRange(www.assetBundle.GetAllScenePaths());
                }
                i++;
            }
        }
       

            foreach (string SceneName in Sene_Name) {
                print(Path.GetFileNameWithoutExtension(SceneName));
                label.text = Path.GetFileNameWithoutExtension(SceneName);
                var clone = Instantiate(prefab.gameObject) as GameObject;
                clone.GetComponent<Button>().AddEventListener(label.text, LoadScene);

                clone.SetActive(true);
                clone.transform.SetParent(rootContainer);
            }
       
	}
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void Scene() { SceneManager.LoadScene("myscene1"); }
}
