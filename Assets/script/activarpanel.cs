using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarpanel : MonoBehaviour
{
    public GameObject Panel;
    public void ActivatePanel()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void DeactivatePanel()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }
    }
