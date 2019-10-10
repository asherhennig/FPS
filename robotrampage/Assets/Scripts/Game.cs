using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static Game singleton;

    [SerializeField]
    RobotSpawn[] spawns;

    public int enemiesLeft;
    //1 Start is called before the first frame update
    void Start()
    {
        singleton = this;
        SpawnRobots();
    }

    private void SpawnRobots()
    {
        foreach (RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
