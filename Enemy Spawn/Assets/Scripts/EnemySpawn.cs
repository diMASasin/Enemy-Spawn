﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPoints = new GameObject[5];
    [SerializeField] private GameObject _enemy;

    public IEnumerator SpawnEnemy()
    {
        var waitForTwoSeconds = new WaitForSeconds(2f);

        while(true)
        {
            GameObject newEnemy = Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform);
            yield return waitForTwoSeconds;
            Destroy(newEnemy);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
}
