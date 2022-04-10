using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject movingPlatformPrefab;
    public GameObject platformPrefab;
    public GameObject brokenPlatformPrefab;

    int randomNumList;

    Vector2 spawnPlatform;

    void Start()
    {
        List<GameObject> list = new List<GameObject>();
        list.Add(movingPlatformPrefab);
        list.Add(platformPrefab);
        list.Add(brokenPlatformPrefab);

        for (int i = 0; i < 20; i++)
        {

            spawnPlatform = new Vector2(Random.Range(-1.55f, 1.55f), spawnPlatform.y + Random.Range(1f, 2f));

            randomNumList = Random.Range(0, 3);

            Instantiate(list[randomNumList], spawnPlatform, Quaternion.identity);
        }

    }
}
