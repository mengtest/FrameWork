﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassFP_Printer : MonoBehaviour {
	public GameObject prefab;
	public void Add(Vector3 pos,float size)
	{
		Transform print = Instantiate (prefab).transform;
		print.position = new Vector3 (pos.x, GrassFP_Manager.BasicHeight+1.5f, pos.z);
		print.localScale = new Vector3 (size, 1, size);
	}
}