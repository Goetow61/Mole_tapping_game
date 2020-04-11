using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject ScoreController;

    // Start is called before the first frame update
    void Start()
    {
        int score = ScoreController.GetComponent<ScoreController>().score;
        GetComponent<Text>().text = score.ToString("000") + "点";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
