using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathZone : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource deathSoundEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
        deathSoundEffect.Play();
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
