using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour
{
    public GameObject[] puzzle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int  randomIndex=Random.Range(0,puzzle.Length);
            Vector3 randomSpawnPosition= new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(puzzle[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}
