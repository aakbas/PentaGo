using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ballType{

    Red,
    Blue
}

[CreateAssetMenu(fileName = "BallObject", menuName = "PentaGo/BallObject", order = 0)]
public class BallObject : ScriptableObject {
    

public GameObject prefab;
public ballType type;



}

    





