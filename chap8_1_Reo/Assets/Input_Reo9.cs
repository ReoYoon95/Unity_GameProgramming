using UnityEngine;

public class Input_Reo9 : MonoBehaviour
{

    void Start()
    {

    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽버튼이 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);//공이 앞쪽이동
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("우측버튼이 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.forward * -100);//공이 뒤쪽이동

        }
    }
}
