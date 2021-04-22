using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhurt : MonoBehaviour
{
    private float deathtime = 0.25f;
    private float deathcounter = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D Other)
    {
        enemyscript enemy = Other.gameObject.GetComponent<enemyscript>();
        if(Other.tag == "Enemy")
        {
            
            enemy.attacked();
            enemy.Death();
            
        }
    }
}
