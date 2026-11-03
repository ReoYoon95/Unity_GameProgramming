using UnityEngine;

public class SizeReo5 : MonoBehaviour
{
    public Transform k1;
    public Transform k2;
    public Transform k3;

    void Start()
    {

    }

    void Update()
    {
        k1.transform.localScale = new Vector3(2, 1, 1);
        k2.transform.localScale = new Vector3(1, 5, 1);
        k3.transform.localScale = new Vector3(1, 1, 2);
    }
}
