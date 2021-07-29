using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turner : MonoBehaviour
{
    public GameObject platform;
    public bool turning;

    public void turnMinus(){

        platform.transform.Rotate(0,-90,0);

    }
    public void turnPlus(){
        platform.transform.Rotate(0,90,0);
    }
    
    public void Turn(){
        if (!turning)
        {
            turnPlus();
        }else{
            turnMinus();
        }
    }


}
