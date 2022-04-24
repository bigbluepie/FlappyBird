using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pillarGroup;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            float rand = Random.Range(-2f, 2f);
            GameObject newPillar = Instantiate(_pillarGroup, new Vector3(4f, rand, 0f), Quaternion.identity);
            Destroy(newPillar, 10f);
        }
    }
}
