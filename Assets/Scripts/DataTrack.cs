using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataTrack : MonoBehaviour
{
    [SerializeField] public TMP_InputField userNameInput;
    [SerializeField] public TMP_InputField passwordInput;



    public void Save()
    {
        Data data = new Data(); 
        data.userName = userNameInput.text;
        data.password = passwordInput.text;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/UserDataFile.json", json);
    }

    public void Load()
    {
        string json = File.ReadAllText(Application.dataPath + "/UserDataFile.json");
        Data data = JsonUtility.FromJson<Data>(json);

        userNameInput.text = data.userName;
        passwordInput.text = data.password;
    }
}
