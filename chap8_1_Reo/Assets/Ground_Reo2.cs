using UnityEngine;

public class Ground_Reo2 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        float yRotation = transform.localEulerAngles.y; //y축회전
        yRotation = yRotation - Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Horizontal"));
        transform.localEulerAngles = new Vector3(0, yRotation, 0);

    }
}
