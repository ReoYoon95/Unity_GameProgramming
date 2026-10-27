using UnityEngine;

public class Input_Reo8 : MonoBehaviour
{

    void Start()
    {

    }



    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Debug.Log("왼쪽마우스버튼이 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10);//공이 좌측이동
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("우측마우스버튼이 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.right * 10);//공이 우측이동

        }
    }
}
