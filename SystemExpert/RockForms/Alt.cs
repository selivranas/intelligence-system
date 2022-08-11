﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SystemExpert.MainForms;
using SystemExpert.Services;

namespace SystemExpert
{
    public partial class Alt : Form
    {
        private readonly MainForm mainform;
        public Alt(MainForm t_mainform)
        {
            InitializeComponent();
            mainform = t_mainform;
            GenreService.SetCurrentGenre(Enums.GenresTypeEnum.Альт);

            List<string> types = GenreService.GetCurrentGenreFeatures();
            List<string> genres = GenreService.GetCurrentGenreNames();

            label1.Text = types[0];
            label2.Text = types[1];
            label3.Text = types[2];
            label4.Text = types[3];
            label5.Text = types[4];

            linkLabel1.Text = genres[0];
            linkLabel2.Text = genres[1];
            linkLabel3.Text = genres[2];
            linkLabel4.Text = genres[3];
            linkLabel5.Text = genres[4];

            List<string> list_groups1 = GenreService.GetCurrentGenreGroups(genres[0]);
            List<string> list_groups2 = GenreService.GetCurrentGenreGroups(genres[1]);
            List<string> list_groups3 = GenreService.GetCurrentGenreGroups(genres[2]);
            List<string> list_groups4 = GenreService.GetCurrentGenreGroups(genres[3]);
            List<string> list_groups5 = GenreService.GetCurrentGenreGroups(genres[4]);

            string groups1 = String.Join("\n", list_groups1.ToArray());
            string groups2 = String.Join("\n", list_groups2.ToArray());
            string groups3 = String.Join("\n", list_groups3.ToArray());
            string groups4 = String.Join("\n", list_groups4.ToArray());
            string groups5 = String.Join("\n", list_groups5.ToArray());

            ToolTip yourToolTip = new ToolTip();
            yourToolTip.IsBalloon = true;
            yourToolTip.ShowAlways = true;

            yourToolTip.SetToolTip(linkLabel1, $"Лучшие группы: \n{groups1}");
            yourToolTip.SetToolTip(linkLabel2, $"Лучшие группы: \n{groups2}");
            yourToolTip.SetToolTip(linkLabel3, $"Лучшие группы: \n{groups3}");
            yourToolTip.SetToolTip(linkLabel4, $"Лучшие группы: \n{groups4}");
            yourToolTip.SetToolTip(linkLabel5, $"Лучшие группы: \n{groups5}");
        }

        private void Alt_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/%D0%93%D1%80%D0%B0%D0%BD%D0%B6",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/%D0%98%D0%BD%D0%B4%D0%B0%D1%81%D1%82%D1%80%D0%B8%D0%B0%D0%BB-%D1%80%D0%BE%D0%BA",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/%D0%9F%D0%BE%D0%BF-%D0%BF%D0%B0%D0%BD%D0%BA",
                UseShellExecute = true
            });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/%D0%A8%D1%83%D0%B3%D0%B5%D0%B9%D0%B7",
                UseShellExecute = true
            });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/%D0%9C%D1%8D%D0%B4%D1%87%D0%B5%D1%81%D1%82%D0%B5%D1%80",
                UseShellExecute = true
            });
        }
    }
}
