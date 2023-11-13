using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coinText; 
    public static int coinCount=0; 
    public float rotationSpeed = 100f;
    public AudioSource Coinaudio;
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
  
    private void OnTriggerEnter(Collider coinCollider)
    {
        if (coinCollider.CompareTag("Player")) 
        {
            Coinaudio.Play();
            CollectCoin();
            Destroy(gameObject);
            //Coinaudio.Stop();
        }
    }

   
    private void UpdateUI()
    {
        coinText.text = coinCount.ToString();
    }

    
    private void CollectCoin()
    {
        coinCount++;
        UpdateUI();
    }
}

