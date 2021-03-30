using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioManager.Instance.Play("CoinPickup");
            Score.currentScore += value;
            Destroy(gameObject);
        }
    }
}
