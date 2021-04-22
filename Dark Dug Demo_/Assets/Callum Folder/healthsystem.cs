using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class healthsystem : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer(int damageToGive)
    {
        currentHealth -= damageToGive;
       if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }

    }




}
