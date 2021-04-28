using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 115;
    public int numberOfTiles = 6;
    private List<GameObject> activeTiles = new List<GameObject>();
    public Transform playerTransform;
    public GameObject suelo;

    void Start()
    {

        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile(Random.Range(0, tilePrefabs.Length));
            }
        }
    }

    void Update()
    {
        if (playerTransform.position.z - 35 > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));

        }
    }
    public void SpawnTile(int titleIndex)
    {
        Instantiate(tilePrefabs[titleIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }

    void generacionDeMundo()
    {
        if (Mathf.Round(transform.position.z) == (-78))
        {
            Instantiate(suelo, new Vector3(0, 0, 468), Quaternion.identity);
            Destroy(suelo);
        }
    }
}