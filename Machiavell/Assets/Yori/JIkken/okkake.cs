using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okkake : MonoBehaviour
{
	// ターゲットとなるオブジェクト
	public GameObject player;
	
	[SerializeField]
	private PolygonCollider2D area;

	void Update()
	{
		Vector2 targeting = (player.transform.position - this.transform.position).normalized;

		this.GetComponent<Rigidbody2D>().velocity = new Vector2((targeting.x * 10), targeting.y * 10);

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, area.bounds.min.x + 0.5f, area.bounds.max.x - 0.5f),
			(Mathf.Clamp(transform.position.y, area.bounds.min.y + 0.5f, area.bounds.max.y - 0.5f)), transform.position.z);
	}
}
