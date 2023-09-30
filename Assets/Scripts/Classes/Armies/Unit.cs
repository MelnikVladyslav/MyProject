using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public enum TypeUnit
    { 
        Pihota,
        PidtrPihota,
        Motorization,
        Mechanization,
        Btr,
        Tank,
        Fighter,
        Sturmovik,
        Bomber
    }

    [Serializable]
    public class Unit : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime DateOpen;
        public int KilkistyRecruit;
        public TypeUnit TypeUnit;
        public List<Equipment> Equipment;
        public List<AtributesAll> Atributtes;
    }
}