using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가한다

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    private Player player;

    void Start()
    {
        hpGauge = GameObject.Find("HpGauge");
        player = GetComponent<Player>();
    }

    public void DecreaseHp()
    {
        Image image = hpGauge.GetComponent<Image>();

        if (image == null)
        {
            Debug.LogError("Image 컴포넌트를 찾을 수 없습니다!");
            return;
        }

        Debug.Log("현재 fillAmount: " + image.fillAmount);
        image.fillAmount -= 0.1f;
        if (image.fillAmount <= 0)
        {
            player.GameOver();
        }
    }
}
