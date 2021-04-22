using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class minerScript : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            MinerTextScript.minerAmount += 1;

            Destroy(gameObject);
        }
        if (MinerTextScript.minerAmount == 7)
        {
            SceneManager.LoadScene(2);
        }

       
    }
}
