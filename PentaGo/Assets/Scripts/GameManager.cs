using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public int turn =0;
     public BallObject blueBall;
     public BallObject redBall;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void spawnBall(Vector3 location,GameObject parent){
        if (turn%2==0)
        {
            Debug.Log("Spawn Blue");
            Spawn(blueBall,location,parent);
            turn++;
        }
        else{
            Debug.Log("Spawn Red");
            Spawn(redBall,location,parent);
            turn++;
        }

    }

    private void Spawn(BallObject ball,Vector3 location,GameObject parent){

        Vector3 ballOffset= new Vector3 (0f,-1f,0f);

        Vector3 spawnLocation=location-ballOffset;

      var spawnedBall=  Instantiate(ball.prefab,spawnLocation,Quaternion.identity);
      spawnedBall.transform.parent=parent.transform;


    }





}
