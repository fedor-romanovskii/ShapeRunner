using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private readonly T _prefab;
    private readonly Transform _container;
    private List<T> _pool;

    public ObjectPool(T prefab, int initialCount, Transform container)
    {
        _prefab = prefab;
        _container = container;

        CreatePool(initialCount);
    }

    public T GetFreeElement()
    {
        if (HasFreeElement(out var element))
        {
            return element;
        }

        return CreateObject(true);
    }

    private void CreatePool(int count)
    {
        _pool = new List<T>();

        for (int i = 0; i < count; i++)
        {
            CreateObject();
        }
    }

    private T CreateObject(bool isActive = false)
    {
        var newPoolObject = Object.Instantiate(_prefab, _container);
        newPoolObject.gameObject.SetActive(isActive);
        _pool.Add(newPoolObject);
        return newPoolObject;
    }

    private bool HasFreeElement(out T element)
    {
        foreach (var item in _pool)
        {
            if (!item.gameObject.activeInHierarchy)
            {
                element = item;
                item.gameObject.SetActive(true);
                return true;
            }
        }

        element = null;
        return false;
    }
}
