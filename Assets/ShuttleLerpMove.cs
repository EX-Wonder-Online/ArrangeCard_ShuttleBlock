/**ShuttleLerpMove
 * Lerpを用いてブロックを左右に移動させる．
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleLerpMove : MonoBehaviour
{
    Vector3 pos;
    public Vector3 distinationPos;
    public float moveTime; // 往復する時
    float rate;
    bool isUp;

    void Start()
    {
        pos = this.transform.position;
        isUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUp)
        {
            rate += Time.deltaTime / moveTime; // rateをだんだん増やす
            if(rate > 1)// もしrateが1より大きい時，isUpをfalseにする -> 下に向かう
            {
                isUp = false;
            }
        }
        else
        {
            rate -= Time.deltaTime / moveTime; // rateをだんだん減らす
            if(rate < 0) // もしrateが0より小さい時，isUpをtrueにする -> 上に向かう
            {
                isUp = true;
            }
        }
        
        this.transform.position = Vector3.Lerp(pos, distinationPos, rate);

    }
}
