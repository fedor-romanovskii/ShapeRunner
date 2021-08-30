using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeToRandomColor()
    {
        var rR = Random.Range(0, 1f);
        var rG = Random.Range(0, 1f);
        var rB = Random.Range(0, 1f);
        _renderer.color = new Color(rR, rG, rB);
    }
}
