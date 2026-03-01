using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public BrickManager brickManager;
    public Player player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            RestartLevel();
        }
    }

    void RestartLevel() 
    {
        print("Restart Level");

        levelManager.RestartLevelManager();        
        brickManager.RestartBrickManager();
        player.RestartPlayer();
    }
}
