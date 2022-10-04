using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject instance;
    GameObject objectToActivate;
    public GameObject[] objectsToSpawn;
    public GameObject[] activeChild;

    public void SpawnObjects()
    {
        for (int i = 0; i < objectsToSpawn.Length; i++)
        {
            instance = Instantiate(objectsToSpawn[i], gameObject.transform.position, gameObject.transform.rotation);
            instance.SetActive(false);
            instance.transform.parent = gameObject.transform;
        }
    }

    public void ActivateObject()
    {
        if (gameObject.transform.childCount !>0)
        {
            int objectIndex = Random.Range(0, objectsToSpawn.Length);
            objectToActivate = gameObject.transform.GetChild(objectIndex).gameObject;
            objectToActivate.SetActive(true);
        }
        
    }
}
