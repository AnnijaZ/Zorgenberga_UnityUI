using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ApgerbaAizvilksana : MonoBehaviour {
	private RectTransform transformacijasLogs;
	public Canvas kanva;

	void Start () {
		transformacijasLogs = GetComponent<RectTransform> ();
	}

	public void OnDrag(PointerEventData notikums){
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
}
