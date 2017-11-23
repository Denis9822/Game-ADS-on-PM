using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class LoadAds : MonoBehaviour {
	
	public void ShowVideo()
	{

		if (Advertisement.isSupported) {
			Advertisement.Initialize ("1586786",false);


		} else {
			Debug.Log ("НЕТ РЕКЛАПМЫ");
		}




		StartCoroutine ("ShowADS");





	}



	IEnumerator ShowADS(){

		yield return new WaitForSeconds (0.5f);
		while (!Advertisement.IsReady ())
			yield return null;
		Advertisement.Show ();

	}

}

