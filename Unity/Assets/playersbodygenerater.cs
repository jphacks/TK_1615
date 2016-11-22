using UnityEngine;
using System.Collections;

public class playersbodygenerater : Photon.MonoBehaviour {
	/*
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    */
    public bool color = false;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (color == false)
        {

            Vector3 playerpos = this.transform.position;
            Quaternion playerrot = this.transform.rotation;
            int Pnum = playerlocate.Pnum;

            if (Pnum != 0)
            {
                if (Pnum == 1)
                {
                    // プレハブからインスタンスを生成
					GameObject obj = PhotonNetwork.Instantiate("BrownBody", playerpos, playerrot, 0);
                    // 作成したオブジェクトを子として登録
                    obj.transform.parent = transform;
                    color = true;
                    Pnum = 0;
                }
                else if (Pnum == 2)
                {
                    // プレハブからインスタンスを生成
					GameObject obj = PhotonNetwork.Instantiate("PinkBody", playerpos, playerrot, 0);
                    // 作成したオブジェクトを子として登録
                    obj.transform.parent = transform;
                    color = true;
                    Pnum = 0;
                }
                else if (Pnum == 3)
                {
                    // プレハブからインスタンスを生成
					GameObject obj = PhotonNetwork.Instantiate("BlueBody", playerpos, playerrot, 0);
                    // 作成したオブジェクトを子として登録
                    obj.transform.parent = transform;
                    color = true;
                    Pnum = 0;
                }
                else if (Pnum == 4)
                {
                    // プレハブからインスタンスを生成
					GameObject obj = PhotonNetwork.Instantiate("YellowBody", playerpos, playerrot, 0);
                    // 作成したオブジェクトを子として登録
                    obj.transform.parent = transform;
                    color = true;
                    Pnum = 0;
                }
                else if (Pnum == 5)
                {
                    // プレハブからインスタンスを生成
					GameObject obj = PhotonNetwork.Instantiate("GreenBody", playerpos, playerrot, 0);
                    // 作成したオブジェクトを子として登録
                    obj.transform.parent = transform;
                    color = true;
                    Pnum = 0;
                }
            }
        }

    }
}
