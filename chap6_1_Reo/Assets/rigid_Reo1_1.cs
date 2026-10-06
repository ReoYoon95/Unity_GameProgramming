using UnityEngine;

public class rigid_Reo1_1 : MonoBehaviour
{
    Rigidbody rd1;
    int cnt = 0;

    void Start()
    {
        rd1 = gameObject.GetComponent<Rigidbody>();
        rd1.Sleep();

    }

    void OnMouseDown()
    {
        cnt++;
        if ((cnt % 2) == 1)
        {
            rd1.WakeUp();
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            rd1.Sleep();
            GetComponent<Renderer>().material.color = Color.red;

        }
    }

    void Update()
    {

    }
}
