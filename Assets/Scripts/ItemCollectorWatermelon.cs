using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectorWatermelon : MonoBehaviour
{
    private int watermelons = 0;
    [SerializeField] private Text WatermelonsText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CollectibleObjectTwo"))
        {
            Destroy(collision.gameObject);
            watermelons++;
            WatermelonsText.text = "Watermelon: " + watermelons;
            collectionSoundEffect.Play();

        }
    }
}
