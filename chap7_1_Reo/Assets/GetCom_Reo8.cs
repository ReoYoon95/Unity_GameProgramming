using UnityEngine;

public class GetCom_Reo8 : MonoBehaviour
{

    Rigidbody mRigidbody;

    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        mRigidbody.angularDamping = mRigidbody.angularDamping + 0.01f;
        Debug.Log($"공의 회전저항은? : {mRigidbody.angularDamping}");

    }
}
