using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private Animator anim;
    private Transform target;
    public Transform homePos;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float maxRange;
    [SerializeField]
    private float minRange;

    void Start() 
    {
        anim = GetComponent<Animator>();
        target = FindObjectOfType<PlayerMovement>().transform;
    }

        void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
        {
            FollowPlayer();
            GetComponent<AudioSource>().UnPause();

        } else if (Vector3.Distance(target.position,transform.position) >= maxRange) {
            GoHome();
            
        }


    }
    
    public void FollowPlayer()
    {
        anim.SetBool("withinRange", true);
        anim.SetFloat("moveX", (target.position.x - transform.position.x));
        anim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
    }
    public void GoHome()
    {

        anim.SetFloat("moveX", (homePos.position.x - transform.position.x));
        anim.SetFloat("moveY", (homePos.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, homePos.position) == 0)
        {
            anim.SetBool("withinRange", false);
        }
    }

    public void attacked()
    {
        anim.SetTrigger("Death");
    }


public void Death()
    {
        Destroy(gameObject,0.45f);
    }

}
