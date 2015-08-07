using UnityEngine;
using System.Collections;

public class playerMotion : MonoBehaviour {

	private Rigidbody rigid;
	private Transform trans;
	private bool jumping = false;
	// Use this for initialization
	void Start () {
		rigid = this.gameObject.GetComponent<Rigidbody> ();
		trans = this.gameObject.GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {



		if(Input.GetKey("up")){
			rigid.AddForce(0,0,20.0f);
		}

		if(Input.GetKey("left")){
			trans.Rotate(0,-1,0);
		}
		if(Input.GetKey("right")){
			trans.Rotate(0,1,0);
		}
		if(!jumping){
			if(Input.GetKey("space")){
				rigid.AddForce(0,100,0);
				jumping = true;
			}
		}
	
		if(trans.position.y < 2.0f){
			jumping = false;
		}
	}
}
