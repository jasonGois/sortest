﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Gerenc_Prova
{
    public partial class cadastros : Form
    {
        public cadastros()
        {
            InitializeComponent();
        }

        private void CadNome_OnValueChanged(object sender, EventArgs e)
        {

        }
        Thread nt;
        private void CadEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(inicio);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void inicio()
        {
            Application.Run(new Form1());
        }

        private void Cadastros_Load(object sender, EventArgs e)
        {

        }
    }
}
