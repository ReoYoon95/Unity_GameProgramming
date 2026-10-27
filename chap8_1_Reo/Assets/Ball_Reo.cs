using UnityEngine;

public class Ball_Reo : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space가 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 600);
        }

    }
}
