using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public int speed = 2;
	int orientation = -1;
	//TODO unused, use to detect when char is on air.
	bool landed = false;
	Rigidbody2D rigitbody;
	Animator anim;

	void Awake(){
		rigitbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		Flip ();
	}

	void FixedUpdate(){
		Move ();
	}

	void Flip(){
		orientation *= -1;
		Vector3 theScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		transform.localScale = theScale;
	}

	void Move(){
		transform.position += transform.right * orientation * speed * Time.deltaTime;
		//fix rotation
		transform.rotation = Quaternion.identity;
	}


	void OnTriggerEnter2D(Collider2D other) {
		string tag = other.gameObject.tag;
		if(tag == "floor"){
			landed = true;
		}
		else if(tag == "wall"){
			Flip();
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.tag == "floor"){
			landed = false;
		}
	}
}
