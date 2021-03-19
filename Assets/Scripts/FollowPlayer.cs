using UnityEngine;

public class FollowPlayer: MonoBehaviour
{
    [SerializeField] Vector3 offset;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        transform.position = player.position + offset;
    }
}
