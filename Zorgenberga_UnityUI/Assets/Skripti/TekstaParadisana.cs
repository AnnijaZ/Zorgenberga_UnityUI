using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {

	public string tekstsVards, tekstsGadi;

	public GameObject ievadesLauksVards;

	public GameObject ievadesLauksGadi;

	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		tekstsVards = ievadesLauksVards.GetComponent<Text> ().text;
		tekstsGadi = ievadesLauksGadi.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Tēla vārds ir "+tekstsVards+". Tam ir "+tekstsGadi+" gadi!"; 
	}
}
