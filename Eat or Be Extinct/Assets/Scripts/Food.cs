using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food: MonoBehaviour
{
    [SerializeField] GameObject[] foodPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FoodSpawn());
    }

    IEnumerator FoodSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.x);
            GameObject gameObject = Instantiate(fruitPrefab[Random.Range(0, fruitPrefab.Length)],
                position, Quaternion.identity);

            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}