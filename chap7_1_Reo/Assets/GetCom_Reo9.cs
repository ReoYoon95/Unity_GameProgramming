using UnityEngine;

public class GetCom_Reo9 : MonoBehaviour
{
    SphereCollider mCollider;

    void Start()
    {
        mCollider = GetComponent<SphereCollider>();
    }


    void Update()
    {
        mCollider.radius = mCollider.radius + 0.01f;
        Debug.Log($"공의 충돌체 반지름은? : {mCollider.radius}");
    }
}
