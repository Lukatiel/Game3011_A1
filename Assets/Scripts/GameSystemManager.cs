using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManager : MonoBehaviour
{
    public GridManager gridManager;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateGrid()
    {
        Debug.Log("Create Grid called in GameSystemManager");
        //TO ADD : Ui to back out of the menu, clear other buttons and such
        gridManager.CreateGrid();
    }
}
