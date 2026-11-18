using UnityEngine;

public class Array_Reo : MonoBehaviour
{
    int student1 = 80;
    //int student2 = 90;
    //int student3 = 100;
    //int student4 = 85;
    //int student5 = 60;
    int[] students = { 80, 90, 100, 85, 60 };

    void Start()
    {
        Debug.Log(student1);
        //이렇게이어서
        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log(students[i]);
        }
    }

    void Update()
    {

    }
}
