using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebullet : MonoBehaviour
{
    [SerializeField] GameObject m_player;
    Transform m_PlayerTf;
    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    /// <summary>PlayerFireを取得</summary>
    public GameObject PlayerFirePrefab;
    //親オブジェクトのトランスフォームをアサイン
    public Transform enmi;
    float m_time = 0;
    [SerializeField] GameObject m_ebullet;
    private GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Harpy");

        for (int i = 0; i < 3; i++)
        {
            //銃口を生成しそれをobjに代入している　「Quaternion.Euler(0, 0, 7.5f + (-15f * i)」ここの部分は生み出す銃口の角度を決めている
            obj = Instantiate(PlayerFirePrefab,transform.position, Quaternion.Euler(0, 0, 0));
            obj.transform.SetParent(enmi);
            obj2.Add(obj); //obj2のリストにobjを加えていく
        }
    }

    // Update is called once per frame
    void Update()
    {
        //m_PlayerTf = m_player.transform;
        //obj2[0].transform.LookAt(m_PlayerTf);
        //obj2[1].transform.LookAt(m_PlayerTf);
        //obj2[2].transform.LookAt(m_PlayerTf);
        Edbullet();
    }

    void Edbullet()
    {
        if (m_time > 3)
        {
            Instantiate(m_ebullet);
        }
    }
}
