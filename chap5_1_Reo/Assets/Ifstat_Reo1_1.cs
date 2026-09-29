using UnityEngine;

public class Ifstat_Reo1_1 : MonoBehaviour
{
    Rigidbody rd;

    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody>();
        rd.WakeUp();
        Debug.Log("나 떨어지는 중");
    }

    void OnMouseDown()
    {
        rd.Sleep();
        Debug.Log("나 멈춤");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
