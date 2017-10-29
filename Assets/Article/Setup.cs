using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour {


	public Camera cam;

	public Material mat;

	// Use this for initialization
	void FixedUpdate () {
		Matrix4x4 vp = cam.projectionMatrix * cam.worldToCameraMatrix;


		mat.SetMatrix("_Matrix", vp);
	}

    // Update is called once per frame
    private void Start()
    {
        mat.SetTexture("_PlayersTexture", cam.targetTexture);
    }
}
