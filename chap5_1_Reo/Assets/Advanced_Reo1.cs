using UnityEngine;

public class Advanced_Reo1 : MonoBehaviour
{
    int cnt = 0;
    Vector3 step = new Vector3(1.5f, 0f, -1.5f);
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        cnt++; // 클릭 횟수 증가

        if (cnt > 4)        // 이미 골에 도착한 뒤의 클릭
        {
            print("이미 골인! 더 이상 이동하지 않음");
        }
        else if (cnt == 4)  // 4번째 클릭: 골 도착
        {
            transform.position += step;
            GetComponent<Renderer>().material.color = Color.green;  // Sphere 색을 초록색으로 변경
            transform.localScale = new Vector3(2, 2, 2);
            print("골인! Sphere가 2배로 커짐");
        }

        else // 1~3번째 클릭
        {
            transform.position += step; // 다음 발판으로 이동
            print((cnt + 1) + "번 발판으로 이동");
        }
    }
}