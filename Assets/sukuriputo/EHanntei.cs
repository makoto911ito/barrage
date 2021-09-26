using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHanntei : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //最初の何フレームかは画面に映ってないから待つ必要がある。↓証拠
        //if (GetComponent<Renderer>().isVisible)
        //{
        //    Debug.Log("うつる");
        //}
        //else
        //{
        //    Debug.Log("うつらない");
        //}

        //m_time += Time.deltaTime;
        //if (m_time > 30f)
        //{
        //    Debug.Log("kieta");
        //    OnBecameInvisible();
        //}

        //Destroy(this.gameObject, 15f);

    }

    /// <summary>カメラの外に出たときの処理</summary>
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);　//このスクリプトを持つオブジェクトを消す
    }

    private void OnTriggerEnter2D(Collider2D collision)　//プレイヤーキャラに弾幕が当たった時の処理
    {
        if (collision.gameObject.tag == "Plaeyr")　//弾幕がプレイヤーのタグをもつオブジェクトに当たった時、弾幕を消す
        {
            Destroy(this.gameObject);
        }
    }
}
