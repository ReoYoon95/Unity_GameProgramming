using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name1 = "자기이름";
        string name2 = "옆친구이름";
        string name3 = "뒷친구이름";
        Debug.Log(name1 + name2 + name3);
        Debug.Log($"{name1}\n{name2}\n{name3}\n");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
