using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Door : MonoBehaviour
{
    //public variables in editable in unity
    public string targetScene = "";

    // CONDITION 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // CONDITION 
        if (collision.CompareTag("Player"))
        {
            ChangeScene();
        }
    }
    
    // ACTION
    public void ChangeScene()
    {
        SceneManager.LoadScene("GameClear");
    }
}


   

