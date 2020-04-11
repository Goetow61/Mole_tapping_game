using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲームを始めるボタンを押したらゲームシーンに切り替え
    public void StartButtonClick()
    {
        SceneManager.LoadScene("Main");
    }

    // 履歴を見るボタンを押したら履歴シーンに切り替え
    public void HistoryButtonClick()
    {
        SceneManager.LoadScene("History");
    }

    // ホームボタンを押したらTopシーンに切り替え
    public void HomeButtonClick()
    {
        SceneManager.LoadScene("Top");
    }
}
