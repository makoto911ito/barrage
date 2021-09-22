using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hanntei : MonoBehaviour
{
    private float m_time = 0f;

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

        m_time += Time.deltaTime;
        if (m_time > 30f)
        {
            Debug.Log("kieta");
            OnBecameInvisible();
        }

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
