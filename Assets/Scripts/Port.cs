using System;
using UnityEngine;
using UnityEngine.Events;

public class Port : MonoBehaviour
{
   [SerializeField] private Screw screw;
   [SerializeField] private UnityEvent onScrewRemoved;

   private void Start()
   {
      UpdateVisual();

   }

   public void AddScrew(Screw screw)
   {
      this.screw = screw;
      UpdateVisual();

   }

   public void RemoveScrew()
   {
      this.screw = null;
      onScrewRemoved?.Invoke();
      UpdateVisual();
   }
   
   public bool HasScrew
   {
      get => screw != null;
   }

   public Screw GetScrew
   {
      get => screw;
   }

   void UpdateVisual()
   {
      if(screw != null)
         GetComponent<SpriteRenderer>().color = Color.red;
      else
         GetComponent<SpriteRenderer>().color = Color.black;
   }
   
   
   
   
}