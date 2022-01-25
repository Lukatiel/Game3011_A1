using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] tiles;
    public GameObject[,] grid;
    public GameSystemManager gm;
    public bool gameActive;

    public int[] randomLootTable =
    {
        60, //Most Frequent
        30, //Mid Tier
        10  //Rarest
    };
    public bool AwardPlayer;
    int total, randomNumber;
    public int PointsToPlayer;

    public void CloseGame()
    {
        //Called in gsm 
        gameActive = false;
        gameObject.SetActive(false);
    }

    public void StartGame()
    {
        gameObject.SetActive(true);
        grid = new GameObject[5, 5];
        gameActive = true;
        //PointsToPlayer;

    }

}


/*TODO
 * For adding a weighted system for loot:
 * tally total weight
 * draw a number between 0 and the total weight
 * 
 * if random number is less than the first number given them reward
 * if not subtract the random number from said number in the loot table
 * go through list until reward is given
 * 
 * FOR GAMESYSTEMMANAGER
 * CREATE TOGGLE UI *DONE*
 * RESSOURCE COUNTER TBD
 * TEXT FIELD GIVING USER INFO ON WHAT THEY CLICKED
 * 
 * 
 * 
 * 
 */