using Assets.Scripts.Classes;
using Assets.Scripts.Classes.Initilization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public StartInitilization start;
    public InputField urlFlag;
    public InputField name;
    public InputField description;
    public InputField leaderName;
    public InputField population;
    public Dropdown ideology;
    public RawImage Flag;

    void Start()
    {
        
    }

    public void RegisterCount()
    {
        Leader newLeader = new Leader();
        Country newCoun = new Country();
        //Leader
        newLeader.Name = leaderName.text;
        int idAtr = UnityEngine.Random.Range(0, 6);
        int atrNum = UnityEngine.Random.Range(-5, 5);
        newLeader.Atributtes = new List<AtributesAll> { 
            new AtributesAll()
            {
                Id = 0,
                Atributte = start.atributtes[idAtr],
                Parametr = atrNum
            } 
        };
        newLeader.TypeLeader = TypeLeader.Country;
        //Country
        newCoun.Name = name.text;
        newCoun.Leader = newLeader;
        newCoun.Description = description.text;
        newCoun.flagUrl = urlFlag.text;
        newCoun.Population = Convert.ToInt32(population.text);
        newCoun.Recruit = newCoun.Population / 50;
        newCoun.Ideology = start.ideologies[ideology.value];
        start.leaders.Add(newLeader);
        start.countries.Add(newCoun);
        for (int i = 0; i < start.countries.Count; i++)
        {
            Debug.Log(start.countries[i].Name);
        }
    }

    public void LoadFlag()
    {
       StartCoroutine(LoadImage());
    }
    public IEnumerator LoadImage()
    {
        // Створюємо об'єкт UnityWebRequest з URL-адресою зображення
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(urlFlag.text);

        // Виконуємо запит на завантаження зображення
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            // Отримуємо текстуру з завантаженого зображення
            Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;

            // Встановлюємо отриману текстуру в компонент зображення
            Flag.texture = texture;
        }
        else
        {
            // Виникла помилка під час завантаження зображення
            Debug.Log("Error loading image: " + www.error);
        }
    }
}
