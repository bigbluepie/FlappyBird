using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _spawnRate;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxHeight;
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), _spawnRate, _spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pillars = Instantiate(_prefab, transform.position, Quaternion.identity);
        pillars.transform.position += Vector3.up * Random.Range(_minHeight, _maxHeight);
    }
}
