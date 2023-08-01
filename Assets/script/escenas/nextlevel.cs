﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{

    public int nextScene;

    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextScene);

            if (nextScene > PlayerPrefs.GetInt("nivel"))
            {
                PlayerPrefs.SetInt("nivel", nextScene);

                Debug.Log("paso por aca");
            }
        }
    }


}
