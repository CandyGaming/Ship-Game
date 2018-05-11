using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kup : MonoBehaviour {

    public Rigidbody emjuk;
    public int deger1;
    public string deger2;
    public float deger3;
    public float deger4;
    public Text Yazi;
	void Start () {
        deger4 = 3f;
	}
	
	// Update is called once per frame
	void Update () {
        if (deger4 >= 0)
        {
            deger4 -= Time.deltaTime;
            Yazi.text = deger4.ToString("0");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 2);
            emjuk.AddForce(Vector3.forward);

        }
	}
}
