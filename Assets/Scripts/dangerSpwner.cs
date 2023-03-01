using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerSpwner : MonoBehaviour
{

    public GameObject dangerPrefab;

    private void Start()
    {
        StartCoroutine(SpawnDanger());
    }

    IEnumerator SpawnDanger()
    {
        while(true)
        {
            float randomXPosition = Random.Range(-40f, 40f);
            Vector3 spawnPosition = new Vector3(randomXPosition, 75f, 0f);
            Instantiate(dangerPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
            
    }

}
