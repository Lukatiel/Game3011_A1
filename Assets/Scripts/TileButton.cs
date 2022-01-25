using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileButton : MonoBehaviour
{
    public GameSystemManager gameSystemManager;
    
    public void TileMinigame()
    {
        Debug.Log("Tile Minigame Button is pressed (From Button Side)");
        gameSystemManager.CreateGrid();
        gameObject.SetActive(false);
    }

    public void TurnOnButton()
    {
        gameObject.SetActive(true);
    }
    public void TurnOffButton()
    {
        gameObject.SetActive(false);
    }

    
}
