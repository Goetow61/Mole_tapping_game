using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleController : MonoBehaviour
{
    private Button moleButton;
    public GameObject ScoreController;

    // Start is called before the first frame update
    void Start()
    {
        // 自分自身(Mole)のButtonコンポーネントを取得
        moleButton = GetComponent<Button>();

        // モグラを消すメソッドをonClickイベントに紐づける
        moleButton.onClick.AddListener(MoleClick);

        // ScoreControllerオブジェクトを検索
        ScoreController = GameObject.Find("ScoreController");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(countTime);
    }

    // モグラをクリックしたら、モグラを消す
    public void MoleClick()
    {
        transform.parent.gameObject.tag = "HolePrefab";
        ScoreController.GetComponent<ScoreController>().CountUp(1);
        Destroy(gameObject);
    }
}
