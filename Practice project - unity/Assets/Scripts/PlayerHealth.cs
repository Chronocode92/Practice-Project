using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    // This Function is NOT built in to Unity
    // It will only be called manually by our owm code
    // It must be marked ''public'' so our other scripts can access it
   public void Kill()
    {
        // This will load the Game Over screen upon killing the player
        SceneManager.LoadScene("GameOver");



    }


}
