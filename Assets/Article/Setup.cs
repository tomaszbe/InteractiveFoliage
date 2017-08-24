using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour {


	public Camera cam;

	public Material mat;

	// Use this for initialization
	void Start () {
		Matrix4x4 vp = cam.projectionMatrix * cam.worldToCameraMatrix;


		mat.SetMatrix("_Matrix", vp);
		mat.SetTexture("_PlayersTexture", cam.targetTexture);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
