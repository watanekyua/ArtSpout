using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveInExe : MonoBehaviour
{
    static LiveInExe instance;
    void Awake()
    {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
