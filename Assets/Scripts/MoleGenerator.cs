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
        GameObject Mole0 = GameObject.Find("MolePrefab(Clone)");

        if (Mole0 == null && delta > span)
        {
            delta = 0;
            GameObject Mole = new GameObject();
            GameObject Hole = GameObject.Find("HolePrefab(Clone)");
            Mole = Instantiate(MolePrefab, Hole.transform);
        }
    }
}
