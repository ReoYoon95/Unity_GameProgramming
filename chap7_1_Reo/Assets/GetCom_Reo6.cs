using UnityEngine;

public class GetCom_Reo6 : MonoBehaviour
{

    Rigidbody mRigidbody;



    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
        Debug.Log($"중력사용? {mRigidbody.useGravity}");
    }

    private void OnMouseDown()
    {
        mRigidbody.useGravity = true;
        Debug.Log($"중력사용? {mRigidbody.useGravity}");
    }

    void Update()
    {

    }
}
