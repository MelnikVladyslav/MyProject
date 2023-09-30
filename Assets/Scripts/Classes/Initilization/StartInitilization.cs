using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Classes.Initilization
{
    public class StartInitilization : MonoBehaviour
    {
        public List<Atributtes> atributtes = new List<Atributtes>();
        public List<Details> details = new List<Details>();
        public List<Ideology> ideologies = new List<Ideology>();
        public List<Unit> units = new List<Unit>();
        public List<Build> builds = new List<Build>();
        public List<Leader> leaders = new List<Leader>();
        public List<Army> armies = new List<Army>();
        public List<Country> countries = new List<Country>();
        public Text listCount;

        // Use this for initialization
        void Start()
        {
            InitilizationAtributes();
            InitilizationDetails();
            InitilizationIdeology();
            InitilizationBuilds();
        }

        void Update()
        {
            if (countries != null)
            {
                listCount.text = "";
                for (int i = 0; i < countries.Count; i++)
                {
                    listCount.text += countries[i].Name + "\n";
                }
            }
        }

        void InitilizationAtributes()
        {
            atributtes = new List<Atributtes> 
            { 
                new Atributtes()
                {
                    Id = 0,
                    Name = "Hp",
                    Description = "Життя юніта, тобто скільки атак він може витримати."
                },
                new Atributtes()
                {
                    Id = 1,
                    Name = "Def",
                    Description = "Броня юніта, додатковий захист."
                },
                new Atributtes()
                {
                    Id = 2,
                    Name = "Atk",
                    Description = "Атака юніта - скільки за один раз він нанесе урону."
                },
                new Atributtes()
                {
                    Id = 3,
                    Name = "Br",
                    Description = "Бронебійність - чим більша тим більший шанс пробиття броні ворога, в разі не пробиття тим більше нанесено урону буде противнику."
                },
                new Atributtes()
                {
                    Id = 4,
                    Name = "Speed",
                    Description = "Швидкість - як швидко пересуваться юніт( базова 4 км/год )."
                },
                new Atributtes()
                {
                    Id = 5,
                    Name = "Vaga",
                    Description = "Маса техніки - впливає на швидкість і маневреність техніки."
                },
                new Atributtes()
                {
                    Id = 6,
                    Name = "Dalnisty",
                    Description = "Дальність юніта - на якій відстані він відреагує на ворога автоматично."
                }
            };
        }

        void InitilizationDetails()
        {
            details = new List<Details>()
            {
                //Pihota
                //1910
                new Details()
                {
                    Id = 0,
                    Name = "Корпус гвинтівки 1910",
                    Description = "Корпус гвинтівки був створений в 1910 р.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll> 
                    { 
                        new AtributesAll() 
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 5
                        } 
                    }
                },
                new Details()
                {
                    Id = 1,
                    Name = "Патрони 1910",
                    Description = "Вони були створені в 1910 р.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 1
                        }
                    }
                },
                //1914
                new Details()
                {
                    Id = 2,
                    Name = "Корпус гвинтівки 1914",
                    Description = "Корпус гвинтівки був створений в 1914 р.",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 3,
                    Name = "Патрони 1914",
                    Description = "Вони були створені в 1914 р.",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 2
                        }
                    }
                },
                //1916
                new Details()
                {
                    Id = 4,
                    Name = "Корпус автоматичної гвинтівки 1916",
                    Description = "Корпус автоматичної гвинтівки був створений в 1916 р.",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 5,
                    Name = "Патрони 1916",
                    Description = "Вони були створені в 1916 р. і були призначені для автоматичної гвинтіки",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 3
                        }
                    }
                },
                //1919
                new Details()
                {
                    Id = 6,
                    Name = "Корпус автоматичної гвинтівки 1919",
                    Description = "Корпус автоматичної гвинтівки був створений в 1919 р.",
                    DateOpen = Convert.ToDateTime("01.01.1919"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 7,
                    Name = "Патрони 1919",
                    Description = "Вони були створені в 1919 р. і були призначені для автоматичної гвинтіки",
                    DateOpen = Convert.ToDateTime("01.01.1919"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 4
                        }
                    }
                },
                //1921
                new Details()
                {
                    Id = 8,
                    Name = "Корпус автоматичної гвинтівки 1921",
                    Description = "Корпус автоматичної гвинтівки був створений в 1921 р.",
                    DateOpen = Convert.ToDateTime("01.01.1921"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 9,
                    Name = "Патрони 1921",
                    Description = "Вони були створені в 1921 р. і були призначені для автоматичної гвинтіки",
                    DateOpen = Convert.ToDateTime("01.01.1921"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 5
                        }
                    }
                },
                //1933
                new Details()
                {
                    Id = 10,
                    Name = "Корпус автоматичної гвинтівки 1933",
                    Description = "Корпус автоматичної гвинтівки був створений в 1933 р.",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 30
                        }
                    }
                },
                new Details()
                {
                    Id = 11,
                    Name = "Патрони 1933",
                    Description = "Вони були створені в 1933 р. і були призначені для автоматичної гвинтіки",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 6
                        }
                    }
                },
                //1936
                new Details()
                {
                    Id = 12,
                    Name = "Корпус автоматичної гвинтівки 1936",
                    Description = "Корпус автоматичної гвинтівки був створений в 1936 р.",
                    DateOpen = Convert.ToDateTime("01.01.1936"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 13,
                    Name = "Патрони 1936",
                    Description = "Вони були створені в 1936 р. і були призначені для автоматичної гвинтіки",
                    DateOpen = Convert.ToDateTime("01.01.1936"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 7
                        }
                    }
                },
                //1939
                new Details()
                {
                    Id = 14,
                    Name = "Корпус пістолета-кулемета 1939",
                    Description = "Корпус пістолета-кулемета був створений в 1939 р.",
                    DateOpen = Convert.ToDateTime("01.01.1939"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 15,
                    Name = "Патрони 1939",
                    Description = "Вони були створені в 1939 р. і були призначені для пістолету-кулемету",
                    DateOpen = Convert.ToDateTime("01.01.1939"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 40
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 8
                        }
                    }
                },
                //1945
                new Details()
                {
                    Id = 16,
                    Name = "Корпус автомата 1945",
                    Description = "Корпус автомата був створений в 1945 р.",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 45
                        }
                    }
                },
                new Details()
                {
                    Id = 17,
                    Name = "Патрони 1945",
                    Description = "Вони були створені в 1945 р. і були призначені для автомата",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 45
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 9
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 18,
                    Name = "Корпус автомата 1970",
                    Description = "Корпус автомата був створений в 1970 р.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 50
                        }
                    }
                },
                new Details()
                {
                    Id = 19,
                    Name = "Патрони 1970",
                    Description = "Вони були створені в 1970 р. і були призначені для автомата",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 50
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 10
                        }
                    }
                },
                //1990
                new Details()
                {
                    Id = 20,
                    Name = "Корпус автомата 1990",
                    Description = "Корпус автомата був створений в 1990 р.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 55
                        }
                    }
                },
                new Details()
                {
                    Id = 21,
                    Name = "Патрони 1990",
                    Description = "Вони були створені в 1990 р. і були призначені для автомата",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 55
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 11
                        }
                    }
                },
                //2000
                new Details()
                {
                    Id = 22,
                    Name = "Корпус автомата 2000",
                    Description = "Корпус автомата був створений в 2000 р.",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.KorpusPih,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 60
                        }
                    }
                },
                new Details()
                {
                    Id = 23,
                    Name = "Патрони 2000",
                    Description = "Вони були створені в 2000 р. і були призначені для автомата",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Patronu,
                    TypeEquipment = TypeEq.Pihota,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 60
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 12
                        }
                    }
                },
                //Forma
                //1910
                new Details()
                {
                    Id = 24,
                    Name = "Форма 1910",
                    Description = "Форма військового 1910",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 1
                        }
                    }
                },
                //1914
                new Details()
                {
                    Id = 25,
                    Name = "Форма 1914",
                    Description = "Форма військового 1914",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 2
                        }
                    }
                },
                //1921
                new Details()
                {
                    Id = 26,
                    Name = "Форма 1921",
                    Description = "Форма військового 1921",
                    DateOpen = Convert.ToDateTime("01.01.1921"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 3
                        }
                    }
                },
                //1933
                new Details()
                {
                    Id = 27,
                    Name = "Форма 1933",
                    Description = "Форма військового 1933",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 4
                        }
                    }
                },
                //1945
                new Details()
                {
                    Id = 28,
                    Name = "Форма 1945",
                    Description = "Форма військового 1945,яка мала броніжилет",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 6
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 29,
                    Name = "Форма 1970",
                    Description = "Форма військового 1970,яка мала броніжилет",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 40
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 8
                        }
                    }
                },
                //1990
                new Details()
                {
                    Id = 30,
                    Name = "Форма 1990",
                    Description = "Форма військового 1990,яка мала броніжилет",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 50
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 10
                        }
                    }
                },
                //2000
                new Details()
                {
                    Id = 31,
                    Name = "Форма 2000",
                    Description = "Форма військового 2000,яка мала броніжилет",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 60
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 12
                        }
                    }
                },
                //Dodatkove
                //1910
                new Details()
                {
                    Id = 32,
                    Name = "Аптечка 1910",
                    Description = "Аптечка 1910 р.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 33,
                    Name = "Снайперське оснащення 1910",
                    Description = "Снайперське оснащення 1910 р.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 34,
                    Name = "Оснащення кулеметника 1910",
                    Description = "Оснащення кулеметника 1910 р.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 5
                        }
                    }
                },
                //1914
                new Details()
                {
                    Id = 35,
                    Name = "Аптечка 1914",
                    Description = "Аптечка 1914 р.",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 36,
                    Name = "Снайперське оснащення 1914",
                    Description = "Снайперське оснащення 1914 р.",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 37,
                    Name = "Оснащення кулеметника 1914",
                    Description = "Оснащення кулеметника 1914 р.",
                    DateOpen = Convert.ToDateTime("01.01.1914"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        }
                    }
                },
                //1916 add minomet
                new Details()
                {
                    Id = 38,
                    Name = "Аптечка 1916",
                    Description = "Аптечка 1916 р.",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 39,
                    Name = "Снайперське оснащення 1916",
                    Description = "Снайперське оснащення 1916 р.",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 40,
                    Name = "Оснащення кулеметника 1916",
                    Description = "Оснащення кулеметника 1916 р.",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 41,
                    Name = "Оснащення мінометника 1916",
                    Description = "Оснащення мінометника 1916 р.",
                    DateOpen = Convert.ToDateTime("01.01.1916"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 4
                        }
                    }
                },
                //1933
                new Details()
                {
                    Id = 42,
                    Name = "Аптечка 1933",
                    Description = "Аптечка 1933 р.",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 43,
                    Name = "Снайперське оснащення 1933",
                    Description = "Снайперське оснащення 1933 р.",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 44,
                    Name = "Оснащення кулеметника 1933",
                    Description = "Оснащення кулеметника 1933 р.",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 45,
                    Name = "Оснащення мінометника 1933",
                    Description = "Оснащення мінометника 1933 р.",
                    DateOpen = Convert.ToDateTime("01.01.1933"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 6
                        }
                    }
                },
                //1945
                new Details()
                {
                    Id = 46,
                    Name = "Аптечка 1945",
                    Description = "Аптечка 1945 р.",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 47,
                    Name = "Снайперське оснащення 1945",
                    Description = "Снайперське оснащення 1945 р.",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 48,
                    Name = "Оснащення кулеметника 1945",
                    Description = "Оснащення кулеметника 1945 р.",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 49,
                    Name = "Оснащення мінометника 1945",
                    Description = "Оснащення мінометника 1945 р.",
                    DateOpen = Convert.ToDateTime("01.01.1945"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 8
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 50,
                    Name = "Аптечка 1970",
                    Description = "Аптечка 1970 р.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 30
                        }
                    }
                },
                new Details()
                {
                    Id = 51,
                    Name = "Снайперське оснащення 1970",
                    Description = "Снайперське оснащення 1970 р.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        }
                    }
                },
                new Details()
                {
                    Id = 52,
                    Name = "Оснащення кулеметника 1970",
                    Description = "Оснащення кулеметника 1970 р.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        }
                    }
                },
                new Details()
                {
                    Id = 53,
                    Name = "Оснащення мінометника 1970",
                    Description = "Оснащення мінометника 1970 р.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 10
                        }
                    }
                },
                //1990
                new Details()
                {
                    Id = 54,
                    Name = "Аптечка 1990",
                    Description = "Аптечка 1990 р.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 55,
                    Name = "Снайперське оснащення 1990",
                    Description = "Снайперське оснащення 1990 р.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 56,
                    Name = "Оснащення кулеметника 1990",
                    Description = "Оснащення кулеметника 1990 р.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 57,
                    Name = "Оснащення мінометника 1990",
                    Description = "Оснащення мінометника 1990 р.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 12
                        }
                    }
                },
                //2000
                new Details()
                {
                    Id = 58,
                    Name = "Аптечка 2000",
                    Description = "Аптечка 2000 р.",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 59,
                    Name = "Снайперське оснащення 2000",
                    Description = "Снайперське оснащення 2000 р.",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 60,
                    Name = "Оснащення кулеметника 2000",
                    Description = "Оснащення кулеметника 2000 р.",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 61,
                    Name = "Оснащення мінометника 2000",
                    Description = "Оснащення мінометника 2000 р.",
                    DateOpen = Convert.ToDateTime("01.01.2000"),
                    TypeDetail = TypeDet.Forma,
                    TypeEquipment = TypeEq.Forma,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 40
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 14
                        }
                    }
                },
                //Artillery
                //1910
                new Details()
                {
                    Id = 62,
                    Name = "Стандартна основа",
                    Description = "Стандартна основа для гаубиць",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.Basa,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 63,
                    Name = "105-мм гаубиця",
                    Description = "Цей калібр був широко використовуваний протягом Першої світової війни та міжвоєнного періоду.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 64,
                    Name = "150-мм гаубиця",
                    Description = "Цей калібр також був популярним в період p 1910-1930 рр і застосовувався в різних країнах.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 50
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 65
                        }
                    }
                },
                //1930
                new Details()
                {
                    Id = 65,
                    Name = "122-мм гаубиця",
                    Description = "Цей калібр став поширеним під час Другої світової війни та після неї.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 66,
                    Name = "155-мм гаубиця",
                    Description = "Цей калібр був широко використовуваний багатьма країнами у період 1930-1940 рр.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 55
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 70
                        }
                    }
                },
                //1940
                new Details()
                {
                    Id = 67,
                    Name = "Базове шасі",
                    Description = "Базове шасі для САУ",
                    DateOpen = Convert.ToDateTime("01.01.1940"),
                    TypeDetail = TypeDet.Basa,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[4],
                            Parametr = 5
                        }
                    }
                },
                //1950
                new Details()
                {
                    Id = 68,
                    Name = "122-мм гаубиця D-30",
                    Description = "Ця гаубиця була розроблена в СРСР та стала дуже поширеною в арміях багатьох країн.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 69,
                    Name = "105-мм гаубиця M101",
                    Description = "Цей калібр також продовжував застосовуватися в період Холодної війни у багатьох країнах.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 40
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 70,
                    Name = "122-мм гаубиця 2A18",
                    Description = "Ця модернізована версія D-30 продовжувала бути популярною.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 45
                        }
                    }
                },
                new Details()
                {
                    Id = 71,
                    Name = "155-мм гаубиця M198",
                    Description = "Цей калібр також продовжував застосовуватися в період Холодної війни у багатьох країнах.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 60
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 75
                        }
                    }
                },
                //1990
                new Details()
                {
                    Id = 72,
                    Name = "155-мм гаубиця M777",
                    Description = "Цей калібр став новим стандартом для артилерії США та інших країн.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 65
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 80
                        }
                    }
                },
                new Details()
                {
                    Id = 73,
                    Name = "122-мм гаубиця 2S19 Msta-S",
                    Description = "Ця модернізована гаубиця стала широко поширеною у збройних силах Росії та інших країн.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.GarmataTank,
                    TypeEquipment = TypeEq.Artillery,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 50
                        }
                    }
                },
                //Tank
                //1917
                new Details()
                {
                    Id = 74,
                    Name = "Корпус танка Першої світової",
                    Description = "Корпус танка створений в 1917 році",
                    DateOpen = Convert.ToDateTime("01.01.1917"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 30
                        }
                    }
                },
                new Details()
                {
                    Id = 75,
                    Name = "Бензинові двигуни",
                    Description = "У ранніх моделях танків використовувалися бензинові двигуни, подібні до автомобільних.",
                    DateOpen = Convert.ToDateTime("01.01.1917"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 3
                        }
                    }
                },
                new Details()
                {
                    Id = 76,
                    Name = "Дизельні двигуни",
                    Description = "В деяких танках, зокрема в німецьких, вже у цей період були використані дизельні двигуни, які відрізнялися більшою економічністю палива.",
                    DateOpen = Convert.ToDateTime("01.01.1917"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 6
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 3
                        }
                    }
                },
                new Details()
                {
                    Id = 77,
                    Name = "Легка броня",
                    Description = "У перші роки розвитку танків використовувалася легка броня, зазвичай товщиною до 10 мм. Це надавало обмежений захист від стрілецької зброї того часу.",
                    DateOpen = Convert.ToDateTime("01.01.1917"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 78,
                    Name = "Легка броня з додатковими бронеплитами",
                    Description = "У деяких випадках використовувалися додаткові бронеплити або верстатна броня, що збільшувала загальну товщину броні.",
                    DateOpen = Convert.ToDateTime("01.01.1917"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 7
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 12
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 6
                        }
                    }
                },
                //1930
                new Details()
                {
                    Id = 79,
                    Name = "Міжвійськовий корпус танка",
                    Description = "Корпус танка створений в 1921-1930 році",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 40
                        }
                    }
                },
                new Details()
                {
                    Id = 80,
                    Name = "Дизельні двигуни II",
                    Description = "Зростаюча популярність дизельних двигунів у транспорті позначилася і на танковій техніці. Багато країн переходили на використання дизелів у своїх танках.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 7
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 3
                        }
                    }
                },
                new Details()
                {
                    Id = 81,
                    Name = "Середня броня",
                    Description = "У міжвійськовий період танки стали отримувати більшу товщину броні, особливо під час Другої світової війни.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 82,
                    Name = "Хромова броня",
                    Description = "Використання хромованої броні та складних конструкцій дозволяло досягти більшої стійкості до прямих ударів та вогнепальної зброї.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 15
                        }
                    }
                },
                //1939
                new Details()
                {
                    Id = 83,
                    Name = "Базовий корпус танка",
                    Description = "Корпус танка створений в 1939 році",
                    DateOpen = Convert.ToDateTime("01.01.1939"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 40
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 45
                        }
                    }
                },
                //1950
                new Details()
                {
                    Id = 84,
                    Name = "Турбодизельні двигуни",
                    Description = "В цей період почали розвивати турбодизельні двигуни, які використовували турбокомпресори для підвищення продуктивності.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 12
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 85,
                    Name = "Газотурбінні двигуни",
                    Description = "Деякі експериментальні танки, зокрема в США, використовували газотурбінні двигуни, які забезпечували високу швидкість руху.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 6
                        }
                    }
                },
                new Details()
                {
                    Id = 86,
                    Name = "Легка легкосплавлена броня",
                    Description = "Розвиток нових технологій, зокрема легкої легкосплавної броні, дозволив зменшити вагу танків, зберігаючи при цьому високий рівень захисту.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 87,
                    Name = "Броня проти ракет і снарядів",
                    Description = "Броня була орієнтована на захист від артилерійських снарядів та протитанкових ракет.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 45
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 88,
                    Name = "Покращений корпус танка",
                    Description = "Корпус танка створений в 1950 році",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 45
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 50
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 89,
                    Name = "Модифіковані дизельні двигуни",
                    Description = "Були розроблені та вдосконалені дизельні двигуни з покращеними характеристиками тяги, ефективності та надійності.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 17
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 6
                        }
                    }
                },
                new Details()
                {
                    Id = 90,
                    Name = "Газотурбінні двигуни II",
                    Description = "Газотурбінні двигуни продовжували використовуватися в окремих моделях танків, особливо в деяких важких танках або в техніці для спеціальних завдань.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 16
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 6
                        }
                    }
                },
                new Details()
                {
                    Id = 91,
                    Name = "Композитна броня",
                    Description = "З'явлення композитних матеріалів, таких як кераміка або складні армор, дозволило значно покращити захист танків.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 40
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 92,
                    Name = "ERA",
                    Description = "Перша реактивна динамічна система.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 50
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 65
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 93,
                    Name = "Покращений корпус танка II",
                    Description = "Корпус танка створений в 1970 році",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 50
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 55
                        }
                    }
                },
                //1990
                new Details()
                {
                    Id = 94,
                    Name = "Покращені дизельні двигуни",
                    Description = "Дизельні двигуни продовжували бути основними у більшості сучасних танків. Проведені інновації та покращення спрямовувалися на збільшення продуктивності, зниження шуму та викидів.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 7
                        }
                    }
                },
                new Details()
                {
                    Id = 95,
                    Name = "Гібридні системи",
                    Description = "У деяких експериментальних танках використовувалися гібридні системи, які поєднували дизельні двигуни з електричними моторами для зниження споживання палива та поліпшення маневреності.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.DvugunTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 21
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 8
                        }
                    }
                },
                new Details()
                {
                    Id = 96,
                    Name = "Багатошарова конструкція броня",
                    Description = "У цей період поширені стали складні багатошарові конструкції броні, що складалися з різних матеріалів, таких як сталь, кераміка та композити.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 45
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 21
                        }
                    }
                },
                new Details()
                {
                    Id = 97,
                    Name = "NERA і APS",
                    Description = "Введення реактивних бронепанелей (NERA) та активних систем захисту, таких як системи активного захисту (APS), дозволило підвищити захист танків від сучасних загроз.",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.BronyaTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 55
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 70
                        },
                        new AtributesAll()
                        {
                            Id = 2,
                            Atributte = atributtes[5],
                            Parametr = 23
                        }
                    }
                },
                new Details()
                {
                    Id = 98,
                    Name = "Сучасний корпус танка",
                    Description = "Корпус танка створений в 1990 році",
                    DateOpen = Convert.ToDateTime("01.01.1990"),
                    TypeDetail = TypeDet.KorpusTank,
                    TypeEquipment = TypeEq.Tank,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 55
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 60
                        }
                    }
                },
                //Auto, Btr, Bmp
                //1910
                new Details()
                {
                    Id = 99,
                    Name = "Корпус авто",
                    Description = "Корпус авто створений в 1910 році",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.KorpusAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Auto,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 100,
                    Name = "Бензиновий двигун",
                    Description = "Більшість автомобілів у цей період використовували бензинові двигуни з внутрішнім згорянням. Це були переважно розподільчі двигуни з невеликою потужністю, що працювали на бензині.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.DvugunAuto,
                    TypeEquipment = TypeEq.Auto,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 5
                        }
                    }
                },
                //1930
                new Details()
                {
                    Id = 101,
                    Name = "Корпус БТР",
                    Description = "Корпус БТР створений в 1930 році",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.KorpusAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Btr,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 102,
                    Name = "Корпус БМП",
                    Description = "Корпус БМП створений в 1930 році",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.KorpusAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Bmp,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 103,
                    Name = "Дизельний двигун",
                    Description = "У цей період дизельні двигуни стали більш популярними в БТР і БМП, оскільки вони були економічнішими і мали кращі показники тяги порівняно з бензиновими двигунами.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.DvugunAuto,
                    TypeEquipment = TypeEq.Auto,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 12
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 6
                        }
                    }
                },
                new Details()
                {
                    Id = 104,
                    Name = "Кулемет",
                    Description = "Звичайний кулемет на БТР",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Btr,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 5
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 4
                        }
                    }
                },
                new Details()
                {
                    Id = 105,
                    Name = "Гармата 20мм",
                    Description = "Звичайна маленька гармата 20мм, яка ставилася зазвичай на БМП.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Bmp,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 11
                        }
                    }
                },
                new Details()
                {
                    Id = 106,
                    Name = "Ранні ракетні системи",
                    Description = "Перші примитивні ракетні системи, які ставилися на БМП.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Bmp,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 17
                        }
                    }
                },
                //1950
                new Details()
                {
                    Id = 107,
                    Name = "Дизельний двигун з турбонаддувом",
                    Description = "Дизельні двигуни з турбонаддувом стали поширеними в цей період, забезпечуючи більшу продуктивність і швидкість.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.DvugunAuto,
                    TypeEquipment = TypeEq.Auto,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 7
                        }
                    }
                },
                new Details()
                {
                    Id = 108,
                    Name = "Гармата 100мм",
                    Description = "Стандартна гармата 100мм",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Btr,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 109,
                    Name = "Автоматична гармата",
                    Description = "Звичайна гармата з автоматом заряджання.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Btr,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 22
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 110,
                    Name = "ПТО",
                    Description = "Протитанкові гармати, які ставилися на БМП.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Bmp,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 111,
                    Name = "ППО",
                    Description = "Проти повітряні гармати, які ставилися на БМП.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Ppo,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 20
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 112,
                    Name = "Гармата 125мм",
                    Description = "Потужна 125мм гармата.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Bmp,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 35
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 35
                        }
                    }
                },
                new Details()
                {
                    Id = 113,
                    Name = "Зенітні ракетні системи",
                    Description = "Проти повітряні ракетні системи, які ставилися на БМП.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.GarmataAuto,
                    TypeEquipment = TypeEq.Auto,
                    TypeAuto = TypeAuto.Ppo,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 30
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 30
                        }
                    }
                },
                //Plane
                //1910
                new Details()
                {
                    Id = 114,
                    Name = "Корпус літака Першої світової",
                    Description = "Корпус літака, який придумали у 1910 році.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.KorpusPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 10
                        }
                    }
                },
                new Details()
                {
                    Id = 115,
                    Name = "Бензиновий двигун",
                    Description = "На початку цього періоду були популярні різновиди бензинових двигунів, зазвичай рядового або зірчастого типу.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.DvugunPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 116,
                    Name = "Кулемет",
                    Description = "На початку цього періоду літаки часто використовувалися для спостереження та розвідки. Озброєння складалося з кулеметів.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Fighter,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 5
                        }
                    }
                },
                new Details()
                {
                    Id = 117,
                    Name = "Легкі бомби",
                    Description = "На початку цього періоду літаки часто використовувалися для спостереження та розвідки. Озброєння складалося з легких бомб, які були кинуті вручну.",
                    DateOpen = Convert.ToDateTime("01.01.1910"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Shturmovik,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 10
                        }
                    }
                },
                //1930
                new Details()
                {
                    Id = 118,
                    Name = "Міжвоєний корпус літака",
                    Description = "Корпус літака, який придумали у 1930 році.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.KorpusPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 119,
                    Name = "Дизельний двигун",
                    Description = "Розвиток авіаційної технології призвів до введення в експлуатацію більш потужних та ефективних двигунів.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.DvugunPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 15
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 8
                        }
                    }
                },
                new Details()
                {
                    Id = 120,
                    Name = "Канони",
                    Description = "Розвиток авіації військового призначення призвів до виникнення багатоцільових літаків, озброєних канонами",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Shturmovik,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 10
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 15
                        }
                    }
                },
                new Details()
                {
                    Id = 121,
                    Name = "Ракети",
                    Description = "Розвиток авіації військового призначення призвів до виникнення багатоцільових літаків, озброєних ракетами.",
                    DateOpen = Convert.ToDateTime("01.01.1930"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Bomber,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 25
                        }
                    }
                },
                //1950
                new Details()
                {
                    Id = 122,
                    Name = "Повоєний корпус літака",
                    Description = "Корпус літака, який придумали у 1950 році.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.KorpusPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[1],
                            Parametr = 20
                        }
                    }
                },
                new Details()
                {
                    Id = 123,
                    Name = "Турбовентиляторний двигун",
                    Description = "Головними досягненнями було використання турбовентиляторних двигунів, які надавали велику тягу при меньших споживаннях палива.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.DvugunPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 20
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 11
                        }
                    }
                },
                new Details()
                {
                    Id = 124,
                    Name = "Ракети повітря-повіря",
                    Description = "Ці ракеи швидко і точно вражають ворожу авіацію.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Fighter,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 25
                        }
                    }
                },
                new Details()
                {
                    Id = 125,
                    Name = "Ракети повітря-земля",
                    Description = "Дані ракети призначені для точного враження по ворожій техніці з повітря.",
                    DateOpen = Convert.ToDateTime("01.01.1950"),
                    TypeDetail = TypeDet.GarmataPlane,
                    TypeEquipment = TypeEq.Plane,
                    TypePlane = TypePlane.Shturmovik,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[3],
                            Parametr = 30
                        }
                    }
                },
                //1970
                new Details()
                {
                    Id = 126,
                    Name = "Двигуни з вектором тяги",
                    Description = "В цей період почали використовуватися пристрої для переходу на використання двигунів з вектором тяги, таких як векторовані тягові двигуни та вентильовані тягові двигуни. Це дозволило досягти кращої маневреності і контролю літаків.",
                    DateOpen = Convert.ToDateTime("01.01.1970"),
                    TypeDetail = TypeDet.DvugunPlane,
                    TypeEquipment = TypeEq.Plane,
                    Atributtes = new List<AtributesAll>
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 25
                        },
                        new AtributesAll()
                        {
                            Id = 1,
                            Atributte = atributtes[5],
                            Parametr = 13
                        }
                    }
                }
            };
        }

        void InitilizationIdeology()
        {
            ideologies = new List<Ideology>()
            {
                new Ideology()
                {
                    Id = 0,
                    Name = "Демократія",
                    Description = "Демократія - це політичний система, в якій влада належить народу. Вона передбачає рівність громадян перед законом, свободу слова, право на вибори та участь у прийнятті рішень через демократичні процеси, такі як голосування.",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[5],
                            Parametr = -10
                        }
                    }
                },
                new Ideology()
                {
                    Id = 1,
                    Name = "комунізм",
                    Description = "комунізм - це соціально-економічна теорія та політичний ідеал, який прагне до створення класового бездержавного суспільства, де засоби виробництва відносяться до спільної власності, а ресурси розподіляються на основі потреб кожного.",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = -10
                        }
                    }
                },
                new Ideology()
                {
                    Id = 2,
                    Name = "Фашизм",
                    Description = "Фашизм - це авторитарна тоталітарна ідеологія та політичний режим, що прагне до контролю над усіма аспектами суспільства. Він характеризується сильним лідерством, націоналістичною риторикою, воєнним превалюванням та репресивними методами управління.",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = 10
                        }
                    }
                },
                new Ideology()
                {
                    Id = 3,
                    Name = "Соціал-націоналізм",
                    Description = "Соціал-націоналізм - це політичний течія, яка поєднує елементи соціалізму з націоналістичними ідеями. Вона висуває принципи соціальної справедливості, громадського добробуту та національної самостійності.",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = 10
                        }
                    }
                },
                new Ideology()
                {
                    Id = 4,
                    Name = "Інтегральний націоналізм",
                    Description = "Інтегральний націоналізм - це політична доктрина, що акцентує національну ідентичність та об'єднання всіх суспільних сфер. Вона наголошує національну єдність, сильне урядування та велике значення культурних традицій та цінностей.",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = 10
                        }
                    }
                },
            };
        }

        void InitilizationBuilds()
        {
            builds = new List<Build>()
            {
                new Build()
                {
                    Id = 0,
                    Name = "Цивільна фабрика",
                    Description = "",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[0],
                            Parametr = (int)0.5
                        }
                    }
                },
                new Build()
                {
                    Id = 1,
                    Name = "Військовий завод",
                    Description = "",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[2],
                            Parametr = (int)0.5
                        }
                    }
                },
                new Build()
                {
                    Id = 2,
                    Name = "Інфаструктура",
                    Description = "",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[4],
                            Parametr = (int)0.5
                        }
                    }
                },
                new Build()
                {
                    Id = 3,
                    Name = "Бункер",
                    Description = "",
                    Atributtes = new List<AtributesAll>()
                    {
                        new AtributesAll()
                        {
                            Id = 0,
                            Atributte = atributtes[1],
                            Parametr = (int)0.5
                        }
                    }
                },
            };
        }
    }
}