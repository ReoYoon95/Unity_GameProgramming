using UnityEngine;

public class GetCom_Reo7 : MonoBehaviour
{

    Rigidbody mRigidbody;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
        Debug.Log($"중력사용? {mRigidbody.useGravity}");
    }


    void Update()
    {
        mRigidbody.linearDamping = mRigidbody.linearDamping + 0.01f;
        Debug.Log($"공의 마찰력은? : {mRigidbody.linearDamping}");

    }
}
