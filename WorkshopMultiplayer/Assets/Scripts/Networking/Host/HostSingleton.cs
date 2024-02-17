using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class HostSingleton : MonoBehaviour
{
   public static HostSingleton instance;
   private HostGameManager gameManager;

   public static HostSingleton Instance
   {
      get
      {
         if (instance == null) { return instance; }
         instance = FindFirstObjectByType<HostSingleton>();
         
         if (instance == null)
         {
            Debug.LogError("No ClientSingleton in the scene ");
            return null;
         }
         return instance;
      }
   }

   void Start()
   {
      DontDestroyOnLoad(gameObject);
   }

   public void CreateHost()
   {
      gameManager = new HostGameManager();
     
   }
}
