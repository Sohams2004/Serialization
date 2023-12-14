using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject usernamePanel;
    [SerializeField] GameObject passwordPanel;

    private void Start()
    {
        usernamePanel = GameObject.FindGameObjectWithTag("Username");
        passwordPanel = GameObject.FindGameObjectWithTag("Password");

        usernamePanel.SetActive(true);
        passwordPanel.SetActive(false);
    }

    public void Next()
    {
        usernamePanel.SetActive(false);
        passwordPanel.SetActive(true);
    }
}
