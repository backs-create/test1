using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reda : MonoBehaviour
{
    [SerializeField] public GameObject target; // 目標のTransform（もう一方のベクトル）

    public float rotationSpeed = 5000f; // 回転速度

    public float moveSpeed = 3.0f;

    public float time = 0f;


    private void Update()
    {
        // 現在の位置から目標へのベクトルを計算
        Vector2 direction = target.transform.position - transform.position;

        // ベクトルを正規化して、回転角度を求める
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 回転をスムーズに行う
        float step = rotationSpeed;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, targetAngle), step);

        // 向いている方向に移動する
        Vector3 forward = transform.right; // 2Dでは "右方向" が forward になる
        transform.position += forward * moveSpeed * Time.deltaTime;

        time += Time.deltaTime;
        if(time>5.0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "heat")
        {
            //Debug.Log("hit");
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().redDecreaseHps();

            Destroy(gameObject);
        }
    }
}
