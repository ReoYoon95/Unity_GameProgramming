using UnityEngine;

public class gameBall_Reo : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
        }
    }

    void Update()
    {
        // 위쪽 방향키 (Z축 앞)
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 500);
        }

        // 아래쪽 방향키 (Z축 뒤)
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 500);
        }

        // 왼쪽 방향키 (X축 왼쪽)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 500);
        }

        // 오른쪽 방향키 (X축 오른쪽)
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 500);
        }
    }
}

