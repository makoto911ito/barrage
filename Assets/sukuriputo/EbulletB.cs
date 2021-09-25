using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbulletB : MonoBehaviour
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
        transform.RotateAround(center,new Vector3(0,0,5), 100 * Time.deltaTime);
        transform.Translate(0,-0.002f, 0);
    }

}
