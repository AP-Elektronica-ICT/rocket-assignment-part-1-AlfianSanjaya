using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
