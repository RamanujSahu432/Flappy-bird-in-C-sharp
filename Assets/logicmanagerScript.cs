using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Unity.VisualScripting;



public class logicmanagerScript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    public GameObject bird;
    public GameObject pipespawner;
    public AudioSource gameSFX;
    public AudioClip[] gameoverclip;
    public AudioClip[] scoreclip;
    private AudioClip lastaudioclip1;
    private AudioClip lastaudioclip2;
    public bool isGameovercheck;
    private Rigidbody2D birdrb;
    public GameObject hint;
    public GameObject clouds;

    public float increaseSpeed;
    public float increaseSpeedRate = 0.1f;

    public GameObject reviveObject;

    public birdscript birdScript;

    public bool isRevived;
    public void Start()
    {
        pipespawner.SetActive(false);
        bird.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
        clouds.SetActive(false);
        Debug.Log("revive1");
        Debug.Log("revive" + reviveObject.name);
        reviveObject.SetActive(false);
        Debug.Log("revive2");
        isGameovercheck = false;
        Time.timeScale = 1f;
        birdScript=FindAnyObjectByType<birdscript>();
        birdScript.BirdIsAlive = true;
        isRevived = false;
    }
    public void Update()
    {
        increaseSpeed += Time.deltaTime*increaseSpeedRate;
        if(birdScript.BirdIsAlive)
        {
           // isGameovercheck = false;
        }
    }
    public void addscore(int scoretoadd)
    {
            playerscore = playerscore + scoretoadd;
            scoretext.text = playerscore.ToString();

           // while (gameSFX.clip == lastaudioclip1)
            //{ 
                gameSFX.clip = scoreclip[Random.Range(0,scoreclip.Length)];
                //gameSFX.clip = scoreclip[0];
                 gameSFX.Play();
            //}
            //lastaudioclip1 = gameSFX.clip;
          
       // }
}
    public void Restartgame()
    {
        reviveObject.SetActive(false);
        SceneManager.LoadScene("level1");
        Time.timeScale = 1.0f; 
    }

    public void gameover()
    {  
       isGameovercheck=true;
         gameoverscreen.SetActive(true);
        Debug.Log("gameoverscreenEnable");
        lastaudioclip2 = lastaudioclip1;
        
       // if (gameovercheck == 1)
       // {
           // gameSFX.clip = gameoverclip[0];
          
           
          //  while (gameSFX.clip == lastaudioclip2)
         //   {
               // gameSFX.clip = gameoverclip[Random.Range(0, gameoverclip.Length)];
                //gameSFX.clip = scoreclip[0];
                 gameSFX.Play();
         //   }
            lastaudioclip2 = gameSFX.clip;
            
       // }
       // gameovercheck = gameovercheck + 1;
        
        reviveObject.SetActive(true);

        pipespawner.SetActive(false);

    }
   /* public void startgame()
    {
         birdrb = bird.GetComponent<Rigidbody2D>();
          birdrb.gravityScale = 0;
          bird.SetActive(true);
          if (Input.GetKeyDown(KeyCode.Space))
          {
              spacebartitle.SetActive(false);
             birdrb.gravityScale=10;     
              pipespawner.SetActive(true);
          }
          
        bird.SetActive(false);
        spacebartitle.SetActive(false);
        pipespawner.SetActive(true);

    
       */
    public void mainmenu()
    {

        SceneManager.LoadScene("title");

    }
    public void Hint()
    {   clouds.SetActive(true);
        pipespawner.SetActive(true);
        hint.SetActive(false);
        bird.GetComponent<Rigidbody2D>().gravityScale = 10.0f;
    }
    public void disableGameOverScreen()
    {
        gameoverscreen.SetActive(false);
        Debug.Log("gameoverscreenDisable");
        reviveObject.SetActive(false);
        Debug.Log("gameoverscreenDDisable");
    }
    public void RevivePlayer()
    {
        //gameovercheck = 0;
        birdScript.BirdIsAlive = true;
        Rigidbody2D rb = bird.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        rb.gravityScale = 10f;
        rb.position = Vector2.zero;
        pipespawner.SetActive(true);
        StartCoroutine(ReviveGracePeriod());
    }
    IEnumerator ReviveGracePeriod()
    {
        isGameovercheck = true;  
        yield return new WaitForSeconds(0.1f);  
        isGameovercheck = false; 
    }
    // Start is called before the first frame update
    /*  void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }
    */
}
