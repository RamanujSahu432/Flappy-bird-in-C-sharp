using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 10;
    public float deadzone = -100;
   public logicmanagerScript logicmanager;
    public birdscript birdScript;
    // Start is called before the first frame update
    void Start()
    {
        logicmanager = FindAnyObjectByType<logicmanagerScript>();
        birdScript=FindAnyObjectByType<birdscript>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("increaseSpeed" + logicmanager.increaseSpeed);
       transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime * logicmanager.increaseSpeed;
       
       if(transform.position.x < deadzone || !birdScript.BirdIsAlive) 
        {
            Destroy(gameObject);      
        
        } 

    }
}
