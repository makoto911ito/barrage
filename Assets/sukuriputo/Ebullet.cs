using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebullet : MonoBehaviour
{
    Transform m_enemyPos;
    Vector3 center;
    // Start is called before the first frame update
    void Start()
    {
        m_enemyPos = GetComponent<Transform>();
        center = m_enemyPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center, new Vector3(0, 0, 0), 500 * Time.deltaTime);
        transform.Translate(0, -0.01f, 0);
    }

}
