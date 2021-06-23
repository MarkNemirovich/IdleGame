using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] public Text _lvl;
    [SerializeField] public Slider _exp;
    [SerializeField] public Text _money;
    [SerializeField] public Text _diamonds;
    [SerializeField] public Text _commonBooks;
    [SerializeField] public Text _eliteBooks;
    [SerializeField] public Text _kingBooks;
    [SerializeField] public Text _commonContracts;
    [SerializeField] public Text _eliteContracts;
    [SerializeField] public Text _kingContracts;
    [SerializeField] public Text _heroes;
    [SerializeField] public Image _heroImage;

    void Update()
    {
        if (_lvl != null) _lvl.text = $"Lvl = {PlayerResources._lvl}";
        if (_exp != null) _exp.value = PlayerResources._exp / PlayerResources._maxExp;
        if (_money != null) _money.text = $"Money = {PlayerResources._money}";
        if (_heroes != null) _heroes.text = $"Heroes' amount = {PlayerResources._heroes}";
        if (_commonContracts != null) _commonContracts.text = $"Common contracts = {PlayerResources._commonContracts}";
        if (_eliteContracts != null) _eliteContracts.text = $"Elite contracts = {PlayerResources._eliteContracts}";
        if (_kingContracts != null) _kingContracts.text = $"King contracts = {PlayerResources._kingContracts}";
        if (_commonBooks != null) _commonBooks.text = $"Common books = {PlayerResources._commonBooks}";
        if (_eliteBooks != null) _eliteBooks.text = $"Elite books = {PlayerResources._eliteBooks}";
        if (_kingBooks != null) _kingBooks.text = $"King books = {PlayerResources._kingBooks}";
    }
}
