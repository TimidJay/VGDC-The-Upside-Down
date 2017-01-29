using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
    public Vector2 targetPosition;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            print(targetPosition);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
	}
}
