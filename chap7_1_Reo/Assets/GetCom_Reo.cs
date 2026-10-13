using UnityEngine;

public class GetCom_Reo : MonoBehaviour
{

    Rigidbody mRigidbody;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
        Debug.Log($"중력사용? {mRigidbody.useGravity}");
    }

    void Update()
    {

    }
}
