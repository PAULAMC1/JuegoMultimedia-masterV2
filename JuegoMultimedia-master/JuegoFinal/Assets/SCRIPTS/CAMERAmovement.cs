using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAmovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 0.4f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * 0.4f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * 0.4f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 0.4f);
        }


        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(Vector3.left * 0.4f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up * 0.4f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.down * 0.4f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(Vector3.right * 0.4f);
        }
    }
}
