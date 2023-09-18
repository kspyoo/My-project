using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("생성 객체")]
    [SerializeField]
    private GameObject boxPrefab;
    [Header("생성 간격 (초)")]
    [SerializeField]
    private float spawnInterval = 2.0f; 
    [Header("생성할 박스 개수")]
    [SerializeField]
    private int numberOfBoxesToSpawn = 10;

    private int boxesSpawned = 0;

    private void Start()
    {
        // spawnInterval 간격으로 SpawnBox 함수를 반복 호출
        InvokeRepeating("SpawnBox", 0.0f, spawnInterval);
    }

    private void SpawnBox()
    {
        if (boxesSpawned < numberOfBoxesToSpawn)
        {
            // 랜덤한 x와 y 좌표 생성
            float randomX = Random.Range(-5f, 5f); // 원하는 범위로 수정
            float randomY = Random.Range(-5f, 5f); // 원하는 범위로 수정
            Vector2 randomPosition = new Vector2(randomX, randomY);

            // 박스 생성
            Instantiate(boxPrefab, randomPosition, Quaternion.identity);

            boxesSpawned++;

            // 모든 박스가 생성되면 InvokeRepeating을 중지합니다.
            if (boxesSpawned == numberOfBoxesToSpawn)
            {
                CancelInvoke("SpawnBox");
            }
        }
    }
}
