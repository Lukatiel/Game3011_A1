using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TileScript : MonoBehaviour, IPointerClickHandler
{
    public int row, colum;
    public GameSystemManager gm;
    private GridManager gridManager;

    public int[] randomLootTable =
{
        60, //Most Frequent
        30, //Mid Tier
        10  //Rarest
    };
    int total, randomNumber;
    int PointsToPlayer;
    int NumberHold;
    bool lootGenerated = false;

    // Start is called before the first frame update
    void Start()
    {
        gridManager = transform.parent.GetComponent<GridManager>();
        
    }

    public void SetGridIndices(int rows, int colums)
    {
        rows = row;
        colums = colum;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Ive been clicked");
        //Based off the info, give player the points they deserve
        if (gm.b_ScanToggle)
        {
            GenerateLoot();
            if (NumberHold == 60)
            {
                PointsToPlayer = 10;
                gameObject.GetComponent<Image>().color = Color.yellow;
            }
            else if (NumberHold == 30)
            {
                PointsToPlayer = 30;
                gameObject.GetComponent<Image>().color = Color.blue;
            }
            else if (NumberHold == 10)
            {
                PointsToPlayer = 60;
                gameObject.GetComponent<Image>().color = Color.red;
            }
            Debug.Log(PointsToPlayer);
        }
        else if (gm.b_ExtractToggle && lootGenerated == true)
        {
            //TO SEND POINTS TO THE GAME SYSTEM MANAGER HERE
            gm.SetPointsToPlayer(PointsToPlayer);
            //THEN DELETE GAME OBJECT??
            Destroy(gameObject);
        }
        
        //Change Colour based off points they get
    }

    public void GenerateLoot()
    {
        //tally the total weight
        lootGenerated = true;
        foreach (var item in randomLootTable)
        {
            total += item;
        }

        //draw random number between 0 and total weight
        randomNumber = Random.Range(0, total);

        for (int i = 0; i < randomLootTable.Length; i++)
        {
            if (randomNumber <= randomLootTable[i])
            {
                NumberHold = randomLootTable[i];
                //Debug.Log(PointsToPlayer + "");
                return;
            }
            else if (randomNumber > randomLootTable[i])
            {
                randomNumber -= randomLootTable[i];
            }
        }
    }

};     
