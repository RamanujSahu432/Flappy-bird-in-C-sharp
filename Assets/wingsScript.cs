using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class wingsScript : MonoBehaviour
{
    public birdscript birdscript;
   // public GameObject birdwing;
    public float delay ;
    public float timer1 = 0;
    public GameObject wingup1;
    public GameObject wingdown1;
    public GameObject wingup2;
    public GameObject wingdown2;
    // Start is called before the first frame update
    void Start()
    {
        wingup1.SetActive(true);
        wingup2.SetActive(true);
        wingdown1.SetActive(false);
        wingdown2.SetActive(false);

        //birdwing = GameObject.Find("wingup");

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) )
        {
            Debug.Log("birdwingdownexecuted");
            birdwingdown();
        }
          void birdwingdown()
        {   wingup1.SetActive(false);
            wingup2.SetActive(false);
            wingdown1.SetActive (true);
            wingdown2.SetActive(true);


            if (timer1 < delay )
            {
                timer1 = timer1 + 1;
                Debug.Log("timer1");
            }
            else
            {
                Debug.Log("birdwingupexecuted");
                birdwingup();       
                timer1 = 0;
            }



        }
          void birdwingup()
        {
            wingup1.SetActive (true);
            wingup2.SetActive(true);
            wingdown1.SetActive (false);
            wingdown2.SetActive(false);
        }
        
    }
}
