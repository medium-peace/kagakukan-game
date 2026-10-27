using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class moneyGenerator : MonoBehaviour
{
	public GameObject moneyPrefab;
	float span = 0.8f;
	float delta = 0;
	void Update()
	{
		this.delta += Time.deltaTime;
		if(this.delta > this.span)
		{
			this.delta = 0;
			GameObject go = Instantiate(moneyPrefab);
			int py = Random.Range(3,8);
			go.transform.position = new Vector3(8, py, 0);
		}
	}
}