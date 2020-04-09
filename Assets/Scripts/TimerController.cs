using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    float countTime = 15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countTime > 0.0f)
        {
            countTime -= Time.deltaTime; // 残り秒数を格納
            GetComponent<Text>().text = string.Format("残り {0:F1}", countTime); // 残り秒数を表示
        }
        else
        {
            // 時間切れ時の処理
        }
    }
}
