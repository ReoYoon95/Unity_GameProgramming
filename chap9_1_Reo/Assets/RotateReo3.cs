using UnityEngine;

public class RotateReo3 : MonoBehaviour
{
    public Transform k1;

    void Start()
    {
    }

    void Update()
    {
        k1.transform.Rotate(5, 0, 0);

    }
}
