using UnityEngine;

public class Adv_Reo2 : MonoBehaviour
{
    public Transform earth;
    //public Transform moon;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, 1, 0);
        earth.Rotate(0, 5, 0);
        //moon.Rotate(0, 10, 0);
    }
}
