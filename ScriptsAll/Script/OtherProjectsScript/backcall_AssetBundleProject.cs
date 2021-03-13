using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backcall : MonoBehaviour {

    public void CallBack(string scene) {
        SceneManager.LoadScene(scene);
    }
}
