using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameSystemManager : MonoBehaviour
{
    public GridManager gridManager;
    public Text scoreText;
    public TileButton tileButton;
    public Button xButton;
    public Toggle scanToggle, extractToggle;
    public int TotalPoints;
    public bool b_ScanToggle, b_ExtractToggle;

    private void Start()
    {
        
        scanToggle.enabled = true;
        extractToggle.enabled = false;
        gridManager.CloseGame();
        //Toggles
        scanToggle.GetComponent<Toggle>().onValueChanged.AddListener(ScanToggleSwitch);
        extractToggle.GetComponent<Toggle>().onValueChanged.AddListener(ExtractToggleSwitch);
        //Button
        xButton.gameObject.SetActive(false);
        xButton.GetComponent<Button>().onClick.AddListener(XButtonClicked);
        //Text
        scoreText.gameObject.SetActive(false);
        scoreText.text = "0";
    }

    public void XButtonClicked()
    {
        //UI ELEMENT TO CLOSE MINIGAME
        gridManager.CloseGame();

        //TURN THE BUTTON BACK TO SET ACTIVE
        tileButton.TurnOnButton();
        xButton.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        
    }

    private void Update()
    {
        scoreText.text = TotalPoints.ToString();
    }

    public void CreateGrid()
    {
        Debug.Log("Create Grid called in GameSystemManager");
        //TO ADD : Ui to back out of the menu, clear other buttons and such
        scanToggle.enabled = true;
        extractToggle.enabled = true;
        scoreText.gameObject.SetActive(true);
        xButton.gameObject.SetActive(true);
        //TO ADD :
        gridManager.StartGame();
    }

    public void ScanToggleSwitch(bool toggle)
    {
        extractToggle.GetComponent<Toggle>().SetIsOnWithoutNotify(!toggle);
        b_ScanToggle = toggle;
        b_ExtractToggle = !toggle;
    }

    public void ExtractToggleSwitch(bool toggle)
    {
        scanToggle.GetComponent<Toggle>().SetIsOnWithoutNotify(!toggle);
        b_ExtractToggle = toggle;
        b_ScanToggle = !toggle;
    }

    public int SetPointsToPlayer(int points)
    {
        TotalPoints += points;
        Debug.Log(TotalPoints);
        return TotalPoints;
    }
}
