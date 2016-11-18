using UnityEngine;
using System.Collections;

public class playersbodygenerater : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;
	public GameObject player5;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerpos = this.transform.position;
		Quaternion playerrot = this.transform.rotation;
		int Pnum = playerlocate.Pnum;

		if (Pnum != 0) {
			if (Pnum == 1) {
				// プレハブからインスタンスを生成
				GameObject obj = (GameObject)Instantiate (player1, playerpos, playerrot);
				// 作成したオブジェクトを子として登録
				obj.transform.parent = transform;
				Pnum = 0;
			} else if (Pnum == 2) {
				// プレハブからインスタンスを生成
				GameObject obj = (GameObject)Instantiate (player2, playerpos, playerrot);
				// 作成したオブジェクトを子として登録
				obj.transform.parent = transform;
				Pnum = 0;
			} else if (Pnum == 3) {
				// プレハブからインスタンスを生成
				GameObject obj = (GameObject)Instantiate (player3, playerpos, playerrot);
				// 作成したオブジェクトを子として登録
				obj.transform.parent = transform;
				Pnum = 0;
			} else if (Pnum == 4) {
				// プレハブからインスタンスを生成
				GameObject obj = (GameObject)Instantiate (player4, playerpos, playerrot);
				// 作成したオブジェクトを子として登録
				obj.transform.parent = transform;
				Pnum = 0;
			} else if (Pnum == 5) {
				// プレハブからインスタンスを生成
				GameObject obj = (GameObject)Instantiate (player5, playerpos, playerrot);
				// 作成したオブジェクトを子として登録
				obj.transform.parent = transform;
				Pnum = 0;
			}
		}
			

	}
}
