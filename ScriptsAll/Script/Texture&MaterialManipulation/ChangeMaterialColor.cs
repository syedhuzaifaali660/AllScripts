using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    #region ExtraCode
    //private Material _mat;


    //// Start is called before the first frame update
    //void Start()
    //{

    //    //Fetch the Renderer from the GameObject
    //    Renderer rend = GetComponent<Renderer>();
    //    _mat = rend.material;



    //}

    //private void Update()
    //{
    //    //Color color = new Color(100/255, 50/255, 100/255, 255/255);
    //    Color color = new Color(1, 40/255, 0, 1);
    //    //_mat.shader = Shader.Find("CarPaint");
    //    _mat.SetColor("_BaseColor", color);

    //}

    #endregion
    int count = 1;
    public GameObject[] objects;

    public void Update()
    {
        if (count == 1)
        {
            Color color = new Color(70 / 255f, 0 / 255f, 0 / 255f, 1);
            foreach (GameObject j in objects)
            {
                j.GetComponent<Renderer>().material.SetColor("_BaseColor", color);
            }
            count++;

        } else {
            return;
        }
    }
}

