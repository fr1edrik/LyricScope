﻿using System;
using System.Windows.Forms;

namespace LyricScope
{
    class main
    {
      
        [STAThread]
        public static void Main(String[] args)
        {
            Application.SetCompatibleTextRenderingDefault(false);

            MainWindow window = new MainWindow();

            Application.EnableVisualStyles();
            
            Application.Run(window);
        }
    }
}
