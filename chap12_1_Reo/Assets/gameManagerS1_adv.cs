using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManagerS1_adv : MonoBehaviour
{
    public Text ballText;
    int ballCnt = 0;

    void Start()
    {
        ballCnt = GameObject.FindGameObjectsWithTag("Ball").Length;
        ballText.text = $"남은 공의 수 : {ballCnt.ToString()}";

    }

    public void CountMethod()
    {
        ballCnt--;
        Debug.Log($"남은 공의 수 : {ballCnt.ToString()}");
        ballText.text = $"남은 공의 수 : {ballCnt.ToString()}";

        if (ballCnt == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
