using UnityEngine;

public class Input_Reo5_1 : MonoBehaviour
{
    private float xRotation;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("왼쪽마우스버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, -5, 0); //우리 시점 오른쪽 회전
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("우측마우스버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, 5, 0); //우리 시점 왼쪽 회전
        }

        if (Input.GetMouseButton(2))
        {
            Debug.Log("휠이 눌러짐");
            transform.localEulerAngles = new Vector3(10, 0, 0); //우리 시점 앞쪽 회전
        }
    }
}
