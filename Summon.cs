using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public void SummonHeroes(int _amount)
    {

        ref int _contracts = ref PlayerResources._commonContracts;
        if (_amount / 100 == 2) _contracts = ref PlayerResources._eliteContracts;
        if (_amount / 100 == 3) _contracts = ref PlayerResources._kingContracts;
        _amount = _amount % 100;
        if (_contracts >= _amount)
        {
            for (int i = 0; i < _amount; i++)
            {
                switch (Random.Range(0, 4))
                {
                    case 0: { HeroList.Add(new Berserk("Berserk")); break; }
                    case 1: { HeroList.Add(new EagleEye("EagleEye")); break; }
                    case 2: { HeroList.Add(new VainDiMerrel("VainDiMerrel")); break; }
                    case 3: { HeroList.Add(new Crow("Crow")); break; }
                }
                
            }
            _contracts -= _amount;
        }
        else Debug.Log("Недостаточно свитков");
    }
}
