using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.IO;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public DateTime date1 = new DateTime();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CountUp(int value)
    {
        score += value;
    }

    public void SetDateTime()
    {
        date1 = DateTime.Now;
        SaveScore();
    }

    void SaveScore()
    {
        // ファイル書き出し
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        StreamWriter sw = new StreamWriter(@"SaveScore.csv", true, Encoding.GetEncoding("Shift_JIS"));
        // データ出力
        string[] str = { date1.ToString("yyyy/MM/dd HH:mm"), score.ToString() };
        string str2 = string.Join(",", str);
        sw.WriteLine(str2);
        // StreamWriterを閉じる
        sw.Close();
    }
}
