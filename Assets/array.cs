using UnityEngine;

public class array : MonoBehaviour
{
    [SerializeField] string[] dingen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {

        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) PrintRandomItem();
        if (Input.GetKeyDown(KeyCode.Escape)) PrintAllItems();
    }

    void PrintRandomItem()
    {
        
        Debug.Log(dingen[Random.Range(0, 10)]);
    }

    void PrintAllItems()
    {
        foreach (var i in dingen)
        {
            Debug.Log(i);
        }
    }
}
