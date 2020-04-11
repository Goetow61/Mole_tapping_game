using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortController1 : MonoBehaviour
{
    public GameObject HistoryGenerator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 日時ヘッダをクリックしたら、日時ソートする
    public void HeaderDateTimeClick()
    {
        if ( this.tag == "Descending" )
        {
            this.tag = "Ascending";
            HistoryGenerator.GetComponent<HistoryGenerator>().SortAndGenerate(false, 0);
        }
        else
        {
            this.tag = "Descending";
            HistoryGenerator.GetComponent<HistoryGenerator>().SortAndGenerate(true, 0);
        }
    }
}
