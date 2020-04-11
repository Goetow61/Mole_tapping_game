using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundScript : MonoBehaviour
{
    public bool DontDestroyEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            int numMusicPlayers = FindObjectsOfType<MainSoundScript>().Length;
            if (numMusicPlayers > 1)
            {
                // 2重に再生されるのを避ける。
                Destroy(gameObject);
            }
            else
            {
                // Sceneを遷移してもオブジェクトが消えないようにする
                DontDestroyOnLoad(this);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
