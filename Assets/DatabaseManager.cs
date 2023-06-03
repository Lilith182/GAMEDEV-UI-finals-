using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Firebase.Database;

public class DatabaseManager : MonoBehaviour
{
//sign up part
  public TMP_InputField username;

  public TMP_InputField password;

//login part
  public TMP_InputField logInusername;

  public TMP_InputField logInpassword;

  private DatabaseReference reference;


    void Start()
    {
     reference = FirebaseDatabase.DefaultInstance.RootReference;   
    }

    public void SignUp(){
        User newUser = new User(this.password.text);
        string json = JsonUtility.ToJson(newUser);
        reference.Child("users").Child(username.text).SetRawJsonValueAsync(json);
        username.text = "";
        password.text = "";
    }

    public IEnumerator GetPassword(System.Action<string> onCallback){
      var password = reference.Child("users").Child(logInusername.text).Child("password").GetValueAsync();
      yield return new WaitUntil(predicate: () => password.IsCompleted);
      if(password != null){
        DataSnapshot ss = password.Result;
        try
        {
          onCallback.Invoke(ss.Value.ToString());
        }
        catch (System.Exception)
        {
            Debug.Log("failed");
            logInpassword.text = "";
            logInusername.text = "";
        
        }
      }
    }

    public void AuthenticatePassword(){
      StartCoroutine(GetPassword((string name) => {
        if(name == logInpassword.text){
          Debug.Log("Success");
          logInpassword.text = "";
          logInusername.text = "";
        } else {
          Debug.Log("Failed");
          logInpassword.text = "";
          logInusername.text = "";
        }
      }));
    }


}

