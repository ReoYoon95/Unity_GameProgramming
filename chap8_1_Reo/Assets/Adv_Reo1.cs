using UnityEngine;

public class Adv_Reo1 : MonoBehaviour
{
    void Start()
    {

    }

    int a = 0;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("왼쪽마우스버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, 0, a++); //우리 시점 좌측 회전
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("우측마우스버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, 0, a--); //우리 시점 좌측 회전
        }



    }
}
