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
    // Start is called before the first frame update
    void Start()
    {
        // CSVファイルの存在を確認
        if ( System.IO.File.Exists(@"SaveScore.csv") )
        {
            // ファイル読み込み
            // 引数説明：第1引数→ファイル読込先, 第2引数→エンコード
            StreamReader sr = new StreamReader(@"SaveScore.csv", Encoding.GetEncoding("Shift_JIS"));

            // https://qiita.com/Akematty/items/2fbb61b55132ced4a3be
            // ストリームリーダーをstringに変換
            string strStream = sr.ReadToEnd();

            // StringSplitOptionを設定(空行は格納しないことにする)
            System.StringSplitOptions option = StringSplitOptions.RemoveEmptyEntries;

            // 行に分ける
            string[] lines = strStream.Split(new char[] { '\n' }, option);

            // ソート(降順) Array.Sort()は昇順デフォルトで、Array.Reverse()は並びを逆にするらしい。
            Array.Sort(lines);
            Array.Reverse(lines);

            //foreach (string line in lines)
            //{
                
            //}

            // 一旦コンソールに出して確認
            //foreach (string line in lines)
            //{
            //    Debug.Log(line);
            //}

            // StreamReaderを閉じる
            sr.Close();
        }
        else
        {
            // 履歴無し
            Debug.Log("CSVが無い");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
