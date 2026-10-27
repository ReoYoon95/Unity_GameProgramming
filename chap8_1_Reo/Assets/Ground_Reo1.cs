using UnityEngine;

public class Ground_Reo1 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        float xRotation = transform.localEulerAngles.x; //x축회전
        xRotation = xRotation - Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Horizontal"));
        transform.localEulerAngles = new Vector3(xRotation, 0, 0);

    }
}
