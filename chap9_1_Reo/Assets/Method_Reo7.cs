using UnityEngine;

public class Method_Reo7 : MonoBehaviour
{
    void Start()
    {
        TestMethod("좋은하는 음식의 이름");
        SizeOBT(3, 3, 3);
    }

    void TestMethod(string name)
    {
        Debug.Log($" {name} 입니다.");
    }

    void SizeOBT(int xs, int ys, int zs)
    {
        transform.localScale = new Vector3(xs, ys, zs);
    }

    void Update()
    {

    }
}
