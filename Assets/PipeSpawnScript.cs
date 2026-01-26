using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate;
    private float timer = 0;
    public float heightoffset = 10;
    private int start;
    public PipeMoveScript PipeMoveScript;
    public logicmanagerScript logicmanager;
    // Start is called before the first frame update
    void Start()
    {
        PipeMoveScript = FindAnyObjectByType<PipeMoveScript>();

        //  spawnPipe();
        logicmanager = FindAnyObjectByType<logicmanagerScript>();

    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime * logicmanager.increaseSpeed;
        }
        else
        {
            spawnPipe();   
            timer = 0;


        }
        
    }
    public void spawnPipe()
    {  
        
            float lowestpoint = transform.position.y - heightoffset;
            float highestpoint = transform.position.y + heightoffset;

            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        

    }


}
