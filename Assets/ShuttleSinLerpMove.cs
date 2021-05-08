/**ShuttleSinLerpMove
 * LerpとSinの複合版
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleSinLerpMove : MonoBehaviour
{
    Vector3 pos; // 初期位置
    public Vector3 distinationPos; // 目的地
    float rate; // 0 ~ 1の間の数字をとる．
    public float moveTime; // 往復する時

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float sin_num = Mathf.Sin(2 * Mathf.PI * Time.time / moveTime); // sin_num: -1 ~ 1の範囲でずっと繰り返す．
        rate = ( sin_num + 1 ) / 2; // sin_numのスケールを0~1にするように，-1~1 -(+1)-> 0~2 -(/2)-> 0~1
        this.transform.position = Vector3.Lerp(pos, distinationPos, rate);
    }
}
