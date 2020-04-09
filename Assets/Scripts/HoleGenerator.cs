using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleGenerator : MonoBehaviour
{

    public GameObject HolePrefab;


    // Start is called before the first frame update
    void Start()
    {
        // サイコロの5の目に穴を配置する座標指定
        float[,] positions = new float[5, 2]
        {
            { -2.8f, 0.4f }, { 2.8f, 0.4f }, { 0f, -1.2f }, { -2.8f, -2.8f }, { 2.8f, -2.8f }
        };

        // オブジェクト配列を座標指定要素数だけ定義
        GameObject[] Holes = new GameObject[positions.GetLength(0)];
        GameObject PlayCanvas = GameObject.Find("PlayCanvas");

        // 座標指定要素だけ、HolePrefabを元に生成
        for (int i = 0; i < positions.GetLength(0); i++)
        {
            Holes[i] = Instantiate(HolePrefab, new Vector3(positions[i, 0], positions[i, 1], 90), Quaternion.identity);
            Holes[i].transform.SetParent( PlayCanvas.transform, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
