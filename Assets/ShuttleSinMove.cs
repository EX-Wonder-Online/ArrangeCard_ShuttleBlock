/**ShuttleSinMove
 * sinカーブを用いてブロックを左右に移動させる．
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleSinMove : MonoBehaviour
{
    Vector3 pos;
    public float radius; // 半径
    public float moveTime; // 往復する時

    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = radius * Mathf.Sin(2*Mathf.PI*Time.time / moveTime);
        this.transform.position = pos;
    }
}
