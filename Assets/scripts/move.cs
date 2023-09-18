using System.Collections;
using System.Collections.Generic; // System.Collections.Generic 추가
using UnityEngine;

public class move : MonoBehaviour
{
    float moveX, moveY;

    [Header("이동속도 조절")]
    [SerializeField] [Range(1f, 30f)] float moveSpeed = 20f; // [Range] 어트리뷰트 수정

    void Update()
    {
        // 이동 (상하좌우키 : WASD키 혹은 화살표)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // GetAxit -> GetAxis, Tiem -> Time 수정
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }
}
