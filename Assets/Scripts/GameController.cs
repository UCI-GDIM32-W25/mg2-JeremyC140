using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private float minTimeItv = 2.0f;
    [SerializeField] private float maxTimeItv = 5.0f;
    private float timePassed;
    private float nextCoinSpawnTime;

    private void Start()
    {
        timeIntervalReset(minTimeItv, maxTimeItv);
    }
    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > nextCoinSpawnTime) { 
            SpawnCoin();
            timeIntervalReset(minTimeItv, maxTimeItv);
        }
    }

    private void SpawnCoin() {
        Instantiate(_coin);
    }

    private void timeIntervalReset(float min, float max) {
        timePassed = 0.0f;
        nextCoinSpawnTime = Random.Range(min, max);
    }
    public void collectCoin(GameObject coin) { 
        coin.SetActive(false);
    }
}
