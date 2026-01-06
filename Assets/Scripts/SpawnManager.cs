using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(40, 0, 0);
    private float startDelay = 2;   
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    public GameObject titleScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }  
    }


    public void StartGame()
    {
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        titleScreen.gameObject.SetActive(false);    
    }
}
