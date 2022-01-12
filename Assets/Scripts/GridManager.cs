using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameSystemManager gameSystemManager;
    public Sprite sprite;
    

    public int[,] grid;
    int colum, row;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGrid()
    {
        Debug.Log("Create Grid called in GridManager");

        colum = 5;
        row = 5;

        grid = new int[colum, row];
        for (int x = 0; x < colum; x++)
        {
            for (int y = 0; y < row; y++)
            {
                grid[x, y] = Random.Range(0, 10);
                SpawnTile(x, y, grid[x, y]);
            }
        }
    }

    private void SpawnTile(int x, int y, int value)
    {
        GameObject gameObject = new GameObject("X: " + x + "Y: " + y);
        gameObject.transform.position = new Vector3(x, y);
        var s = gameObject.AddComponent<SpriteRenderer>();
        s.sprite = sprite;
        s.color = new Color(0.5f,0.5f,0.5f);
    }
}
