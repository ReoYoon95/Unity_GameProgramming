using UnityEngine;

public class LeftrightReo_1 : MonoBehaviour
{
    public Transform k1;
    public Transform k2;
    public Transform k3;
    public Transform k4;
    int defaultValue = 0;
    void Start()
    {
        k1.transform.position = new Vector3(k1.transform.position.x, defaultValue, k1.transform.position.z);
        k2.transform.position = new Vector3(k2.transform.position.x, defaultValue + 5, k2.transform.position.z);
        k3.transform.position = new Vector3(k3.transform.position.x, defaultValue + 10, k3.transform.position.z);
        k4.transform.position = new Vector3(k4.transform.position.x, defaultValue + 15, k4.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
