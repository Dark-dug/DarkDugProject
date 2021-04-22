using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerhurt : MonoBehaviour
{

    private healthsystem healbox;
    private float wait2Hurt = 2f;
    private bool isConnecting;

    [SerializeField]
    private int givendamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        healbox = FindObjectOfType<healthsystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isConnecting)
        {
            wait2Hurt -= Time.deltaTime;
            if(wait2Hurt <=0)
            {
                healbox.HurtPlayer(givendamage);
                wait2Hurt = 2f;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            //other.gameObject.SetActive(false);
            //SceneManager.LoadScene("GameOver");
            other.gameObject.GetComponent<healthsystem>().HurtPlayer(givendamage);
        }


    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            isConnecting = true;
        }


       
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {

            isConnecting = false;
            wait2Hurt = 2f;
        }
    }
}
