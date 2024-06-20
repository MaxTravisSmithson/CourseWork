using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public void ClickedPlay()
    {
        Destroy(gameObject);
        GameManager.ResumeGame();
        Debug.Log("Play has been pressed!");
    }
}
