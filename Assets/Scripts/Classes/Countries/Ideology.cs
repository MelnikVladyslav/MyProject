using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    [Serializable]
    public class Ideology : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public List<AtributesAll> Atributtes;
    }
}