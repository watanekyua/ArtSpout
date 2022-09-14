using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class v360Ball : MonoBehaviour
{
    public float rotateSpeed = 60;

    Tweener tweener;
    void Start()
    {
        tweener = transform.DORotate(new Vector3(0, 360, 0), rotateSpeed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Delete)){
            if(tweener == null){
                tweener = transform.DORotate(new Vector3(0, 360, 0), rotateSpeed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1);
            } else {
                tweener.Kill();
                tweener = null;
            }
        }
    }
}
