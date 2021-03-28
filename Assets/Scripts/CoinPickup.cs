using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //GameManager.currentScore += value;
            Score.currentScore += value;
            Destroy(gameObject);
        }
    }
}
