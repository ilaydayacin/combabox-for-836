﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combabox_for_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                lbSayi.Items.Add(rnd.Next(1,101));
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            cmbCift.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayi.Items[i]);
                if (sayi % 2 == 0)
                {
                    cmbCift.Items.Add(sayi);
                }
            }
        }

        private void btnTekAtar_Click(object sender, EventArgs e)
        {
            cmbTek.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayi.Items[i]);
                if (sayi % 2 != 0)
                {
                    cmbTek.Items.Add(sayi);
                }

            }
        }
    }
}
