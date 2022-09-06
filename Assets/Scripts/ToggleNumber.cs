using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleNumber : MonoBehaviour
{
    public GameObject screenNumber;
    public Button BTN_Toggle;

    void Start(){
        BTN_Toggle.onClick.AddListener(() => {
            screenNumber.SetActive(!screenNumber.activeSelf);
        });
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log('1');
            screenNumber.SetActive(!screenNumber.activeSelf);
        }
    }
}
