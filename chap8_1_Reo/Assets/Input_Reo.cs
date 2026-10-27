using UnityEngine;

public class Input_Reo : MonoBehaviour
{
    private float xRotation;

    void Start()
    {
        float xRotation = transform.localEulerAngles.x;

    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("왼쪽마우스버튼이 눌러짐");
            xRotation += 10;
            transform.localEulerAngles = new Vector3(xRotation, 0, 0); //우리 시점 오른쪽 회전
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("우측마우스버튼이 눌러짐");
            xRotation -= 10;

            transform.localEulerAngles = new Vector3(xRotation, 0, 0); //우리 시점 왼쪽 회전
        }
    }
}
