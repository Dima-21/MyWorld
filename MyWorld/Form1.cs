using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWorld
{
    public partial class Form1 : Form
    {
        World world = new World();
        const int TICK_DIV = 10;
        const int PriceWarrior = 50;
        const int PriceHuman = 30;
        public Form1()
        {
            InitializeComponent();
            Update();
        }
        private void Update()
        {
            TrackSell.Maximum  = TrackHire.Maximum = world.Human;
            TrackSend.Maximum = world.Warriors;
            TrackSell.TickFrequency = TrackHire.TickFrequency = world.Human / TICK_DIV;
            TrackSend.TickFrequency = world.Warriors / TICK_DIV;
            LSell.Text = TrackSell.Value.ToString();
            LHire.Text = TrackHire.Value.ToString();
            LSend.Text = TrackSend.Value.ToString();
            Show();
        }
        private void Show()
        {
            TextHuman.Text = Convert.ToString(world.Human);
            TextWarriors.Text = Convert.ToString(world.Warriors);
            TextMoney.Text = Convert.ToString(world.Money);
        }


        private void TrackSell_Scroll(object sender, EventArgs e)
        {
            LSell.Text = TrackSell.Value.ToString();
        }

        private void TrackHire_Scroll(object sender, EventArgs e)
        {
            LHire.Text = TrackHire.Value.ToString();
        }

        private void TrackSend_Scroll(object sender, EventArgs e)
        {
            LSend.Text = TrackSend.Value.ToString();
        }

        private void BSell_Click(object sender, EventArgs e)
        {
            world.Human -= TrackSell.Value;
            world.Money += TrackSell.Value * PriceHuman;
            Update();
        }

        private void BHire_Click(object sender, EventArgs e)
        {
            world.Human -= TrackHire.Value;
            world.Money -= TrackHire.Value * PriceHuman;
            Update();
        }

        private void BSend_Click(object sender, EventArgs e)
        {

        }
    }
}
