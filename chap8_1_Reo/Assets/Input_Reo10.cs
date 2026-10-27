using UnityEngine;

public class Input_Reo10 : MonoBehaviour
{

    void Start()
    {

    }



    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("스페이스버튼이 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);//공이 앞쪽이동
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            Debug.Log("스페이스버튼이 눌러지지않음");
            GetComponent<Rigidbody>().AddForce(Vector3.up * -100);//공이 뒤쪽이동

        }
    }
}
