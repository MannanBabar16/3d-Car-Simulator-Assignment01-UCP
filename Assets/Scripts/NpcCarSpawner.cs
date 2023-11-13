using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCarSpawner : MonoBehaviour
{

    public GameObject[] CarReference;

    private GameObject spawnedCar;

    public Transform endPosition;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    IEnumerator SpawnCar()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);

            randomIndex = Random.Range(0, CarReference.Length);
            spawnedCar = Instantiate(CarReference[randomIndex]);

            spawnedCar.transform.position = endPosition.position;
            spawnedCar.GetComponent<NpcCarMovement>().speed = Random.Range(20, 40);
        }

    }
}
