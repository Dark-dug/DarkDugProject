using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerhurt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisonEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
}
