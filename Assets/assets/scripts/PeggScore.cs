using Unity.VisualScripting;
using UnityEngine;

public class PeggScore : MonoBehaviour
{
    public int addPoints;
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D target)
    {
        ScoreManager.Instance.AddScore(addPoints);
        Destroy(gameObject);
    }
}
