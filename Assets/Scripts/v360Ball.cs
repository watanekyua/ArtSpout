using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class v360Ball : MonoBehaviour
{
    public static v360Ball instance;
    public MeshRenderer drawMesh;
    public float rotateSpeed = 60;

    public InputField INT_Angle;
    public Text angleText;

    Tweener tweener;

    // void Awake(){
    //     if(instance == null){
    //         instance = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    //     else {
    //         Destroy(gameObject);
    //     }
    // }

    void Start()
    {
        tweener = transform.DORotate(new Vector3(0, 360, 0), rotateSpeed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1).OnUpdate(() => {
            if(INT_Angle)
                INT_Angle.text = transform.localEulerAngles.y.ToString();
        });

        if(ScneneController.instance){
            // Debug.Log(ScneneController.instance);
            // Debug.Log(ScneneController.instance.obsCam);
            // Debug.Log(drawMesh);

            ScneneController.instance.obsCam.drawMesh = drawMesh;
            ScneneController.instance.obsCam.RedrawMesh(drawMesh);
        }

        INT_Angle?.onValueChanged.AddListener((x) => {
            float angel = 0;
            if(float.TryParse(x, out angel)){
                transform.localEulerAngles = new Vector3(0, angel, 0);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Delete)){
            if(tweener == null){
                tweener = transform.DORotate(new Vector3(0, 360, 0), rotateSpeed, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1).OnUpdate(() => {
                if(INT_Angle)
                    INT_Angle.text = transform.localEulerAngles.y.ToString();
            });
            } else {
                tweener.Kill();
                tweener = null;
            }
        }
    }
}
