using UnityEngine;
using UnityEngine.UI;

public class gameManagerS : MonoBehaviour
{
    private int ycnt = 0;
    private int gcnt = 0;
    private int totalCoin = 0;
    public Text coinCount;
    public Text coinLeft;
    public Text getGreen;

    void Start()
    {
        totalCoin = GameObject.FindGameObjectsWithTag("YCoin").Length;
        coinCount.text = $"사라진 코인수 : {ycnt}";
        coinLeft.text = $"남은 노란 코인수 : {totalCoin}";
        getGreen.text = $"획득한 녹색 코인수 : {gcnt}";
    }

    public void CountMethod()
    {
        ycnt++;
        Debug.Log($"먹은 코인수는 {ycnt}");
        coinCount.text = $"사라진 코인수 : {ycnt.ToString()}";
        coinLeft.text = $"남은 노란 코인수 : {totalCoin - ycnt}";
        getGreen.text = $"획득한 녹색 코인수 : {gcnt}";
    }

    public void ToCount()
    {
        Debug.Log($"수고했습니다. 최종 {ycnt} 개 먹음");

    }

    public void GetGreen()
    {
        Debug.Log($"연두색 코인을 먹었습니다.");
        coinLeft.text = $"획득한 녹색 코인수 : {gcnt}";
    }

}
