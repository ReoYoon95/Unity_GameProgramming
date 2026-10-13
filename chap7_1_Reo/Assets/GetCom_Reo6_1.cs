using UnityEngine;

public class GetCom_Reo6_1 : MonoBehaviour
{
    Rigidbody mRigidbody;
    SphereCollider mCollider;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
        Debug.Log($"중력사용? {mRigidbody.useGravity}");
        mCollider = GetComponent<SphereCollider>();

    }

    void Update()
    {
        mCollider.radius = mCollider.radius + 0.01f;
        Debug.Log($"공의 반지름은? : {mCollider.radius}");

    }
}
