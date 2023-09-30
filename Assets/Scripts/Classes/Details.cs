using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public enum TypeDet
    {
        KorpusPih,
        KorpusTank,
        KorpusPlane,
        KorpusAuto,
        DvugunAuto,
        DvugunTank,
        DvugunPlane,
        BronyaTank,
        Aptek,
        Sniper,
        Kul,
        Minomet,
        Forma,
        Patronu,
        GarmataAuto,
        GarmataTank,
        GarmataPlane,
        Basa
    }

    public enum TypeEq
    {
        Pihota,
        Forma,
        Dodatkove,
        Artillery,
        Auto,
        Tank,
        Plane
    }

    public enum TypeAuto
    {
        Auto,
        Btr,
        Bmp,
        Ppo
    }

    public enum TypePlane
    {
        Fighter,
        Shturmovik,
        Bomber
    }

    [Serializable]
    public class Details : MonoBehaviour
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime DateOpen;
        public TypeDet TypeDetail;
        public TypeEq TypeEquipment;
        public TypeAuto TypeAuto;
        public TypePlane TypePlane;
        public List<AtributesAll> Atributtes;
    }
}