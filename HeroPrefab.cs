using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPrefab : MonoBehaviour
{
    [SerializeField] public PolygonCollider2D[] _colliders;
    [SerializeField] public Sprite[] _sprites;
    [SerializeField] public Color[] _colors;
    private SpriteRenderer _srend;
    public int _id;
    public bool _choosen;

    private void Start()
    {
        for (int i = 0; i < _colliders.Length; i++)
            _colliders[i].enabled = false;
        _srend = GetComponent<SpriteRenderer>();
        Invoke("SetID", 0.1f);
    }

    private void SetID()
    {
        switch (_id)
        {
            case 514:
                {
                    _colliders[0].enabled = true;
                    _srend.sprite = _sprites[0];
                    _srend.color = _colors[3];
                    break;
                }
            case 523:
                {
                    _colliders[1].enabled = true;
                    _srend.sprite = _sprites[1];
                    _srend.color = _colors[2];
                    break;
                }
            case 532:
                {
                    _colliders[2].enabled = true;
                    _srend.sprite = _sprites[2];
                    _srend.color = _colors[1];
                    break;
                }
            case 541:
                {
                    _colliders[3].enabled = true;
                    _srend.sprite = _sprites[3];
                    _srend.color = _colors[0];
                    break;
                }
        }
    }

    private void OnMouseDown()
    {
        _choosen = true;
    }
}