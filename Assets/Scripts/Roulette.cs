using UnityEngine;

// スペースキーでルーレットを回し、だんだん減速して止まる
public class Roulette : MonoBehaviour
{
    public float minStartSpeed = 600f;  // 回転開始時の速さの最小値(度/秒)
    public float maxStartSpeed = 1200f; // 回転開始時の速さの最大値(度/秒)
    public float deceleration = 0.98f;  // 毎フレームの減速率

    float speed = 0f;
    bool isSpinning = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            // 毎回ちがう結果になるよう、開始速度をランダムにする
            speed = Random.Range(minStartSpeed, maxStartSpeed);
            isSpinning = true;
        }

        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        speed *= deceleration;

        if (isSpinning && speed < 1f)
        {
            speed = 0f;
            isSpinning = false;
            Debug.Log("止まった角度: " + transform.eulerAngles.z.ToString("F0") + "度");
        }
    }
}
