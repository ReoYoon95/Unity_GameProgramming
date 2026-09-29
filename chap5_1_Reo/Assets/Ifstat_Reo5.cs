using UnityEngine;

public class Ifstat_Reo5 : MonoBehaviour
{
    int hp = 0;

    void OnMouseDown()
    {
        hp += 1;
        Debug.Log($"캡슐을 {hp}번 클릭했습니다.");
        if (hp == 5)
        {
            Destroy(gameObject, 2); //2초뒤 오브젝트 삭제
            Debug.Log("캡슐이 5번클릭되어 2초 뒤 사라집니다.");
        }


    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
