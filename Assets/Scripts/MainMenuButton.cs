using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject gameInfoScreen;
    public GameObject score;
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MainMenu);
        score.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MainMenu()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        titleScreen.gameObject.SetActive(true);
        gameInfoScreen.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
    }
}
