using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerResources : MonoBehaviour
{
    public static byte _lvl;
    public static int _exp;
    public static int _maxExp;
    public static byte _heroes;

    public static int _money;
    public static int _commonContracts;
    public static int _eliteContracts;
    public static int _kingContracts;
    public static int _commonBooks;
    public static int _eliteBooks;
    public static int _kingBooks;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _lvl = 1;
        _exp = 0;
        _maxExp = 11;
        _commonContracts = 25;
        _eliteContracts = 15;
        _kingContracts = 5;
        _money = 100;
        _heroes = 0;
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

}
public class HeroList
{
    public static List<Hero> _heroes = new List<Hero>();

    public static void Add(Hero _hero)
    {
        PlayerResources._heroes++;
        _heroes.Add(_hero);
        Sort();
    }
    public static void Atomize(Hero _hero)
    {
        PlayerResources._heroes--;
        _heroes.Remove(_hero);
        Sort();
    }

    private static void Sort()
    {
        for (int i = 0; i < _heroes.Count - 1; i++)
        {
            for (int j = i + 1; j < _heroes.Count; j++)
            {
                if (_heroes[j]._id > _heroes[i]._id)
                {
                    Hero temp = _heroes[i];
                    _heroes[i] = _heroes[j];
                    _heroes[j] = temp;
                }
            }
        }
    }
}
public class Hero
{
    public string _name;
    public int _id; // stars, class, nation     111-544
    public string _class; // warrior, archer, mage, killer
    public string _nation; // elderian, solmarian, berberrian, kaufhill
    public byte _stars; // 1-5 stars
    public byte _eliteness; // 1-5 eliteness

    public byte _lvl;
    public int _exp;
    public int _maxexp;

    public int _strength;
    public int _agility;
    public int _endurance;
    public int _intellect;
    public int _luck;

    public int _hp;
    public int _atk;
    public int _def;
    public int _speed;

    public Hero(string name)
    {
        _name = name;
        _eliteness = 1;
        _lvl = 1;
        _exp = 0;
    }

    public virtual void SetCharacteristics()
    {
        _strength = 20;
        _agility = 20;
        _endurance = 20;
        _intellect = 20;
        _luck = 20;
        SetStates();
    }
    public virtual void SetStates()
    {
        _hp = (_strength + 2 * _endurance) * _stars * _eliteness;
        _atk = (_agility + 2 * _strength) * _stars * _eliteness;
        _def = (3 * _endurance) * _stars * _eliteness;
        _speed = (_strength + 2 * _agility) * _stars * _eliteness;
    }
}
public class Berserk : Hero
{
    public Berserk(string name) : base(name)
    {
        _id = 514;
        _stars = 5;
        _class = "warrior";
        _nation = "kaufhill";
    }
    public override void SetCharacteristics()
    {
        _strength = 30;
        _agility = 10;
        _endurance = 40;
        _intellect = 5;
        _luck = 15;
    }
    public override void SetStates()
    {
        base.SetStates();
    }
}
public class EagleEye : Hero
{
    public EagleEye(string name) : base(name) 
    {
        _id = 523;
        _stars = 5;
        _class = "archer";
        _nation = "berberrian";
    }
    public override void SetCharacteristics()
    {
        _strength = 30;
        _agility = 30;
        _endurance = 10;
        _intellect = 10;
        _luck = 20;
    }
    public override void SetStates()
    {
        base.SetStates();
    }
}
public class VainDiMerrel : Hero
{
    public VainDiMerrel(string name) : base(name)
    {
        _id = 532;
        _stars = 5;
        _class = "mage";
        _nation = "solmarian";
    }
    public override void SetCharacteristics()
    {
        _strength = 5;
        _agility = 15;
        _endurance = 15;
        _intellect = 50;
        _luck = 15;
    }
    public override void SetStates()
    {
        base.SetStates();
        _atk = (3 * _intellect) * _stars * _eliteness;
    }
}
public class Crow : Hero
{
    public Crow(string name) : base(name) 
    {
        _id = 541;
        _stars = 5;
        _class = "killer";
        _nation = "elderian";
    }
    public override void SetCharacteristics()
    {
        _strength = 15;
        _agility = 25;
        _endurance = 15;
        _intellect = 10;
        _luck = 35;
    }
    public override void SetStates()
    {
        base.SetStates();
    }
}