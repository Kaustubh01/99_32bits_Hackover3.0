using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    private void Awake()
    {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        foreach (Spawner item in spawners)
        {
            item.SpawnObjects();
            item.ActivateObject();
        }
    }
    
}
