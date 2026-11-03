using UnityEngine;

public class LeftrightReo : MonoBehaviour
{
    public Transform k1;
    public Transform k2;
    public Transform k3;
    public Transform k4;

    void Start()
    {
        k1.transform.position = new Vector3(-30, k1.transform.position.y, k1.transform.position.z);
        k2.transform.position = new Vector3(-30, k2.transform.position.y, k2.transform.position.z);
        k3.transform.position = new Vector3(-30, k3.transform.position.y, k3.transform.position.z);
        k4.transform.position = new Vector3(-30, k4.transform.position.y, k4.transform.position.z);

    }

    void Update()
    {

    }
}
