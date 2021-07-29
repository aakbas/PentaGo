using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallObject", menuName = "PentaGo/Blue", order = 0)]
public class BlueBall : BallObject
{
    private void Awake() {
       
       type=ballType.Blue;
   }
}
