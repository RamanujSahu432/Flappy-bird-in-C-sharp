using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public logicmanagerScript logic;
    public bool BirdIsAlive = true;
    public int groundlimit;
    public int skylimit;
    public int hello;
   public AudioSource wingSFX;
    public bool tapped;
    // Start is called before the first frame update
    void Start()
    {
        
        logic = GameObject.FindAnyObjectByType<logicmanagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        tapped = false;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                tapped = true;
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            tapped = true;
        }
       if (tapped && BirdIsAlive )
        {
            myRigidbody.velocity = Vector2.up * flapstrength;

          wingSFX = GetComponent<AudioSource>();
            wingSFX.Play();
        }  
        
        
        if (transform.position.y < groundlimit || transform.position.y > skylimit ) 
        {

           // Debug.Log("bird out of bounds");
           
            if(!logic.isGameovercheck)
            {
                Debug.Log("hjfawhfiusagfbiuwaeb");
                logic.gameover();
                BirdIsAlive = false;
            }
        
        }
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        BirdIsAlive = false;
    }

   

}
