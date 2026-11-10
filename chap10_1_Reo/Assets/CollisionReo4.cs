using UnityEngine;

public class CollisionReo4 : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        // 1. 부딪힌 상대방에게 Rigidbody가 있는지 먼저 가져옵니다.
        Rigidbody targetRb = col.gameObject.GetComponent<Rigidbody>();

        // 2. 상대방에게 Rigidbody가 없다면(Cube, 바닥, 벽 등) 즉시 종료
        if (targetRb == null) return;

        // 3. 내 자신에게도 Rigidbody가 있는지 확인
        Rigidbody myRb = gameObject.GetComponent<Rigidbody>();
        if (myRb == null) return;

        // 4. 방향 벡터 계산 및 단위 벡터화(정규화)
        Vector3 direction = transform.position - col.gameObject.transform.position;
        direction = direction.normalized;

        // 5. 각각 반대 방향으로 400f 힘 적용
        targetRb.AddForce(-direction * 400f);
        myRb.AddForce(direction * 400f);
    }

    void Update()
    {

    }
}