using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipemiddleScript : MonoBehaviour
{
    public logicmanagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicmanagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("SCore+1");
            logic.addscore(1);
        }
    }
}
