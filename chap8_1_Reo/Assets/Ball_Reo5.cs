using UnityEngine;

public class Ball_Reo5 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("U(이)가 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B(이)가 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.down * 200);
        }

    }
}
