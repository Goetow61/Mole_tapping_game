using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System.Linq;
using System;

public class HistoryGenerator : MonoBehaviour
{
    public GameObject ScoreNode;

    // Start is called before the first frame update
    void Start()
    {
        if (System.IO.File.Exists(@"SaveScore.csv"))
        {
            // CSVを読み込んでジャグ配列へ
            string[][] jag = ReadCsvToJaggedArray(@"SaveScore.csv");

            // 日付で降順にソート
            Array.Sort(jag, (x, y) => String.Compare(y[0],x[0])); // 日付-降順　★

            // オブジェクトの作成
            foreach (string[] line in jag)
            {
                GameObject History = Instantiate(ScoreNode, transform);
                History.GetComponent<ScoreNodeController>().DateTime.GetComponent<Text>().text = line[0];
                History.GetComponent<ScoreNodeController>().Score.GetComponent<Text>().text = line[1];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // CSV読み込み、ジャグ配列作成(DateTimeも、intも文字列として読込)
    static string[][] ReadCsvToJaggedArray(string path)
    {
        // ファイル読み込み
        // 引数説明：第1引数→ファイル読込先, 第2引数→エンコード
        StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));

        // https://qiita.com/Akematty/items/2fbb61b55132ced4a3be
        // ストリームリーダーをstringに変換
        string strStream = sr.ReadToEnd();

        // StringSplitOptionを設定(空行は格納しないことにする)
        System.StringSplitOptions option = StringSplitOptions.RemoveEmptyEntries;

        // 行に分ける
        string[] lines = strStream.Split(new char[] { '\n' }, option);

        // 宣言
        string[][] arr = new string[lines.GetLength(0)][];

        // 順次配列に追加
        int i = 0;
        foreach (string line in lines)
        {
            string[] splitedData = line.Split(',');
            arr[i] = new string[] { splitedData[0], splitedData[1] };
            i++;
        }
            
        // StreamReaderを閉じる
        sr.Close();

        return arr;
    }
}
