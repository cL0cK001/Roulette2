using UnityEngine;

// スペースキーでルーレットを回し、だんだん減速して止まる
public class Roulette : MonoBehaviour
{
    public float startSpeed = 720f;   // 回転開始時の速さ(度/秒)
    public float deceleration = 0.98f; // 毎フレームの減速率

    float speed = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && speed == 0f)
        {
            speed = startSpeed;
        }

        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        speed *= deceleration;

        if (speed < 1f)
        {
            speed = 0f;
        }
    }
}
