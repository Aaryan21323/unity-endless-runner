using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Button startButton;
    private SpawnManager spawnManager;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton= GetComponent<Button>();
        startButton.onClick.AddListener(GamestartButton);
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GamestartButton()
    {
        spawnManager.StartGame();
        Debug.Log("Game Started");
    }

}
