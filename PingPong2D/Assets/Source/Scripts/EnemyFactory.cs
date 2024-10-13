using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    private Coroutine _spawnTickX;
    private Coroutine _spawnTickY;
    [SerializeField] private FailTrigger _failTrigger;
    [SerializeField] private float _spawnTime;
    private Enemy _enemyPrefab;
    
    private void Start()
    {
        _enemyPrefab = Resources.Load<Enemy>("Enemy");
        _spawnTickX = StartCoroutine(SpawnTickLeft());
        _spawnTickY = StartCoroutine(SpawnTickRight());
    }
    
    private IEnumerator SpawnTickLeft()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, new Vector2(-9.71f, Random.Range(-3f, 4f)), Quaternion.identity)
                .Setup(true, _failTrigger);
            yield return new WaitForSeconds(_spawnTime);
        }
    }
    
    private IEnumerator SpawnTickRight()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, new Vector2(9.71f, Random.Range(-3f, 4f)), Quaternion.identity)
                .Setup(false, _failTrigger);
            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private void OnDisable()
    {
        StopCoroutine(_spawnTickX);
        StopCoroutine(_spawnTickY);
    }
}
