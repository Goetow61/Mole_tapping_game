using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleGenerator : MonoBehaviour
{
    public GameObject MolePrefab;
    float span = 1.5f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        // GameObject Mole0 = GameObject.Find("MolePrefab(Clone)");
        GameObject[] Holes = GameObject.FindGameObjectsWithTag("HolePrefab");

        if (Holes.GetLength(0) > 0 && delta > span)
        {
            delta = 0;
            GameObject Mole = new GameObject();
            int x = Random.Range(0, Holes.GetLength(0)-1);
            //GameObject Hole = GameObject.Find("HolePrefab(Clone)");
            //Mole = Instantiate(MolePrefab, Hole.transform);
            Mole = Instantiate(MolePrefab, Holes[x].transform);

            //モグラを生成した穴のタグを、「Untagged」に切り替える
            Holes[x].tag = "Untagged";
        }
    }
}
