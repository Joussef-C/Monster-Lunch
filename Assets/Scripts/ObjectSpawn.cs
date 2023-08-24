using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{

    public GameObject[] Food;
    public Transform SpawnPoint;
    public float SpawnCooldown;

    private float SpawnBetweenTime;
    // Update is called once per frame

    void FixedUpdate()
    {
        if (SpawnBetweenTime <= 0)
        {
            int rand = Random.Range(0, Food.Length);
            Instantiate(Food[rand], SpawnPoint.position,transform.rotation);
            SpawnBetweenTime = SpawnCooldown;
        }
        else
        {

            SpawnBetweenTime -= Time.deltaTime;
        }
    }
}
