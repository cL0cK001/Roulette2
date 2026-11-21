using UnityEngine;

// 制限時間を数えて、時間切れになったらログを出す
public class GameTimer : MonoBehaviour
{
    public float timeLimit = 30f; // 制限時間(秒)

    float remaining;
    bool finished = false;

    void Start()
    {
        remaining = timeLimit;
    }

    void Update()
    {
        if (finished) return;

        remaining -= Time.deltaTime;

        if (remaining <= 0f)
        {
            remaining = 0f;
            finished = true;
            Debug.Log("時間切れ!");
        }
    }
}
