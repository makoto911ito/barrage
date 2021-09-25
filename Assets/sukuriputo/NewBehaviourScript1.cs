using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    [SerializeField] GameObject m_Ebullert;
    //[SerializeField] GameObject m_Ebullert2;
    //[SerializeField] GameObject m_Ebullert3;
    //親オブジェクトのトランスフォームをアサイン
    [SerializeField] Transform enemi;
    private Transform tf;
    float m_time = 0;
    private bool m_hanntei = false;
    /// <summary>待機時間</summary>
    [SerializeField] float timeleft = 0.0f;
    /// <summary>弾幕のスピード</summary>
    [SerializeField] float m_bspeed = -500;


    // Start is called before the first frame update
    void Start()
    {
        Edbullet();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Edbullet()
    {
        for (int i = 0; i < 3; i++)
        {
            //銃口を生成しそれをobjに代入している　「Quaternion.Euler(0, 0, 15f + (-15f * i)」ここの部分は生み出す銃口の角度を決めている
            obj = Instantiate(m_Ebullert, transform.position, Quaternion.Euler(0, 0, 15f + (-15f * i)));
            obj.transform.SetParent(enemi); //objをHarpy(プレイヤー)の子供にする
            obj2.Add(obj); //obj2のリストにobjを加えていく
            Debug.Log(obj2.Count);
            Debug.Log(obj2[i].name);

        }

    }
}
