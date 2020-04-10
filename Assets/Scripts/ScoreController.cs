using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreController : MonoBehaviour
{
    public int score = 0;
    public DateTime date1 = new DateTime();

    float span = 1;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            Debug.Log(DateTime.Now.ToString("yyyy/MM/dd HH:mm") + "  " + score + "  end:" + date1.ToString("yyyy/MM/dd HH:mm"));
        }
    }

    public void CountUp(int value)
    {
        score += value;
    }

    public void SetDateTime()
    {
        date1 = DateTime.Now;
    }
}
