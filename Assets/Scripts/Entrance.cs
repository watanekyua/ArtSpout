using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Entrance : MonoBehaviour
{
    public string mainScene;
    async void Start()
    {
        await Task.Delay(1000);

        if(this == null)
            return;

        SceneManager.LoadScene(mainScene);
    }
}
