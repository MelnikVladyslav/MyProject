using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public enum TypeArmy
    {
        Army,
        Aviaplane
    }

    [Serializable]
    public class Army : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public Leader Leader;
        public TypeArmy TypeArmy;
        public List<UnitArmy> KilkistyUnits;
    }
}