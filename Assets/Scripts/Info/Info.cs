using Assets.Scripts.Classes;
using Assets.Scripts.Classes.Initilization;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Assets.Scripts.Info
{
    public class Info : MonoBehaviour
    {
        public StartInitilization start;
        public InputField nameCounFind;
        public Text nameCountry;
        public Text nameLeader;
        public Text nameIdeology;
        public Text characterLeader;
        public Text characterIdeology;
        public Text recriut;
        public Text description;
        public RawImage flag;
        public Text kilkCivText;
        public Text kilkArmText;
        Country findCoun;

        public void Find()
        {
            for (int i = 0; i < start.countries.Count; i++)
            {
                if (start.countries[i].Name == nameCounFind.text)
                {
                    findCoun = start.countries[i];
                    nameCountry.text = "Name: " + start.countries[i].Name;
                    nameLeader.text = "Name l: " + start.countries[i].Leader.Name;
                    nameIdeology.text = "Id: " + start.countries[i].Ideology.Name;
                    recriut.text = "Recriut: " + start.countries[i].Recruit.ToString();
                    characterIdeology.text = "Paramtr id: " + start.countries[i].Ideology.Atributtes[0].Atributte.Name + " : " + start.countries[i].Ideology.Atributtes[0].Parametr;
                    characterLeader.text = "Paramtr l: " + start.countries[i].Leader.Atributtes[0].Atributte.Name + " : " + start.countries[i].Leader.Atributtes[0].Parametr;
                    description.text = "Description: \n" + start.countries[i].Description;
                    LoadFlag();
                    for (int j = 0; j < start.countries[i].KilkistyBuilds.Count; j++)
                    {
                        if (start.countries[i].KilkistyBuilds[j].Build.Name == "Цивільна фабрика")
                        {
                            kilkCivText.text = "Kilk civ: " + start.countries[i].KilkistyBuilds[j].Kilkisty;
                        }
                    }
                    for (int j = 0; j < start.countries[i].KilkistyBuilds.Count; j++)
                    {
                        if (start.countries[i].KilkistyBuilds[j].Build.Name == "Військовий завод")
                        {
                            kilkArmText.text = "Kilk arm: " + start.countries[i].KilkistyBuilds[j].Kilkisty;
                        }
                    }
                }
            }
        }

        public void AddCiv()
        {
            if (findCoun.KilkistyBuilds.Count > 0)
            {
                for (int j = 0; j < findCoun.KilkistyBuilds.Count; j++)
                {
                    if (findCoun.KilkistyBuilds[j].Build.Name == "Цивільна фабрика")
                    {
                        findCoun.KilkistyBuilds[j].Kilkisty++;
                    }
                    else
                    {
                        BuildCountry build = new BuildCountry()
                        {
                            Id = findCoun.KilkistyBuilds.Count + 1,
                            Build = start.builds[0],
                            Kilkisty = 1
                        };

                        for (int i = 0; i < start.countries.Count; i++)
                        {
                            if (start.countries[i].Name == nameCounFind.text)
                            {
                                start.countries[i].KilkistyBuilds.Add(build);
                                findCoun = start.countries[i];
                            }
                        }
                    }
                }
            }
            else
            {
                BuildCountry build = new BuildCountry()
                {
                    Id = findCoun.KilkistyBuilds.Count + 1,
                    Build = start.builds[0],
                    Kilkisty = 1
                };

                for (int i = 0; i < start.countries.Count; i++)
                {
                    if (start.countries[i].Name == nameCounFind.text)
                    {
                        start.countries[i].KilkistyBuilds.Add(build);
                        findCoun = start.countries[i];
                    }
                }
            }
        }

        public void LoadFlag()
        {
            StartCoroutine(LoadImage());
        }

        public IEnumerator LoadImage()
        {
            // Створюємо об'єкт UnityWebRequest з URL-адресою зображення
            UnityWebRequest www = UnityWebRequestTexture.GetTexture(findCoun.flagUrl);

            // Виконуємо запит на завантаження зображення
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                // Отримуємо текстуру з завантаженого зображення
                Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;

                // Встановлюємо отриману текстуру в компонент зображення
                flag.texture = texture;
            }
            else
            {
                // Виникла помилка під час завантаження зображення
                Debug.Log("Error loading image: " + www.error);
            }
        }

        void Update()
        {
            if(findCoun.KilkistyBuilds.Count > 0)
            {
                for (int j = 0; j < findCoun.KilkistyBuilds.Count; j++)
                {
                    if (findCoun.KilkistyBuilds[j].Build.Name == "Цивільна фабрика")
                    {
                        kilkCivText.text = "Kilk civ: " + findCoun.KilkistyBuilds[j].Kilkisty;
                    }
                }
                for (int j = 0; j < findCoun.KilkistyBuilds.Count; j++)
                {
                    if (findCoun.KilkistyBuilds[j].Build.Name == "Військовий завод")
                    {
                        kilkArmText.text = "Kilk arm: " + findCoun.KilkistyBuilds[j].Kilkisty;
                    }
                }
            }
        }
    }
}