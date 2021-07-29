using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{   
     GameManager gameManager;

    
    private void Start() {
        gameManager=FindObjectOfType<GameManager>();
    }




    void Update()
    {
                 if (Input.GetMouseButtonDown(0)) {
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                    if (hit.collider.gameObject.GetComponent<BoxCollider>() )
                    {
                         gameManager.spawnBall(hit.point,hit.collider.gameObject);

                        hit.collider.gameObject.GetComponent<BoxCollider>().enabled=false;
                    }
                    else if (hit.collider.gameObject.GetComponent<Turner>())
                    {
                        hit.collider.gameObject.GetComponent<Turner>().Turn();
                    }
                    else if(hit.collider.gameObject.GetComponent<Reset>()){
                        hit.collider.gameObject.GetComponent<Reset>().RestartScene();
                    }
                   
                    
                }
        
    }
    }


    


    


}
