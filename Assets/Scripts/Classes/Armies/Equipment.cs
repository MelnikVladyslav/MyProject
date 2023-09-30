using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    [Serializable]
    public class Equipment : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public Country Country;
        public List<Details> Details;
        public List<AtributesAll> Atributtes;
    }
}