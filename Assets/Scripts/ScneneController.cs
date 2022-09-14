using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ScneneController : MonoBehaviour
{
    public static ScneneController instance;
    public ScriptsCamera obsCam;
    public CanvasGroup toFadeGroup;
    public float fadeTime = 0.7f;
    public float LoadingBuffTime = 1;

    public GameObject screenNumber;
    public GameObject cubes;

    public string Scene_Root;
    public string Scene_5;
    public string Scene_6;
    public string Scene_7;
    public string Scene_8;

    void Awake(){
        instance = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)){
            //Debug.Log('1');
            screenNumber.SetActive(!screenNumber.activeSelf);
        }

        if(Input.GetKeyDown(KeyCode.F2)){
            //Debug.Log('1');
            cubes.SetActive(!cubes.activeSelf);
        }

        if(Input.GetKeyDown(KeyCode.F4)){
            GoStage(Scene_Root);
        }

        if(Input.GetKeyDown(KeyCode.F5)){
            GoStage(Scene_5);
        }
        if(Input.GetKeyDown(KeyCode.F6)){
            GoStage(Scene_6);
        }
        if(Input.GetKeyDown(KeyCode.F7)){
            GoStage(Scene_7);
        }
        if(Input.GetKeyDown(KeyCode.F8)){
            GoStage(Scene_8);
        }
    }

    async void GoStage(string sceneName){
        await FireFadeEffect(() => {
            SceneManager.LoadScene(sceneName);
        });
    }

    async Task FireFadeEffect(System.Action doThing){
        toFadeGroup.DOFade(1, fadeTime);
        await Task.Delay(Mathf.FloorToInt(fadeTime * 1000));
        
        doThing?.Invoke();

        await Task.Delay(Mathf.FloorToInt(LoadingBuffTime * 1000));

        toFadeGroup.DOFade(0, fadeTime);
    }
}
