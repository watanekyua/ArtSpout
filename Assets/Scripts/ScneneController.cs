using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScneneController : MonoBehaviour
{
    public GameObject screenNumber;
    public GameObject cubes;
    public GameObject ef1;
    public GameObject ef2;
    public GameObject ef3;

    void Start(){

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

        if(Input.GetKeyDown(KeyCode.F3)){
            //Debug.Log('1');
            ef1.SetActive(!ef1.activeSelf);
        }
        if(Input.GetKeyDown(KeyCode.F4)){
            //Debug.Log('1');
            ef2.SetActive(!ef2.activeSelf);
        }
        if(Input.GetKeyDown(KeyCode.F5)){
            //Debug.Log('1');
            ef3.SetActive(!ef3.activeSelf);
        }
    }
}
