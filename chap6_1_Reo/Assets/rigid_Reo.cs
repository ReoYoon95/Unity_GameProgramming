using UnityEngine;

public class rigid_Reo : MonoBehaviour
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
        }
        else
        {
            rd1.Sleep();
        }
    }

    void Update()
    {

    }
}
