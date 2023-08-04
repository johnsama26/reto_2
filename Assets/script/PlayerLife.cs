using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public GameObject[] hearts;
    private int life = 3;
    public AudioSource DeathSound;
    private Rigidbody2D rb;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);

        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            //anim.SetTrigger("death");
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            //anim.SetTrigger("death");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("vacio"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("trampas"))
        {
            life--;


            if (life <= 0)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
            DeathSound.Play();
            //Invoke("RestartLevel", 2f);
        }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
    //Start is called before the first frame update
   

