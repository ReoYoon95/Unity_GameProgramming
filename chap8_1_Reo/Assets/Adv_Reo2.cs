using UnityEngine;

public class Adv_Reo2 : MonoBehaviour
{
    void Start()
    {

    }

    int a = 0;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Debug.Log("A버튼이 눌러짐");
        //    transform.localEulerAngles = new Vector3(0, 0, a++); //우리 시점 좌측 회전
        //}


        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log("D버튼이 눌러짐");
        //    transform.localEulerAngles = new Vector3(0, 0, a--); //우리 시점 좌측 회전
        //}

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, 0, a++); //우리 시점 좌측 회전
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D버튼이 눌러짐");
            transform.localEulerAngles = new Vector3(0, 0, a--); //우리 시점 좌측 회전
        }
    }
}
