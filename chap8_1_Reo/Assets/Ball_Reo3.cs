using UnityEngine;

public class Ball_Reo3 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R(이)가 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.right * 100);
        }

    }
}
