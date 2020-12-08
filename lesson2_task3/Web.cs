using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2_task3
{
    class Web
    {
        public string WebColor { get; set; } = "gray";

        public void ChangeWebColor(string value)
        {
            this.WebColor = value;
        }
    }
}
