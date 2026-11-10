using UnityEngine;

public class Adv_Reo3 : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        // 1. 부딪힌 상대방에게 Rigidbody가 있는지 먼저 가져옵니다.
        Rigidbody targetRb = col.gameObject.GetComponent<Rigidbody>();

        // 2. 상대방에게 Rigidbody가 없다면(Cube, 바닥, 벽 등) 즉시 종료
        if (targetRb == null) return;

        // 3. 내 자신에게도 Rigidbody가 있는지 확인
        Rigidbody myRb = gameObject.GetComponent<Rigidbody>();
        if (myRb == null) return;

        Vector3 direction = transform.position - col.gameObject.transform.position;
        direction = direction.normalized;
        col.gameObject.GetComponent<Rigidbody>().AddForce(-direction * 300f);

    }
}
