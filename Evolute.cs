using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evolute : MonoBehaviour
{
    public GameObject[] _objects;
    public HeroPrefab[] _heroes;
    public GameObject _choosen;
    [SerializeField] public Image _heroImage;
    [SerializeField] public Text[] _heroUI;
    void Start()
    {
        _objects = new GameObject[PlayerResources._heroes];
        _heroes = new HeroPrefab[PlayerResources._heroes];
        Transform _heroTransform = gameObject.transform;
        for(int i = 0; i < HeroList._heroes.Count; i++)
        {
            _objects[i] = Instantiate(Resources.Load("_hero", typeof(GameObject)), gameObject.transform) as GameObject;   // создание объекта на поле
            _objects[i].transform.position = gameObject.transform.position + new Vector3(-8f + 2 * (i % 8), 5 - 2.5f * (i / 8), 0f);
            _objects[i].name = HeroList._heroes[i]._name;
            _heroes[i] = _objects[i].GetComponent<HeroPrefab>();
            _heroes[i]._id = HeroList._heroes[i]._id;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _heroes.Length; i++)
        {
            if (_heroes[i]._choosen)
            {
                _heroImage.sprite = _heroes[i].GetComponent<SpriteRenderer>().sprite;
                _heroImage.color = _heroes[i].GetComponent<SpriteRenderer>().color;
                HeroList._heroes[i].SetCharacteristics();
                HeroList._heroes[i].SetStates();
                _heroUI[0].text = $"LVL = {HeroList._heroes[i]._lvl}";
                _heroUI[1].text = $"EXP = {HeroList._heroes[i]._exp}";
                _heroUI[2].text = $"HP = {HeroList._heroes[i]._hp}";
                _heroUI[3].text = $"ATK = {HeroList._heroes[i]._atk}";
                _heroUI[4].text = $"DEF = {HeroList._heroes[i]._def}";
                _heroUI[5].text = $"SPEED = {HeroList._heroes[i]._speed}";
                _heroUI[6].text = $"STARS = {HeroList._heroes[i]._stars}";
                _heroUI[7].text = $"ELITE = {HeroList._heroes[i]._eliteness}";
                _choosen = _objects[i];
                _heroes[i]._choosen = false;
            }
        }
    }

    public void Evolve()
    {

    }
}
