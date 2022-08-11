﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemExpert.MainForms;

namespace SystemExpert
{
    public partial class RockForm : Form
    {
        private readonly MainForm mainform;
        public RockForm(MainForm t_mainform)
        {
            InitializeComponent();
            start_form();
            mainform = t_mainform;
        }

        /// <summary>
        /// Функция возвращает свойства элементов к начальному
        /// </summary>
        private void start_form()
        {
            retry_button.Visible = false; //кнопка "начать сначала" невидима
            question1_groupBox.Visible = true;
            question2_groupBox.Visible = false;
        }


        // по идее должна возвращать на MainForm, но надо ли? может тогда лучше добавить в жанры?
        private void retry_button_Click(object sender, EventArgs e)
        {
            start_form();
        }

        private void question1_YES_Click(object sender, EventArgs e)
        {
            Metal metal = new Metal(mainform);            
            metal.Show();
            this.Close();
        }

        private void question1_NO_Click(object sender, EventArgs e)
        {
            question1_groupBox.Visible = false;
            question2_groupBox.Visible = true;
        }

        private void question2_YES_Click(object sender, EventArgs e)
        {
            Punk punk = new Punk(mainform);
            punk.Show();
            this.Close();
        }

        private void question2_NO_Click(object sender, EventArgs e)
        {
            Alt alt = new Alt(mainform);
            alt.Show();
            this.Close();
        }

        private void RockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainform.Show(); // идея не оч, так как главная форма вызывается всегда при закрытии,
                               // а не только при нажатии на крестик
        }
    }
}