﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormSistemaSolar
{
    public partial class Form1 : Form
    {
        
        private static List<Astro> planetas;
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add(Tipo.Gaseoso);
            cmbTipo.Items.Add(Tipo.Rocoso);
        }
    }
}
