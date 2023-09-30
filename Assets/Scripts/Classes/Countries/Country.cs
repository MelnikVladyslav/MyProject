using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    [Serializable]
    public class Country : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public int Population;
        public int Recruit;
        public Ideology Ideology;
        public Leader Leader;
        public string flagUrl;
        public List<BuildCountry> KilkistyBuilds;
        public List<ArmyCountry> Armies;
    }
}