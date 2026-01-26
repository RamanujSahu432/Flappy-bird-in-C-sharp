using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmusicscript : MonoBehaviour
{    
    public AudioSource backgroundmusicSource;
    public AudioClip[] backgroundmusic;
    private AudioClip lastaudioclip;
    // Start is called before the first frame update
    void Start()
    {
        while (backgroundmusicSource.clip == lastaudioclip)
        {
            backgroundmusicSource.clip = backgroundmusic[Random.Range(0, backgroundmusic.Length)];
            //gameSFX.clip = scoreclip[0];
            backgroundmusicSource.Play();
        }
        lastaudioclip = backgroundmusicSource.clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
