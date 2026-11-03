using UnityEngine;

public class RotateReo : MonoBehaviour
{
    public Transform k1;

    void Start()
    {
    }

    void Update()
    {
        k1.transform.Rotate(0, 5, 0);

    }
}
