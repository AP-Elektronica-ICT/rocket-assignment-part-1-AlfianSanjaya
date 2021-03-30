using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
	public float speed;
	public int distance;
	int count = 0;
	int dir = 1;


	void Update()
	{
		transform.Translate(new Vector3(dir, 0, 0) * speed * Time.deltaTime);
		if (count == distance)
        {
			Debug.Log("Switch dir");
			dir *= (-1);
			count = 0;
		}
		count++;
	}
}
