using UnityEngine;

public class GetCom_Reo10 : MonoBehaviour
{
    SphereCollider mCollider;
    Rigidbody mRigidbody;

    void Start()
    {
        mCollider = GetComponent<SphereCollider>();
        mRigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        mCollider.radius = mCollider.radius - 0.01f;
        Debug.Log($"공의 충돌체 반지름은? : {mCollider.radius}");
        if (mCollider.radius <= 0f)
        {
            mCollider.radius = 0f;
            mRigidbody.linearDamping = 10;
        }
    }
}
