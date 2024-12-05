using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{
    private static AudioManagerScript instance;
  
    private void Awake()
    {
        
          

            if (instance == null )
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

        if (SceneManager.GetActiveScene().name == "Episode1")
        { GetComponent<AudioSource>().Pause(); }    
        
    }
}