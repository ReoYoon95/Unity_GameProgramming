using UnityEngine;

public class Ball_Reo4 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("L(이)가 눌러짐");
            GetComponent<Rigidbody>().AddForce(Vector3.left * 100);
        }

    }
}
