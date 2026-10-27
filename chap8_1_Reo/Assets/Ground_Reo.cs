using UnityEngine;

public class Ground_Reo : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        float zRotation = transform.localEulerAngles.z; //z축회전
        zRotation = zRotation - Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Horizontal"));
        transform.localEulerAngles = new Vector3(0, 0, zRotation);

    }
}
