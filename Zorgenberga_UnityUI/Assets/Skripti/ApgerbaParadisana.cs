using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApgerbaParadisana : MonoBehaviour {
	public GameObject dimantaCepure;
	public GameObject dimantaKrekls;
	public GameObject dimantaBikses;
	public GameObject dimantaKurpes;
	public GameObject zeltaCepure;
	public GameObject zeltaKrekls;
	public GameObject zeltaBikses;
	public GameObject zeltaKurpes;
	public GameObject adasCepure;
	public GameObject adasKrekls;
	public GameObject adasBikses;
	public GameObject adasKurpes;
	public GameObject neteritaCepure;
	public GameObject neteritaKrekls;
	public GameObject neteritaBikses;
	public GameObject neteritaKurpes;
	public GameObject dimantaZobens;
	public GameObject zeltaZobens;
	public GameObject akmenaZobens;
	public GameObject neteritaZobens;

	public void cepuresAttelosana(bool vertiba){
		dimantaCepure.SetActive (vertiba);
		zeltaCepure.SetActive (vertiba);
		adasCepure.SetActive (vertiba);
		neteritaCepure.SetActive (vertiba);
	}

	public void kreklaAttelosana(bool vertiba){
		dimantaKrekls.SetActive (vertiba);
		zeltaKrekls.SetActive (vertiba);
		adasKrekls.SetActive (vertiba);
		neteritaKrekls.SetActive (vertiba);
	}

	public void biksesAttelosana(bool vertiba){
		dimantaBikses.SetActive (vertiba);
		zeltaBikses.SetActive (vertiba);
		adasBikses.SetActive (vertiba);
		neteritaBikses.SetActive (vertiba);
	}

	public void kurpesAttelosana(bool vertiba){
		dimantaKurpes.SetActive (vertiba);
		zeltaKurpes.SetActive (vertiba);
		adasKurpes.SetActive (vertiba);
		neteritaKurpes.SetActive (vertiba);
	}

	public void zobenaAttelosana(bool vertiba){
		dimantaZobens.SetActive (vertiba);
		zeltaZobens.SetActive (vertiba);
		akmenaZobens.SetActive (vertiba);
		neteritaZobens.SetActive (vertiba);
	}
}
