using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private float minTimeItv = 2.0f;
    [SerializeField] private float maxTimeItv = 5.0f;
    [SerializeField] private TMP_Text _pointText;
    private float timePassed;
    private float nextCoinSpawnTime;
    private int num_coin_collected = 0;

    private void Start()
    {
        timeIntervalReset(minTimeItv, maxTimeItv);
        _pointText.text = "Points: " + num_coin_collected.ToString();
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
        Instantiate(_coin, new Vector3(15, 15, 0), Quaternion.identity);
    }

    private void timeIntervalReset(float min, float max) {
        timePassed = 0.0f;
        nextCoinSpawnTime = Random.Range(min, max);
    }
    public void collectCoin(GameObject coin) { 
        coin.SetActive(false);
        num_coin_collected++;
        _pointText.text = "Points: " + num_coin_collected.ToString();
    }
}
