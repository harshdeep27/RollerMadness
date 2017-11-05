using UnityEngine;
using System.Collections;

public class MyHealth : MonoBehaviour {
	public bool damageOnTrigger = true;
	public float heal = 10f;
	public bool damageOnCollision = false;
	public GameObject mygo; 
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per fram
		void OnCollisionEnter(Collision collision) 						// this is used for things that explode on impact and are NOT triggers
		{	
		if (damageOnTrigger||damageOnCollision) {
				if (this.tag == "Player" && collision.gameObject.tag == "Player")	// if the player got hit with it's own bullets, ignore it
					return;

				if (collision.gameObject.GetComponent<Health> () != null) {	// if the hit object has the Health script on it, deal damage
				collision.gameObject.GetComponent<Health> ().ApplyHeal (heal);
		
				}
			}
		}


}
