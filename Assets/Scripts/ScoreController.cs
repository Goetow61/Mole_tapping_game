using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
    }
}
