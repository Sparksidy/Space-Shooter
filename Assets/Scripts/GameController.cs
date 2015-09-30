using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public int waveWait;

	void Start(){
		StartCoroutine(spawnWaves ());
	}

	IEnumerator spawnWaves(){
		yield return new WaitForSeconds(startWait);
		while(true){
			for (int i = 0; i < hazardCount; i++) {
			
				Vector3 spawnposition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnrotation = Quaternion.identity;
				Instantiate (hazard, spawnposition, spawnrotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
