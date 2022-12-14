using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp7_pd
{
    public partial class Form1 : Form
    {
        private List<string> _cities;
        public Form1()
        {
            InitializeComponent();
            _cities = new List<string>();
            WriteCitiesToList();
        }

        private void WriteCitiesToList()
        {
            foreach (string item in cbCities.Items)
            {
                _cities.Add(item);
            }
            cbCities.Items.Clear(); // Записали и забыли
        }

        private int FindPartOfWorld()
        {
            // 1 - находим отмеченную страну
            foreach (Control item in grbPartOfWorld.Controls)
            {
                if (item is RadioButton r && r.Checked)
                {
                    return grbPartOfWorld.Controls.IndexOf(r);
                }
            }
            return -1; // - такого никогда не будет :)
        }
        private void RadioButtonChecked(object sender, EventArgs e) // Один метод для всех кнопок
        {
            int idOfCountry = FindPartOfWorld();

            // 2 - находим города соответствующей-выбранной страны
            cbCities.Items.Clear(); // Очистка городов предыдущей страны
            for (int i = 0; i < 3; i++)
            {
                cbCities.Items.Add(_cities[idOfCountry * 3 + i]);
            }
            cbCities.SelectedIndex = 0;
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idOfCountry = FindPartOfWorld();
            pbCities.Image = System.Drawing.Image.FromFile
                        ($"{System.IO.Directory.GetCurrentDirectory()}/CT/{idOfCountry * 3 + cbCities.SelectedIndex}.jpg");
        }
    }
}