using System.Collections.Generic;
using UnityEngine;

namespace Mochi.UI
{
    public class Stack : MonoBehaviour
    {
        private List<Screen> screens = new();

        private void Awake()
        {
            foreach(Screen s in screens)
            {
                s.Hide();
            }
        }

        public void Show(Screen screen)
        {
            foreach (Screen s in screens)
            {
                if (s != screen)
                {
                    s.Hide();
                }
                else
                {
                    s.Show();
                }
            }
        }
    }
}