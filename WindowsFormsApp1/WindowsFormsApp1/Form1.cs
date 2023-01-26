using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MAP : Form
    {
        public MAP()
        {
            InitializeComponent();
        }

        private void checkpoint1_Click(object sender, EventArgs e)
        {
            name.Text = "МЦК Лужники";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 157); Drinks.Location = new Point(644, 181);
            pictureBoxEnergy.Location = new Point(548, 255); EnergyBars.Location = new Point(644, 283);
        }

        private void checkpoint2_Click(object sender, EventArgs e)
        {
            name.Text = "Новодевичей монастырь";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 455); Drinks.Location = new Point(644, 472);
            pictureBoxEnergy.Location = new Point(548, 358); EnergyBars.Location = new Point(644, 375);

        }

        private void checkpoint3_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Киевская";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 157); Drinks.Location = new Point(644, 181);
            pictureBoxEnergy.Location = new Point(548, 255); EnergyBars.Location = new Point(644, 283);
        }

        private void checkpoint4_Click(object sender, EventArgs e)
        {
            name.Text = "МИД";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 358); Drinks.Location = new Point(644, 375);
            pictureBoxEnergy.Location = new Point(548, 255); EnergyBars.Location = new Point(644, 283);
        }

        private void checkpoint5_Click(object sender, EventArgs e)
        {
            name.Text = "Парк Горького";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; information.Visible = true;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 157); Drinks.Location = new Point(644, 181);
            pictureBoxEnergy.Location = new Point(548, 358); EnergyBars.Location = new Point(644, 375);
        }

        private void checkpoint6_Click(object sender, EventArgs e)
        {
            name.Text = "Здания РАН";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 157); Drinks.Location = new Point(644, 181);
            pictureBoxEnergy.Location = new Point(548, 255); EnergyBars.Location = new Point(644, 283);
        }

        private void checkpoint7_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Воробьевы горы";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 455); Drinks.Location = new Point(644, 472);
            pictureBoxEnergy.Location = new Point(548, 358); EnergyBars.Location = new Point(644, 375);
        }

        private void checkpoint8_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            pictureBoxToilets.Visible = true; Toilets.Visible = true;
            pictureBoxDrink.Visible = true; Drinks.Visible = true;
            pictureBoxEnergy.Visible = true; EnergyBars.Visible = true;
            pictureBoxInformation.Visible = true; information.Visible = true;
            pictureBoxMedical.Visible = true; Medical.Visible = true;
            marathon.Visible = false;
            pictureBoxDrink.Location = new Point(548, 455); Drinks.Location = new Point(644, 472);
            pictureBoxEnergy.Location = new Point(548, 358); EnergyBars.Location = new Point(644, 375);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name.Text = "Первый старт";
            marathon.Text = "Полный марафон 40 км";
            marathon.Visible = true;
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrink.Visible = false; Drinks.Visible = false;
            pictureBoxEnergy.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            name.Text = "Второй старт";
            marathon.Text = "Половинный марафон 20 км";
            marathon.Visible = true;
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrink.Visible = false; Drinks.Visible = false;
            pictureBoxEnergy.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            name.Text = "Третий старт";
            marathon.Text = "Веселая гонка 5 км";
            marathon.Visible = true;
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrink.Visible = false; Drinks.Visible = false;
            pictureBoxEnergy.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            name.Text = "Финиш";
            pictureBoxToilets.Visible = false; Toilets.Visible = false;
            pictureBoxDrink.Visible = false; Drinks.Visible = false;
            pictureBoxEnergy.Visible = false; EnergyBars.Visible = false;
            pictureBoxInformation.Visible = false; information.Visible = false;
            pictureBoxMedical.Visible = false; Medical.Visible = false;
        }
    }
}
