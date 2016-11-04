using UnityEngine;
using System.Collections;

public class playerlocate : MonoBehaviour
{

    GameObject[] playerObjects;
    int playerNum;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //playerNumはログイン後しばらく0なのでUpdate側で数値の変化をチェック

        if (playerNum == 0)
        {

            playerObjects = GameObject.FindGameObjectsWithTag("Player");
            playerNum = playerObjects.Length;

            if (playerNum == 1)
            {
                this.transform.position = new Vector3(0, 2, 4);
                this.transform.LookAt(new Vector3(0, 2, 0));
                Debug.Log("photon login :" + playerNum);
                Debug.Log("【Unity】: Start Record");
                SwiftClass.swiftStartRecordingMethod();
            }
            else if (playerNum == 2)
            {
                this.transform.position = new Vector3(0, 2, -4);
                this.transform.LookAt(new Vector3(0, 2, 0));
                Debug.Log("photon login :" + playerNum);
                Debug.Log("【Unity】: Start Record");
                SwiftClass.swiftStartRecordingMethod();
            }
            else if (playerNum == 3)
            {
                this.transform.position = new Vector3(4, 2, 0);
                this.transform.LookAt(new Vector3(0, 2, 0));
                Debug.Log("photon login :" + playerNum);
                Debug.Log("【Unity】: Start Record");
                SwiftClass.swiftStartRecordingMethod();
            }
            else if (playerNum == 4)
            {
                this.transform.position = new Vector3(-4, 2, 0);
                this.transform.LookAt(new Vector3(0, 2, 0));
                Debug.Log("photon login :" + playerNum);
                Debug.Log("【Unity】: Start Record");
                SwiftClass.swiftStartRecordingMethod();
            }
            else if (playerNum > 4)
            {
                //5人目以降。時間があれば同心円上に並べたい…
                this.transform.position = new Vector3(Random.Range(-4f, 4f), 2, Random.Range(-4f, 4f));
                this.transform.LookAt(new Vector3(0, 2, 0));
            }

            //MonsterFireでCameracontrallerが飛んでっちゃうの防ぐ
            Vector3 pos = transform.position;
            pos.y = 2;
            transform.position = pos;
        }

    }

}
