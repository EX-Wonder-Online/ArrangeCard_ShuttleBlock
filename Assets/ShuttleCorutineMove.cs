using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleCorutineMove : MonoBehaviour
{
    Vector3 pos;
    public Vector3 distinationPos;
    public float moveTime; // 往復する時
    float rate;
    bool isUp;

    void Start()
    {
        pos = this.transform.position;
        StartCoroutine(Move());
    }
    void Upate()
    {

    }
    // Update is called once per frame
    IEnumerator Move()
    {
        while (true)
        {
            while (true)
            {
                rate += Time.deltaTime / moveTime; // rateをだんだん増やす
                if (rate > 1)// ループを抜ける．
                {
                    break;
                }
                this.transform.position = Vector3.Lerp(pos, distinationPos, rate);
                yield return null;
            }
            while (true)
            {
                rate -= Time.deltaTime / moveTime; // rateをだんだん減らす
                if (rate < 0) // もしrateが0より小さい時，ループを抜ける．
                {
                    break;
                }
                this.transform.position = Vector3.Lerp(pos, distinationPos, rate);
                yield return null;
            }
        }

    }

}
