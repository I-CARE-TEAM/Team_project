﻿using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	public void LoadScene(int level){
		Application.LoadLevel (level);
	}
}
