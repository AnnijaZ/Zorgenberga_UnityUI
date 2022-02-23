using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeluParadisana : MonoBehaviour {

	public GameObject attelaTuretajs;
	public Sprite[] attelumasivs;
	public GameObject slaideris1;
	public GameObject slaideris2;

	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [1];
	}

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris1.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
	}
}
