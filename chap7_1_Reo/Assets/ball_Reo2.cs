using UnityEngine;

public class ball_Reo2 : MonoBehaviour
{
    float startingPoint; //시작위치
    float distance; //움직인 거리

    void Start()
    {
        startingPoint = transform.position.x; // 처음위치
        Debug.Log($"x축 시작위치 {startingPoint}");

    }

    void Update()
    {
        //현재 위치: transform.postion.x
        Debug.Log($"x축 현재 위치 : {transform.position.x}");
        //현재위치 - 처음위치
        distance = distance - startingPoint;
        Debug.Log($"x축 움직인 거리 -> {distance}");

    }
}
