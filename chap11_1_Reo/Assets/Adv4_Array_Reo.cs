using UnityEngine;

public class Adv4_Array_Reo : MonoBehaviour
{

    void OnTriggerEnter(Collider col2)
    {
        if (col2.tag == "Coin")
        {
            Destroy(col2.gameObject);
        }

        else if (col2.tag == "RC")
        {

            Vector3 p = col2.transform.position;
            col2.transform.position = new Vector3(p.x, p.y + 10, p.z);

        }
    }

}
