using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour
{
    public GameObject MolePrefab;
    public GameObject Timer;
    float span = 1.5f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 前フレームとの差分時間をdeltaに累積する
        delta += Time.deltaTime;
        // モグラが生成されていない穴オブジェクト全てを取得する
        GameObject[] Holes = GameObject.FindGameObjectsWithTag("HolePrefab");

        // 約1.5秒間隔で、モグラが生成されていない穴があれば、モグラを生成する
        if (Holes.GetLength(0) > 0 && delta > span && Timer.GetComponent<TimerController>().timer > 0.0f)
        {
            // 次のモグラ生成に備える為差分時間リセット
            delta = 0;
            // 0～穴の数-1の間でランダムな整数値を取得
            int x = Random.Range(0, Holes.GetLength(0)-1);
            // 穴の子要素としてモグラを生成
            GameObject Mole = Instantiate(MolePrefab, Holes[x].transform);

            //モグラを生成した親要素の穴のタグを、「Untagged」に切り替える
            Holes[x].tag = "Untagged";
        }
    }
}
