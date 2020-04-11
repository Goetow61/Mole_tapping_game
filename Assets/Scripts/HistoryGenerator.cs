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
    public string[][] jag;

    // Start is called before the first frame update
    void Start()
    {
        if (System.IO.File.Exists(@"SaveScore.csv"))
        {
            // CSVを読み込んでジャグ配列へ
            jag = ReadCsvToJaggedArray(@"SaveScore.csv");

            // 配列の並び変えと履歴オブジェクトの作成 true:降順, 0:日付
            SortAndGenerate(true, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 履歴の並び替え
    public void SortAndGenerate(bool order, int index)
    {
        // tag Destroyを探して、有るならDestroy(Destroy)
        GameObject[] ScoreNodes = GameObject.FindGameObjectsWithTag("Destroy");
        if (ScoreNodes.GetLength(0) > 0)
        {
            // 一旦履歴を削除
            foreach (GameObject Node in ScoreNodes)
            {
                Destroy(Node);
            }
        }

        // 条件別にソート
        if (order)
        {
            Array.Sort(jag, (x, y) => String.Compare(y[index], x[index]));
        }
        else
        {
            Array.Sort(jag, (x, y) => String.Compare(x[index], y[index]));
        }

        // 履歴オブジェクトの作成
        foreach (string[] line in jag)
        {
            GameObject History = Instantiate(ScoreNode, transform);
            History.GetComponent<ScoreNodeController>().DateTime.GetComponent<Text>().text = line[0];
            History.GetComponent<ScoreNodeController>().Score.GetComponent<Text>().text = line[1];
        }
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
