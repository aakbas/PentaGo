using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallObject", menuName = "PentaGo/Red", order = 0)]
public class RedBall : BallObject
{
   private void Awake() {
       type=ballType.Red;
   }
}
