using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public enum TypeLeader
    {
        Country,
        Army
    }

    [Serializable]
    public class Leader : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public TypeLeader TypeLeader;
        public List<AtributesAll> Atributtes;
    }
}