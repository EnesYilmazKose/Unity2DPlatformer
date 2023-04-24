using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingLevel : MonoBehaviour
{
    private AudioSource finishingLevelSoundEffect;

    private bool levelCompleted = false;
    void Start()
    {
        finishingLevelSoundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "PlayerOne" && !levelCompleted)
        {
            finishingLevelSoundEffect.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
        
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
