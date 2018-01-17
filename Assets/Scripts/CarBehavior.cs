﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehavior : MonoBehaviour {
	public float speed = 3;

	void Update () {
		transform.position += transform.up * speed * Time.deltaTime;
	}
}