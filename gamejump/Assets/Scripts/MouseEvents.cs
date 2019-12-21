using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
   public UnityEvent mouseUpEvent, mouseDownEvent;

   private void OnMouseUp()
   {
       mouseUpEvent.Invoke();
   }

   private void OnMouseDown()
   {
       mouseDownEvent.Invoke();
   }
}


