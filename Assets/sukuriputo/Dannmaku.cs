using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dannmaku : MonoBehaviour
{
    /// <summary>PlayerFireを取得</summary>
    public GameObject PlayerFirePrefab;
    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    //親オブジェクトのトランスフォームをアサイン
    public Transform Harpy;
    /// <summary>発射方向数 </summary>
    //public int wayNumber;
    /// <summary>プレイヤーのレベル</summary>
    public int m_PlayeLv = 1;

    private GameObject target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("enemi");
    }

    // Update is called once per frame
    void Update()
    {
        Dbullet();

    }

    void Dbullet()　//プレイヤーのレベルに応じて銃口の数変更
    {
        if (m_PlayeLv == 1)　//レベル１の時、正面のみに発射する
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.identity);　//銃口を生成しそれをobjに代入している
                obj.transform.SetParent(Harpy); //objをHarpy(プレイヤー)の子供にする
                obj2.Add(obj);　//obj2のリストにobjを加えていく
            }

        }
        else if (m_PlayeLv == 2)　//レベル２の時、v字方向に発射する
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                for (int i = 0; i < 2; i++)
                {
                    //銃口を生成しそれをobjに代入している　「Quaternion.Euler(0, 0, 7.5f + (-15f * i)」ここの部分は生み出す銃口の角度を決めている
                    obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.Euler(0, 0, 7.5f + (-15f * i)));
                    obj.transform.SetParent(Harpy);　//objをHarpy(プレイヤー)の子供にする
                    obj2.Add(obj);　//obj2のリストにobjを加えていく
                    Debug.Log(obj2.Count);
                    Debug.Log(obj2[i].name);
                }
            }
        }
        else if (m_PlayeLv == 3)　//レベル３の時、三方向（正面とV字方向）に発射する
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                for (int i = 0; i < 3; i++)
                {
                    //銃口を生成しそれをobjに代入している　「Quaternion.Euler(0, 0, 15f + (-15f * i)」ここの部分は生み出す銃口の角度を決めている
                    obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.Euler(0, 0, 15f + (-15f * i)));
                    obj.transform.SetParent(Harpy);　//objをHarpy(プレイヤー)の子供にする
                    obj2.Add(obj);　//obj2のリストにobjを加えていく
                    Debug.Log(obj2.Count);
                    Debug.Log(obj2[i].name);
                }
            }
        }
    }

    /// <summary>発射ボタンを離したとき銃口の数分その銃口を消す</summary>
    void Delete()
    {
        if (Input.GetButtonUp("Jump"))
        {
            for (int i = 0; i < obj2.Count; i++)　//obj2の要素分ループする
            {
                Debug.Log("mawaru");
                Destroy(obj2[i]);　//obj2の要素i番目を消していく
                Debug.Log(i);
            }
            obj2.Clear();　//リストobj2の中身を殻にする
            Debug.Log(obj2.Count);
        }
    }
}
