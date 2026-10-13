using UnityEngine;

public class Trap_Reo1 : MonoBehaviour
{
    float delta = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        float newYposition = transform.position.y + delta; // 상하로 움직이게 함.
        transform.position = new Vector3(transform.position.x, newYposition, transform.position.z);

        //-4.26은 실린더의 왼쪽 x좌표값
        if (transform.position.y < 0)
        {
            delta = 0.1f; //실린더가 왼쪽 끝에 오면 오른쪽으로 움직임
        }

        //우즉 좌표값
        else if (transform.position.y > 5)
        {
            delta = -0.1f; //실린더가 오른쪽 끝에 오면 왼쪽으로 움직임
        }

    }
}
