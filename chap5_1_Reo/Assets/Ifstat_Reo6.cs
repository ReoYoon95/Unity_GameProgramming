using UnityEngine;

public class Ifstat_Reo6 : MonoBehaviour
{
    int cnt = 0;
    void OnMouseDown()
    {
        cnt++;
        if (cnt % 2 == 0)
        {
            transform.localScale = new Vector3(3, 3, 3);
            Debug.Log("Shpere가 원래 크기의 3배로 커짐");
        }
        else if (cnt % 2 == 1)
        {
            transform.localScale = new Vector3(2, 2, 2);
            Debug.Log("Shpere가 원래 크기의 2배로 커짐");
        }
        else Debug.Log("현상유지");
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
