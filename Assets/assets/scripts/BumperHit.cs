using UnityEngine;
using System;   //nodig voor Action
public class BumperHit : MonoBehaviour
{
    [SerializeField] private int scoreValue = 100;
    [SerializeField] private int bumpsTillDespawn;
    public static event Action<string, int> onBumperHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            bumpsTillDespawn --;
            onBumperHit?.Invoke(gameObject.tag, scoreValue);//bericht versturen dat er een bumper geraakt is. De tag en waarde sturen we mee
            if (bumpsTillDespawn <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}