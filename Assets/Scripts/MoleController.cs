using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(countTime);
    }

    // モグラをクリックしたら、モグラを消す
    public void MoleClick()
    {
        Destroy(gameObject);
    }
}
