using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

// Start paralell development
// pull request test

public class MonsterFire : Photon.MonoBehaviour {

    public string str;
    private int modelNum;
    private List<GameObject> prefabs = new List<GameObject>();
    private const int maxObjectNum = 200;
	public GameObject particle;
	public GameObject generater;
//    public RawImage rawImage;
	public static bool saying = false;
	private float timeOut = 2.0f;
	private float timeElapsed = 0.0f;

    // Use this for initialization
    void Start () {
        GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;

    }

    // Update is called once per frame
    void Update () {

		if (saying == true) {
			timeElapsed += Time.deltaTime;

			if(timeElapsed >= timeOut) {
				saying = false;
				timeElapsed = 0.0f;
			}
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			GameObject bullet = PhotonNetwork.Instantiate ("Bullet", transform.position + new Vector3 (0.0f, 1.0f, 0.0f) + (transform.forward * 0.5f), transform.rotation, 0);
			bullet.GetComponent<Rigidbody> ().velocity = transform.forward * 15.0f;
		}

        if(Input.GetKeyDown(KeyCode.C))
        {
                        chooseModelInputText("apple:50");
            //GameObject.Find("RawImage").GetComponent<RawImage>().enabled = true;
//            image.fillAmount = 0;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
                        chooseModelInputText("gorilla:50");
            //GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;
            //            image.fillAmount = 0.5f;
        }
		if (Input.GetKeyDown(KeyCode.V))
		{
			chooseModelInputText("emoji/joy:80");
			//GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;
			//            image.fillAmount = 0.5f;
		}

    }

    void chooseModelInputText(string message)
    {
		Debug.Log ("Unity  【"+ message +"】");
		//Swiftのクラス呼び出し
		//1分間これが呼ばれなかったらもう一度呼び出すメソッドほしい
		//SwiftClass.swiftStartRecordingMethod ();

		int num = 0;
		if (message.IndexOf (":") <= 0) {
			if (message == "swiftstart") {
				GameObject.Find ("RawImage").GetComponent<RawImage> ().enabled = true;
			}
			if (message == "swiftstop") {
				GameObject.Find ("RawImage").GetComponent<RawImage> ().enabled = false;
			}
			return;
		}
		
        //string[0]:word, string[1]:value for scale
	    string[] stArrayData = message.Split(':');
	    int objScale = int.Parse(stArrayData[1]);

		string pos = "Prefab/";
		pos += stArrayData[0];

		Debug.Log("Object Name:"+stArrayData[0]);

        //GameObject temp = (GameObject)Resources.Load(modelName);
        GameObject temp = (GameObject)Resources.Load(pos);
        if (temp != null)
        {

			saying = true;

            num = prefabs.Count;//リストが削除されることを考えていない

            //Instantiate(prefabs[num - 1], new Vector3(0f, 1f, 0f), Quaternion.identity);
			float x = generater.transform.position.x+Random.Range(-0.1f,0.1f); //横
			float y = generater.transform.position.y+Random.Range(-1.0f,-0.5f); //縦
			float z = generater.transform.position.z+Random.Range(2.0f, 3.0f); //奥行き

			temp = PhotonNetwork.Instantiate(pos,new Vector3(x,y,z), transform.rotation, 0);

//            stArrayData = stArrayData[0].Split('/');
            if(stArrayData[0].IndexOf("/") > 0)
            {
                Debug.Log("emoji");
                objScale *= 2;
            }

			temp.transform.localScale = new Vector3((float)((float)objScale/100.0), (float)((float)objScale / 100.0), (float)((float)objScale / 100.0));
			particle = PhotonNetwork.Instantiate ("Holy Blast", new Vector3(x ,y, z) , transform.rotation, 0) as GameObject;
            prefabs.Add(temp);
           // temp.GetComponent<Rigidbody>().velocity = transform.forward * 15.0f;
            checkObjectNum(num);

        }
    }
		
    void checkObjectNum(int num)
    {
        if(maxObjectNum <= num)
        {
            PhotonNetwork.Destroy(prefabs[0]);
            prefabs.RemoveAt(0);
        }
    }
}
