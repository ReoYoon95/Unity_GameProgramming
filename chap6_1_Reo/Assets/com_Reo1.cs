using UnityEngine;

public class com_Reo1 : MonoBehaviour
{
    GameObject cam;
    int fieldDistance = 60;

    private void Start()
    {
        cam = Camera.main.gameObject;
    }

    void OnMouseDown()
    {
        fieldDistance += 10;
        Debug.Log(fieldDistance);
        if (fieldDistance >= 110)
        {
            Debug.Log("작아서 안보임");
        }
        cam.GetComponent<Camera>().fieldOfView = fieldDistance;
    }


    void Update()
    {

    }
}
