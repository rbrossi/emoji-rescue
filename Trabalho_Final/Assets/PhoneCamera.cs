﻿//Acadêmicos: Bruno Simas, Edemar Borba, Eduardo Ferreira
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PhoneCamera : MonoBehaviour
{
	private bool camAvailable;
	private WebCamTexture backCam;
	private Texture defaultBackground;

	public RawImage background;
	public AspectRatioFitter fit;

	public Texture2D sourceTex;
	public Rect sourceRect;

	// Inicialização
	private void Start ()
	{
		
		defaultBackground = background.texture;
		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length == 0) {
			Debug.Log ("No camera");
			camAvailable = false;
			return;
		}

		for (int i = 0; i < devices.Length; i++) {
			if (devices [i].isFrontFacing) {
				backCam = new WebCamTexture (devices [i].name, Screen.width, Screen.height);
			}
		}
		if (backCam == null) {
			Debug.Log ("Camera not found");
			return;
		}

		backCam.Play ();
		background.texture = backCam;

		camAvailable = true;
	}
		
	// Update rodado uma vez por frame
		
	private void Update ()
	{
		if (!camAvailable) {
			return;
		}

		float ratio = (float)backCam.width / (float)backCam.height;
		fit.aspectRatio = ratio;

		float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f;
		background.rectTransform.localScale = new Vector3 (1f, scaleY, 1f);

		int orient = -backCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3 (0, 0, orient);

		if (Input.touchCount > 0) {
			System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
			int cur_time = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds;
			ScreenCapture.CaptureScreenshot(cur_time + ".png");
		}
	}
}
