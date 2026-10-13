using UnityEngine;

public class ball_Reo1 : MonoBehaviour
{
    float startingPoint; //시작위치
    float distance; //움직인 거리

    void Start()
    {
        startingPoint = transform.position.z; // 처음위치
        Debug.Log($"시작위치 {startingPoint}");

    }

    void Update()
    {
        //현재 위치: transform.postion.z
        Debug.Log($"현재 위치 : {transform.position.z}");
        //현재위치 - 처음위치
        distance = distance - startingPoint;
        Debug.Log($"움직인 거리 -> {distance}");

    }
}
