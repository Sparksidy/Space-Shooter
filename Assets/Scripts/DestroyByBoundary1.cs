using UnityEngine;
using System.Collections;

public class DestroyByBoundary1 : MonoBehaviour {

	void OnTriggerExit(Collider other){
		Destroy (other.gameObject);
	}
}
