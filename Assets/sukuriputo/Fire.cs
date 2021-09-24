using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    [SerializeField] GameObject m_Ebullert;
    /// <summary>PlayerFireを取得</summary>
    public GameObject PlayerFirePrefab;
    //親オブジェクトのトランスフォームをアサイン
    [SerializeField] Transform enemi;
    private Transform tf;
    float m_time = 0;


    // Start is called before the first frame update
    void Start()
    {
        obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.identity); //銃口を生成しそれをobjに代入している
        obj.transform.SetParent(enemi); //objをHarpy(プレイヤー)の子供にする
        obj2.Add(obj);　//obj2のリストにobjを加えていく
    }

    // Update is called once per frame
    void Update()
    {
        Edbullet();
    }

    void Edbullet()
    {
        if (m_time > 3)
        {
            Instantiate(m_Ebullert, new Vector3(enemi.position.x - 50, enemi.position.y, enemi.position.z),Quaternion.identity);
        }

    }
}

