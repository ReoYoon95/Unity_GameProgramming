using UnityEngine;

public class CapsuleReo : MonoBehaviour
{
    Rigidbody rd2;
    int cnt = 0;

    void Start()
    {
        rd2 = gameObject.GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        cnt++;
        if ((cnt % 2) == 1)
        {
            rd2.Sleep();
            Debug.Log("멈춤");
        }
        else
        {
            rd2.WakeUp();
            Debug.Log("움직임");

        }
    }

    void Update()
    {

    }
}
